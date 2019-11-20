using System.Threading.Tasks;
using IUTAPI.Models;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using IUTAPI.Filters;
using System.IO;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Cors;

namespace IUTAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    [EnableCors("DevConsole")]
    [MiddlewareFilter(typeof(AuthorizationMiddlewarePipeline))]
    public class studentController : ControllerBase
    {
        readonly ApiDbContext Context;
        public studentController(ApiDbContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IEnumerable GetRooms()
        {
            return Context.Student;
        }

        [HttpPost]
        public IActionResult ReadCsvfile(IFormFile file)
        {
            List<string> student = new List<string>();
            List<Student> bat = new List<Student>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() > 0)
                {
                    student.Add(reader.ReadLine());
                }
                foreach (string c in student)
                {
                    if (c == null)
                        continue;
                    else
                    {
                        bat.Add(ReadFromCsv(c));

                    }
                }

                Context.Student.AddRange(bat);
                Context.SaveChanges();

                return Ok(bat);
            }
        }

        private Student ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var student = new Student
            {
                S_id = Convert.ToInt32(fields[0]),
                Id = Convert.ToInt32(fields[1]),
                Name = (fields[2]),
                Department = fields[3],
                Programme = fields[4],
                Batch = Convert.ToInt32(fields[5]),
                Address = fields[6],
                Email = fields[7],
                Gender = fields[8],
            };

            return student;
        }
    }
}

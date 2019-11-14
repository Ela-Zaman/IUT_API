using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IUTAPI.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("DevConsole")]
    [MiddlewareFilter(typeof(AuthorizationMiddlewarePipeline))]
    public class AssignedCoursesController : Controller
    {
        // GET: api/<controller>
        readonly AddDBContext Context;
        public AssignedCoursesController(AddDBContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IEnumerable Get()
        {
            return Context.CourseAssigned;
        }
        [HttpPost]
        public IActionResult ReadCsvfile(IFormFile file)
        {
            List<string> courseassign = new List<string>();
            List<CourseAssigned> pet = new List<CourseAssigned>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() > 0)
                {
                    courseassign.Add(reader.ReadLine());
                }
                foreach (string c in courseassign)
                {
                    if (c == null)
                        continue;
                    else
                    {
                        pet.Add(ReadFromCsv(c));

                    }
                }

                Context.CourseAssigned.AddRange(pet);
                Context.SaveChanges();

                return Ok(pet);
            }



        }

        private CourseAssigned ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var courseassign = new CourseAssigned
            {

                Ca_id = Convert.ToInt32(fields[0]),
                CourseId = fields[1],
                Facultyid = Convert.ToInt32(fields[2]),
                Semester = Convert.ToInt32(fields[3]),
                Batch = Convert.ToInt32(fields[4])
                
            };

            return courseassign;
        }

    }
}

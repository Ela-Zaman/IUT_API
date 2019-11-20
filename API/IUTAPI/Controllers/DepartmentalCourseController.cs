using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IUTAPI.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentalCourseController : ControllerBase
    {
        readonly ApiDbContext Context;
        public DepartmentalCourseController(ApiDbContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IActionResult GetRooms()
        {
            var deptcourse = Context.DepartmentalCourse.ToList();
            return Ok(deptcourse);
        }

        [HttpPost]
        public IActionResult ReadCsvfile(IFormFile file)
        {
            List<string> deptcourse = new List<string>();
            List<DepartmentalCourse> temp = new List<DepartmentalCourse>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() > 0)
                {
                    deptcourse.Add(reader.ReadLine());
                }
                foreach (string c in deptcourse)
                {
                    if (c == null)
                        continue;
                    else
                    {
                        temp.Add(ReadFromCsv(c));

                    }
                }

                Context.DepartmentalCourse.AddRange(temp);
                Context.SaveChanges();

                return Ok(temp);
            }
        }

        private DepartmentalCourse ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var deptcourse = new DepartmentalCourse
            {
                DC_id = Convert.ToInt32(fields[0]),
                Department=fields[1],
                Courseid= fields[2]
               
            };

            return deptcourse;
        }
    }
}
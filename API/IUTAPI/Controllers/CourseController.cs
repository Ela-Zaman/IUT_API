using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IUTAPI.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("DevConsole")]
    [MiddlewareFilter(typeof(AuthorizationMiddlewarePipeline))]
    public class CourseController : ControllerBase
    {
        readonly ApiDbContext Context;
        public CourseController(ApiDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        [EnableQuery()]
        public IActionResult GetRooms()
        {
            var course = Context.Course.ToList();
            return Ok(course);
        }

        [HttpPost]
        public IActionResult ReadCsvfile(IFormFile file)
        {
            List<string> course = new List<string>();
            List<Course> cat = new List<Course>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() > 0)
                {
                    course.Add(reader.ReadLine());
                }
                foreach (string c in course)
                {
                    if (c == null)
                        continue;
                    else
                    {
                        cat.Add(ReadFromCsv(c));

                    }
                }

                Context.Course.AddRange(cat);
                Context.SaveChanges();

                return Ok(cat);
            }
        }

        private Course ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var course = new Course
            {
                C_id = Convert.ToInt32(fields[0]),
                CourseId = fields[1],
                Title = fields[2],
                Credit = Convert.ToInt32(fields[3]),
                Deptartment = fields[4],
                Semester = Convert.ToInt32(fields[5]),
                Type = fields[6],
                PrerequisiteCourse = fields[7]
            };

            return course;
        }
    }
}
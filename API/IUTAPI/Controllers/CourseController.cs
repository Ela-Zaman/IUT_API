using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IUTAPI.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        readonly AddDBContext Context;
        public CourseController(AddDBContext context)
            => Context = context;

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
                while (reader.Peek() >0)
                {
                   course.Add(reader.ReadLine());
                }
                foreach(string c in course)
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
                CourseId = fields[0],
                Title = fields[1],
                Credit = Convert.ToInt32(fields[2]),
                Deptartment = fields[3],
                Semester = Convert.ToInt32(fields[4]),
                Type = fields[5],
                PrerequisiteCourse = fields[6]
            };

            return course;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using IUTAPI.Models;
using System.Text;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

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
        public IActionResult Create(IFormFile csvfile)
        {
            
            var course = new List<String>();
            using (var reader = new StreamReader(csvfile.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    if (String.IsNullOrWhiteSpace(reader.ReadLine()))
                    {
                        continue;
                    }
                        course.Add(reader.ReadLine());
                }
            }
            var courses = course.Select(line => ReadFromCsv(line));
            Context.Course.AddRange(courses);
            Context.SaveChanges();
            return Ok(courses);
        }

        private Course ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var course = new Course
            {
                CourseId = fields[0],
                Title = fields[1],
               
                Deptartment = fields[3],
               
                Type = fields[5],
                PrerequisiteCourse = fields[6]
            };

            return course;
        }
    }
}
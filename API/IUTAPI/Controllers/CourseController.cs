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
            var staff = Context.Course.ToList();
            return Ok(staff);
        }



        [HttpPost]





        public IActionResult ReadAsStringAsync( IFormFile file)
        {
            string courses;
            Course c = new Course();
        
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    if(string.IsNullOrWhiteSpace(reader.ReadLine()))
                    {
                        continue;
                    }
                    courses = reader.ReadLine();
                    c = ReadFromCsv(courses);
                }
               
                    Context.Course.AddRange(c);
                    Context.SaveChanges();

                    return Ok(c);
                }
              
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
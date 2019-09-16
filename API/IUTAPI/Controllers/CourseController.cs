using System;
using System.Collections.Generic;
using System.Data;
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

        [HttpGet("import")]
        public IActionResult Import()
        {
            // 
            var filepath = "C:\\Projects\\import2.csv";
           

            string[] Lines = System.IO.File.ReadAllLines(filepath);
           
            
            Course dt = new Course();
            string[] Fields;
            DataRow Row;
            for (int i = 0; i < Lines.GetLength(0) - 1; i++)
            {
                Fields = Lines[i].Split(new char[] { ',' });


                Context.Course.Add(new Course
                {
                    CourseId = Fields[0],
                    Title = Fields[1],
                    Credit = Convert.ToInt32(Fields[2]),
                    Deptartment = Fields[3],
                    Semester = Convert.ToInt32(Fields[4]),
                    Type = Fields[5],
                    PrerequisiteCourse = Fields[6]


                });
            }

  
            Context.SaveChanges();
            return Ok(Lines);
        }
    }
}
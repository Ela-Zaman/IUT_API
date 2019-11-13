using System;
using System.Collections.Generic;
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
    public class DepartmentController : ControllerBase
    {
        readonly AddDBContext Context;
        public DepartmentController(AddDBContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IActionResult GetRooms()
        {
            var department = Context.Department.ToList();
            return Ok(department);
        }

        [HttpPost]
        public IActionResult ReadCsvfile(IFormFile file)
        {
            List<string> department = new List<string>();
            List<Department> lot = new List<Department>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() > 0)
                {
                    department.Add(reader.ReadLine());
                }
                foreach (string c in department)
                {
                    if (c == null)
                        continue;
                    else
                    {
                        lot.Add(ReadFromCsv(c));

                    }
                }

                Context.Department.AddRange(lot);
                Context.SaveChanges();

                return Ok(lot);
            }



        }

        private Department ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var department = new Department
            {
              
                D_id = Convert.ToInt32(fields[0]),
                DeptName = fields[1]
               
            };

            return department;
        }
    }
}
using System;
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
    public class StaffController : Controller
    {
        readonly AddDBContext Context;
        public StaffController(AddDBContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IActionResult GetRooms()
        {
            var staff = Context.Staff.ToList();
            return Ok(staff);
        }
        [HttpPost]
        public IActionResult ReadCsvfile(IFormFile file)
        {
            List<string> staff = new List<string>();
            List<Staff> top = new List<Staff>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() > 0)
                {
                    staff.Add(reader.ReadLine());
                }
                foreach (string c in staff)
                {
                    if (c == null)
                        continue;
                    else
                    {
                        top.Add(ReadFromCsv(c));

                    }
                }

                Context.Staff.AddRange(top);
                Context.SaveChanges();

                return Ok(top);
            }



        }

        private Staff ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });
            
            
            var staff = new Staff
            {
             
            St_id =Convert.ToInt32( fields[0]),
                StaffId = fields[1],
                Name = fields[2],
                Designation = fields[3],
                MobileNumber = fields[4],
                WorkArea = fields[5],
                Gender = fields[6]
            };

            return staff;
        }
    }
}

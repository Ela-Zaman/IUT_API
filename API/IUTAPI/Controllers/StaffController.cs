using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IUTAPI.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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

        [HttpGet("import")]
        public IActionResult Import()
        {
            // 
            var filepath = "C:\\Projects\\import2.csv";


            var lines = System.IO.File.ReadAllLines(filepath).Where(line => !string.IsNullOrWhiteSpace(line));
            var staffs = lines.Select(line => ReadFromCsv(line));
            Context.Staff.AddRange(staffs);
            Context.SaveChanges();
            return Ok(staffs);
        }

        private Staff ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var staff = new Staff
            {
                StaffId = fields[0],
                Name = fields[1],
                Designation =fields[2],
                MobileNumber = fields[3],
                WorkArea = fields[4],
                Gender = fields[5]
              
            };

            return staff;
        }
    }
}

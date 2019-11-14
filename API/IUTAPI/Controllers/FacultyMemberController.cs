using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IUTAPI.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("DevConsole")]
    [MiddlewareFilter(typeof(AuthorizationMiddlewarePipeline))]
    public class FacultyMemberController : ControllerBase
    {
        readonly AddDBContext Context;
        public FacultyMemberController(AddDBContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IActionResult GetRooms()
        {
            var facultymembers = Context.FacultyMember.ToList();
            return Ok(facultymembers);
        }
    


[HttpPost]
public IActionResult ReadCsvfile(IFormFile file)
{
    List<string> facultymember = new List<string>();
    List<FacultyMember> cat1 = new List<FacultyMember>();
    using (var reader = new StreamReader(file.OpenReadStream()))
    {
        while (reader.Peek() > 0)
        {
            facultymember.Add(reader.ReadLine());
        }
        foreach (string c in facultymember)
        {
            if (c == null)
                continue;
            else
            {
                cat1.Add(ReadFromCsv(c));

            }
        }

        Context.FacultyMember.AddRange(cat1);
        Context.SaveChanges();

        return Ok(cat1);
    }



}

        private FacultyMember ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var facultymember = new FacultyMember
            {



                F_id = Convert.ToInt32(fields[0]),
                EmployeeId = Convert.ToInt32(fields[1]),
                Name = fields[2],
                Department = fields[3],
                MobileNumber = fields[4],
                Designation = fields[5],
                Email = fields[6],
                RoomNumber = fields[7],
                Gender = fields[8]
            };


            return facultymember;

        }


    }

}
    

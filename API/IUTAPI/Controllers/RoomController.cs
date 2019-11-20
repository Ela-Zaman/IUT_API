using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IUTAPI.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {

        readonly ApiDbContext Context;
        public RoomController(ApiDbContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IActionResult GetRooms()
        {
            var room = Context.Room.ToList();
            return Ok(room);
        }

        [HttpPost]
        public IActionResult ReadCsvfile(IFormFile file)
        {
            List<string> room = new List<string>();
            List < Room > dot = new List<Room>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() > 0)
                {
                    room.Add(reader.ReadLine());
                }
                foreach (string c in room)
                {
                    if (c == null)
                        continue;
                    else
                    {
                        dot.Add(ReadFromCsv(c));

                    }
                }

                Context.Room.AddRange(dot);
                Context.SaveChanges();

                return Ok(dot);
            }



        }

        private Room ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var room = new Room
            {
                R_id = Convert.ToInt32(fields[0]),
                RoomId = fields[1],
                RoomNo = Convert.ToInt32(fields[2]),
                level = Convert.ToInt32(fields[3]),
                RoomName = fields[4],
                Building = fields[5],
                RoomType = fields[6]
            };

            return room;
        }
    }
}

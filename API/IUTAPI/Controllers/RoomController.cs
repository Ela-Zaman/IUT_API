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
    public class RoomController : Controller
    {

        readonly AddDBContext Context;
        public RoomController(AddDBContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IActionResult GetRooms()
        {
            var room = Context.Room.ToList();
            return Ok(room);
        }

        [HttpGet("import")]
        public IActionResult Import()
        {
            // 
            var filepath = "C:\\Projects\\import2.csv";


            var lines = System.IO.File.ReadAllLines(filepath).Where(line => !string.IsNullOrWhiteSpace(line));
            var rooms = lines.Select(line => ReadFromCsv(line));
            Context.Room.AddRange(rooms);
            Context.SaveChanges();
            return Ok(rooms);
        }

        private Room ReadFromCsv(string line)
        {
            var fields = line.Split(new char[] { ',' });

            var room = new Room
            {
                RoomId = fields[0],
                RoomNo = Convert.ToInt32(fields[1]),
                RoomName = fields[2],
                Building = fields[3],
                RoomType = fields[4]

            };

            return room;
        }
    }
}

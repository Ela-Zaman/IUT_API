using System.Threading.Tasks;
using IUTAPI.Models;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using IUTAPI.Filters;

namespace IUTAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        readonly AddDBContext Context;
        public studentController(AddDBContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IEnumerable GetRooms()
        {
            return Context.student;
        }
    }
}

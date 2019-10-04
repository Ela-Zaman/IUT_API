using System;
using System.Collections;
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
    public class AssignedCoursesController : Controller
    {
        // GET: api/<controller>
        readonly AddDBContext Context;
        public AssignedCoursesController(AddDBContext context)
            => Context = context;

        [HttpGet]
        [EnableQuery()]
        public IEnumerable Get()
        {
            return Context.CourseAssigned;
        }

    }
}

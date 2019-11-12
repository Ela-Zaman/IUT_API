using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using IUTAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IUTAPI.Controllers
{
  
    [Route("api/[controller]")]
    public class ApIkeyController : Controller
    {
        readonly AddDBContext Context;
        public ApIkeyController(AddDBContext context)
                => Context = context;
        // GET: api/<controller>
        [HttpGet]
        public String Get()
        {
            var cryptoProvider = new RNGCryptoServiceProvider();

            byte[] SecretKeybyteArray = new byte[32];
            cryptoProvider.GetBytes(SecretKeybyteArray);
            var ApiKey = Convert.ToBase64String(SecretKeybyteArray);
            return ApiKey.ToString();

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string username,string useremail,string APIkey)
        {


        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using IUTAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    public class ApiKeyController : Controller
    {
        readonly AddDBContext Context;
        public ApiKeyController(AddDBContext context)
            => Context = context;
        // GET: api/<controller>
        [HttpGet]
        public string Get(string username,string projectname)
        {
            var cryptoProvider = new RNGCryptoServiceProvider();

            byte[] SecretKeybyteArray = new byte[32];
            cryptoProvider.GetBytes(SecretKeybyteArray);
            var ApiKy = Convert.ToBase64String(SecretKeybyteArray);

            var apik=ApiKy.ToString();
            ApiKey apikeys = new ApiKey();
            apikeys.Apikey = apik;
            apikeys.User = username;
            apikeys.ProjectName = projectname;
            
            Context.Apikey.AddRange(apikeys);
            Context.SaveChanges();
            return apik;



        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
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

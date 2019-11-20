using System;
using System.Security.Cryptography;
using IUTAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IUTAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ApiKeyController : Controller
    {
        readonly ApiDbContext Context;
        public ApiKeyController(ApiDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        [AllowAnonymous]
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
            
            Context.ApiKey.AddRange(apikeys);
            Context.SaveChanges();
            return apik;
        }
    }
}

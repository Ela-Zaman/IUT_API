using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using IUTAPI.Filters;
using IUTAPI.Models;

namespace IUTAPI.Filters
{
    public class APIkeyMassageHandlerMiddleware
    {
       
      
        private RequestDelegate next;
        public APIkeyMassageHandlerMiddleware(RequestDelegate next)
        {
            this.next = next;

        }
        public async Task Invoke(HttpContext context)
        {
            bool validKey = false;

            var checkApikeyExists = context.Request.Headers.ContainsKey("APIKey");
            if (checkApikeyExists)
            {
                using (var existapikey = new AddDBContext())
                {
                    bool result = existapikey.ApiKey.Any(x => x.Apikey== context.Request.Headers["APIKey"]);
                    if (result)
                    {
                        validKey = true;

                    }
                }

               
            }
            if (!validKey)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                await context.Response.WriteAsync("Invalid Api key");
            }
            else
            {
                await next.Invoke(context);
            }

        }
    }
}
public class welcomeuser
{


    private RequestDelegate next;
    public welcomeuser(RequestDelegate next)
    {
        this.next = next;

    }
    public async Task Invoke(HttpContext context)
    {
        bool validKey = true;

       


        
        if (!validKey)
        {
            context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            await context.Response.WriteAsync("Invalid Api key");
        }
        else
        {
            await next.Invoke(context);
        }

    }
}

 

public class AuthorizationMiddlewarePipeline
{
    public void Configure(IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseMiddleware<APIkeyMassageHandlerMiddleware>();
    }
}





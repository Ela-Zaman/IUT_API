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
using System.Web.Http.Filters;
using System.Web.Http.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using IUTAPI.Filters;

namespace IUTAPI.Filters
{
    public class APIkeyMassageHandlerMiddleware
    {
        private const string APIKeyToCheck = "iut" ;
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
                if (context.Request.Headers["APIKey"].Equals(APIKeyToCheck))
                {
                    validKey = true;

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
    public static class MyHanlrxtnsions
    {


        public static IApplicationBuilder UseApiKey(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<APIkeyMassageHandlerMiddleware>();
        }
    }





using System.Linq;
using System.Threading.Tasks;
using System.Net;

using Microsoft.AspNetCore.Http;
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

        public async Task Invoke(HttpContext context, ApiDbContext db)
        {
            bool validKey = false;

            var checkApikeyExists = context.Request.Headers.ContainsKey("APIKey");
            if (checkApikeyExists)
            {
                bool result = db.ApiKey.Any(x => x.Apikey == context.Request.Headers["APIKey"]);
                if (result)
                {
                    validKey = true;
                }
            }
            if (!validKey && false)
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

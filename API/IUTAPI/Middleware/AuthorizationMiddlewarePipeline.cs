using Microsoft.AspNetCore.Builder;
using IUTAPI.Filters;

public class AuthorizationMiddlewarePipeline
{
    public void Configure(IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseMiddleware<APIkeyMassageHandlerMiddleware>();
    }
}





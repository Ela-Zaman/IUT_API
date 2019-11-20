using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace IUTAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var urlRoots = args.Length > 0 ? args[0].Split(',') : new []{"http://localhost:5001" };
            
            WebHost.CreateDefaultBuilder(args)
                .UseUrls(urlRoots)
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}

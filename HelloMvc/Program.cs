using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace HelloMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                        .UseServer("Microsoft.AspNetCore.Server.Kestrel")
                        .UseDefaultConfiguration(args)
                        .UseIISPlatformHandlerUrl()
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}
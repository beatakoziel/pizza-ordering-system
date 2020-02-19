using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Slicesy.PizzaOrder.WebApi
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://localhost:2137")
                .Build()
                .Run();
        }
    }
}
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultMVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>  //Default WebServer -> Kestrel
                {
                    webBuilder.UseStartup<Startup>();
                });
        
        // Testdaten f�r EFCore k�nnen hinzugef�gt werden 
        // Welche Implementierung k�nnen hier hinzugef�gt werden -> Logger 
    }
}

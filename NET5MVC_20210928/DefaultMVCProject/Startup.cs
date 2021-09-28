using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultMVCProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //IOC Container -> Inversion of Controll
        {
            //ConfigureService wird verwendet um Dienst/Feature für MVC-Anwendung  hingefügt /freigeschalten. 
            
            services.AddControllersWithViews(); //MVC - Framework -> Verzeichnisse wie: Models, Views und Controllers werden benötigt
            
            services.AddSession(); //Wir fügen Session-Handling hinzu

            //services.AddRazorPages(); //RazorPage Framework  -> Idenetity UI (nur in Razor PAges)  -> Verzeichnis Pages wird benötigt
            //services.AddMvc(); // AddControllersWithViews + AddRazorPages -> Verzechnisse werden benötigt: Models, Views und Controllers, Pages
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();  //Fehlermeldung mit Entwicklerinformationen (Meldung + StackTrace) 
            }
            else
            {
                //Production 
                
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts(); //Sicherheitverbesserung (Aufsatz) zu HTTPS 
            }


            //Allgemeine Definitionen

            app.UseHttpsRedirection(); //https://localhost:5001 
            
            app.UseStaticFiles(); //wwwroot - directory 

            app.UseRouting(); //Routing

            app.UseAuthorization(); //Filter-Klassen 


            //Default-Adresse ->: https://localhost:5001 -> https://localhost:5001/Home/Index
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

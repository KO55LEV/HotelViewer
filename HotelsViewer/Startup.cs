using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsViewer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelsViewer
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //add EF support
            services.AddDbContext<HotelsViewerDbContext>(
                cfg => cfg.UseSqlServer(_config.GetConnectionString("SqlConnection"))
                );

            //to start MVC we need to do dependency injection 
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //turns on developers Exception page 
                app.UseDeveloperExceptionPage();
            }

            //Uncomment this is you want to use static files ! 
            //app.UseStaticFiles();
            //app.UseDefaultFiles();

            //adds MVC to the project, configuring with router
            app.UseMvc(cfg =>
                {
                    cfg.MapRoute("Default", "/{controller}/{action}/{id?}", new { controller = "App", action = "Index" });
                    //cfg.MapRoute("Foo", "users/manage", new {controller = "UserManagment", action = "Index"});
                }
            );

        }
    }
}

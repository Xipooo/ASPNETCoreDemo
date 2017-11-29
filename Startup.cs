using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ASPNETCoreDemo.Database;

namespace ASPNETCoreDemo
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(o =>
            {
                o.RespectBrowserAcceptHeader = true;
                o.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            });

            services.AddDbContext<DemoContext>(options => 
                options.UseSqlServer(
                    @"Server=localhost\SQLEXPRESS;Database=ASPCoreDemo;Trusted_Connection=True;")
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            loggerFactory.AddFile("Logs/ASPCoreDemo-{Date}.txt");
            loggerFactory.AddConsole();

            app.UseStaticFiles();
            app.UseMvc(
                o =>
                {
                    o.MapRoute("Default", "{controller=Home}/{action=Index}/{Id?}");
                }
            );
        }
    }
}

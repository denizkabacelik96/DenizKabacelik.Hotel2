using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenizKabacelik.Hotel2.Business.Abstract;
using DenizKabacelik.Hotel2.Business.Concrete;
using DenizKabacelik.Hotel2.DataAccess.Abstract;
using DenizKabacelik.Hotel2.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IHotelService, HotelManager>();
            services.AddSingleton<IHotelRepository, HotelRepositoty>();
            services.AddSwaggerDocument(config=> {

                config.PostProcess = (doc =>
                {

                    doc.Info.Title = "WebApi Projesi ";
                    
                });
            } );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

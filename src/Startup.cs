using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackOfficeLU.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BackOfficeLU
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddTransient<IClaseRepository, ClaseRepository>();
            services.AddTransient<IResponsableRepository, ResponsableRepository>();
            services.AddTransient<IEdicionRepository, EdicionRepository>();
            services.AddTransient<ILocacionRepository, LocacionRepository>();
            services.AddTransient<IPostulanteRepository, PostulanteRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.EnvironmentName == "dev")
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseFileServer();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

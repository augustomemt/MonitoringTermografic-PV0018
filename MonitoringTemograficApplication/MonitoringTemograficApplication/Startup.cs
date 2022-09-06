using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MonitoringTemograficApplication.Database;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Libraries.Session;
using MonitoringTemograficApplication.Repositories;
using MonitoringTemograficApplication.Repositories.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication
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
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();

            /*
             * Session - Configuração
             */
            services.AddMemoryCache(); //Guardar os dados na memória
            services.AddSession(options => {

            });
            services.AddScoped<Session>();
            services.AddScoped<LogingClient>();
            services.AddScoped<IProcessor, ProcessorRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            string connection = "Server=VM-MEMT-14\\CSPNIVEL02;Database=EXT;user id=sa;password=metrum2002*;Trusted_Connection=False;";
            services.AddDbContext<MonitoringTermograficContext>(options => options.UseSqlServer(connection));
            

    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Termografic}/{action=Login}/{id?}");
            });
        }
    }
}

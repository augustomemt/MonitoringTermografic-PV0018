using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MonitoringTemograficApplication.Database;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Libraries.Session;
using MonitoringTemograficApplication.Repositories;
using MonitoringTemograficApplication.Repositories.Contracts;
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
      services.AddSession(options =>
      {

      });
      services.AddScoped<Session>();
      services.AddScoped<LogingClient>();
      services.AddScoped<IProcessor, ProcessorRepository>();
      services.AddScoped<IUserRepository, UserRepository>();

      string connection = "Server=172.16.9.133\\ION;Database=EXT;user id=sa;password=ION!Everywhere;Trusted_Connection=False;";
      services.AddDbContext<MonitoringTermograficContext>(options => options.UseSqlServer(connection));
      //services.AddDbContext<LadleCheckContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LadleCheck3")));
      services.AddEntityFrameworkSqlServer().AddDbContext<MeasurementsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SIMT")));
      //services.AddEntityFrameworkSqlServer().AddDbContext<LadleCheckContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LadleCheck3")));



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

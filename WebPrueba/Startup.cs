using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Data;

namespace WebPrueba
{
    public class Startup
    {
  

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            #region Tipo de DB Provider a usar
            try
            {
                _dbInMemory = Configuration.GetValue<bool>("DbInMem");
            }
            catch
            {
                //Dejamos el tratamiento que le queremos dar. En este caso asumimons que si falla la lectura 
                _dbInMemory = true;
            }
            #endregion
        }

        public IConfiguration Configuration { get; }
        public bool _dbInMemory = false;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ForoContext>(options =>
            //    options.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=ForoDB-Videos;Trusted_Connection=true;")
            //);

            services.AddDbContext<ForoContext>(options =>
                options.UseInMemoryDatabase("ForoDb")
            );

            services.AddControllersWithViews();

            #region Tipo de DB provider a usar
            if (_dbInMemory)
            {
                services.AddDbContext<ForoContext>(options => options.UseInMemoryDatabase("ForoDb"));
            }
            else
            {
                services.AddDbContext<ForoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ForoCS"))
                );
            }
            #endregion

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ForoContext foroContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //DComtemplar que las migraciones de EF esten siewmpre cargadas, pero cuando son aplicables
            if (!_dbInMemory)
            {
                foroContext.Database.Migrate();

            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

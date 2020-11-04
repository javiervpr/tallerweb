using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tienda.Distribucion.Domain.Persistence.Reporsitory;
using Tienda.Distribucion.Infraestructura.Persistence;
using Tienda.Distribucion.Infraestructura.Repository;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.Soporte.Infraestructura.Persistence;
using Tienda.Soporte.Infraestructura.Persistence.Repository;

namespace Tienda.WebApp
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

            services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(
                   Configuration.GetConnectionString("DBConnectionString"),
                   b => b.MigrationsAssembly("Tienda.WebApp")));

            services.AddDbContext<SoporteDomainDBContext>(options =>
                   options.UseSqlServer(
                   Configuration.GetConnectionString("DBSoporteConnectionString"),
                   b => b.MigrationsAssembly("Tienda.WebApp")));

            services.AddScoped<Tienda.Distribucion.Domain.Persistence.IUnitOfWork, UnitOfWork>();
            services.AddScoped<IOrdenEntregaRepository, OrdenEntregaRepository>();

            services.AddScoped<Tienda.Soporte.Domain.Persistence.IUnitOfWork, UnitOfWorkSoporte>();
            services.AddScoped<IOrdenServicioRepository, OrdenServicioRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<ITecnicoRepository, TecnicoRepository>();
            services.AddScoped<ICitaRepository, CitaRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

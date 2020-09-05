using GenericReport.ApplicationContex;
using GenericReport.Service.Clientes;
using GenericReport.Service.ConnectionString;
using GenericReport.Service.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentExpress.ApplicationContex;
using RentExpress.Profiles;
using RentExpress.Service;

namespace RentExpress.Installers
{
    public class DataInstaller :IInstaller

    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContex>(option =>
            option.UseNpgsql(configuration.GetConnectionString("PostgreConnection")));

            services.AddDbContext<SqlDbContext>(op =>
            op.UseSqlServer(configuration.GetConnectionString("SqlConnection")));



            // Auto Mapper
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new GeneralProfile());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            // Services

            services.AddTransient<IFacturasServices, FacturaServices>();
            services.AddTransient<IUsuarioServices, UsuarioServices>();
            services.AddTransient<IConnectionstringServices,ConnectionstringServices>();
            services.AddTransient<IClientesServices,ClientesServices>();


        }
    }
}

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
            option.UseNpgsql(configuration.GetConnectionString("DevConnection")));


            // Auto Mapper
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new GeneralProfile());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            // Services

            services.AddTransient<IFacturasServices, FacturaServices>();
        }
    }
}

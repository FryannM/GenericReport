using System.Linq;
using GenericReport.ApplicationContex;
using GenericReport.Service.Clientes;
using GenericReport.Service.Company;
using GenericReport.Service.ConnectionString;
using GenericReport.Service.User;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modelo.Abstracts;
using RentExpress.ApplicationContex;
using RentExpress.Profiles;
using RentExpress.Service;

namespace RentExpress.Installers
{
    public class DataInstaller :IInstaller

    {
        public IConfiguration Configuration { get; }
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<ApplicationDbContex>(option =>
            //option.UseNpgsql(configuration.GetConnectionString("PostgreConnection")));
            
            //    services.AddDbContext<ApplicationDbContex>(option =>
            //option.UseNpgsql(Channel.Connection));//configuration.GetConnectionString(Channel.Connection)));



            services.AddDbContext<ApplicationDbContex>((serviceProvider, dbContextBuilder) =>
            {
                var connectionStringPlaceHolder = Channel.Connection;
             //   var httpContextAccessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();
                var dbName = "User Id=postgres; Password=Artesania99;Server=104.248.59.55;Port=5432; Database=medvelSRL; Pooling=true;";    //    httpContextAccessor.HttpContext.Request.Headers["tenantId"].First();
                var connectionString = connectionStringPlaceHolder.Replace("{dbName}", dbName);
                dbContextBuilder.UseNpgsql(connectionString);
            });



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
            services.AddTransient<ICompanyServices, CompanyServices>();
        }
    }
}

﻿using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RentExpress.Installers
{
    public static class InstallerExtention
    {
       
            public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
            {
                var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
                    typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();

                installers.ForEach(installer => installer.InstallServices(services, configuration));
            }
    }
}

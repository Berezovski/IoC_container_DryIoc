using DryIoc;
using Microsoft.Extensions.Configuration;
using System;

namespace DI.DryIoc
{
    public static class CompositionRoot
    {
        public static void AddModules(this IContainer container)
        {
            var configuration = container.Resolve<IConfiguration>();

            // add list of modules from appsettings 
            container.AddModules(configuration.GetSection("Modules"));

        }
    }
}

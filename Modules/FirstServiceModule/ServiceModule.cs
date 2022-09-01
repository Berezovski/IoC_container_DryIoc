using DI.DryIocModules;
using DryIoc;
using FirstService;
using MainService;
using Microsoft.Extensions.Configuration;
using System;

namespace FirstServiceModule
{
    public class ServiceModule : IModule
    {
        public string Name { get; set; } = nameof(ServiceModule) ;
        public string AssemblyName { get; set; }
        public bool Enabled { get; set; }

        public void RegisterTypes(IContainer container)
        {
            var configuration = container.Resolve<IConfiguration>(IfUnresolved.ReturnDefault);

            //if (configuration != default)
            //{
            //    var settings = Settings.FromConfiguration(configuration);
            //    container.RegisterInstance(settings);
            //}

            //container.Register<IMainService, FirstServ>(Reuse.Singleton, serviceKey : "1");
            container.Register<IMainService, FirstServ>(Reuse.Singleton);
        }
    }
}

using DI.DryIocModules;
using DryIoc;
using MainService;
using Microsoft.Extensions.Configuration;
using SecondService;
using System;

namespace SecondServiceModule
{
    public class ServiceModule : IModule
    {
        public string Name { get; set; } = nameof(ServiceModule);
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

            container.Register<IMainService, SecondServ>(Reuse.Singleton);
        }
    }
}

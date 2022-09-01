using DI.DryIoc;
using DryIoc;
using FirstService;
using MainService;
using Microsoft.Extensions.Configuration;
using SecondService;
using System;
using System.IO;

namespace IoCWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            IContainer cont = new Container();
            var config = BuildConfiguration();

            cont.RegisterInstance(config);
            cont.AddModules();
            var serv = cont.Resolve<IMainService>();
            serv.UseService();

            Console.WriteLine("End");
        }

        public static IConfiguration BuildConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Environment.CurrentDirectory, "JsonSettings"))
                .AddJsonFile("appsettings.json");

            return configuration.Build();
        }
    }
}

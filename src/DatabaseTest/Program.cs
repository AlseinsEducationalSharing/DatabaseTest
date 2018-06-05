using MongoDB.Driver;
using Alsein.Utilities;
using System.Linq;
using Autofac;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MongoClient>()
                .AsImplementedInterfaces()
                .UsingConstructor(typeof(string))
                .WithParameter("connectionString", "mongodb://debug:dbg13579@ovyno.com/")
                .SingleInstance();

            builder.RegisterAssemblyTypes(AssemblyManager.AllModuleAssemblies.ToArray())
                .Where(t => t.Name.EndsWith("Service"))
                .AsSelf()
                .AsImplementedInterfaces()
                .PreserveExistingDefaults()
                .SingleInstance()
                .PropertiesAutowired();

            builder.Build().Resolve<IMainService>().Main(args);

        }
    }
}

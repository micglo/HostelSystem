using System.Web.Http;
using HostelSystem.Service.CustomException;
using HostelSystem.Service.ModelFactory;
using HostelSystem.Service.Service;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace HostelSystem.Web.Api.Utility
{
    public class SimpleInjectorConfigurator
    {
        public static void Configure(HttpConfiguration config)
        {
            var container = new Container();

            ConfigureContainer(container);

            container.RegisterWebApiControllers(config);

            container.Verify();

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void ConfigureContainer(Container container)
        {
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.Register(() => new Dal.HostelSystemDbContext(), Lifestyle.Scoped);

            ConfigureServices(container);
        }

        private static void ConfigureServices(Container container)
        {
            container.Register<IRezerwacjaService, RezerwacjaService>(Lifestyle.Scoped);
            container.Register<IRezerwacjaFactory, RezerwacjaFactory>(Lifestyle.Scoped);
            container.Register<ICustomException, CustomException>(Lifestyle.Scoped);
        }
    }
}
using System.Web.Http;
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
            
        }
    }
}
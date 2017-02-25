using System.Web.Http;
using HostelSystem.Web.Api.Utility;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HostelSystem.Web.Api.Startup))]
namespace HostelSystem.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfigurator.Configure(config);
            SimpleInjectorConfigurator.Configure(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }
    }
}
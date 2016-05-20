using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpineX.WebClient.Startup))]
namespace SpineX.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

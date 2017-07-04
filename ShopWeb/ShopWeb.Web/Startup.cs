using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopWeb.Web.Startup))]
namespace ShopWeb.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MFStores.WebUI.Startup))]
namespace MFStores.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

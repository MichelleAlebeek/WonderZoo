using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WonderZoo.Startup))]
namespace WonderZoo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

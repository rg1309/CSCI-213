using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RV.Startup))]
namespace RV
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

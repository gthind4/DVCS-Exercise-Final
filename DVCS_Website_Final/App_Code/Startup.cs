using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVCS_Website_Final.Startup))]
namespace DVCS_Website_Final
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

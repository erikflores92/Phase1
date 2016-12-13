using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phase1.Startup))]
namespace Phase1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

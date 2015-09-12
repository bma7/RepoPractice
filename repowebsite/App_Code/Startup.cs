using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(repowebsite.Startup))]
namespace repowebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

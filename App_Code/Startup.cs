using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Note20220228.Startup))]
namespace Note20220228
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

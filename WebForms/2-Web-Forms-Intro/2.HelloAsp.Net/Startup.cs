using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2.HelloAsp.Net.Startup))]
namespace _2.HelloAsp.Net
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

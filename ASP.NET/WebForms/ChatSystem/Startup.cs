using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatSystem.Startup))]
namespace ChatSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

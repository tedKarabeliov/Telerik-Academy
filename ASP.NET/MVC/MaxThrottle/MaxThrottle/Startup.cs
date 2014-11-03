using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaxThrottle.Startup))]
namespace MaxThrottle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

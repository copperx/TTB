using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTB.Startup))]
namespace TTB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

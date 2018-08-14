using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Investomania.Startup))]
namespace Investomania
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

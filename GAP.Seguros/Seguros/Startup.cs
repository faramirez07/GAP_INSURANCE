using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seguros.Startup))]
namespace Seguros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

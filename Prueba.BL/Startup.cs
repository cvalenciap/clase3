using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba.BL.Startup))]
namespace Prueba.BL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

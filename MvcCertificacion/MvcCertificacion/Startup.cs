using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCertificacion.Startup))]
namespace MvcCertificacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

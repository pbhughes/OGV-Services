using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OGV.Services.Startup))]
namespace OGV.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

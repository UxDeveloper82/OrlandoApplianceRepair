using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplianceRepair.Startup))]
namespace ApplianceRepair
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

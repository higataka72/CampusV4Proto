using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CampusV4.Startup))]
namespace CampusV4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

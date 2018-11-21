using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dmquyettien.Startup))]
namespace dmquyettien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuddyCardWeb.Startup))]
namespace BuddyCardWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

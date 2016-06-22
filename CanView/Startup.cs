using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanView.Startup))]
namespace CanView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

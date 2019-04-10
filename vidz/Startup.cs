using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidz.Startup))]
namespace vidz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

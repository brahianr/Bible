using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bible.Backend.Startup))]
namespace Bible.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

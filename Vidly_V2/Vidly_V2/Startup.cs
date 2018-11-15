using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_V2.Startup))]
namespace Vidly_V2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

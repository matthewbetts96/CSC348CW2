using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppsCW2.Startup))]
namespace WebAppsCW2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

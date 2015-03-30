using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pairme.Startup))]
namespace Pairme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

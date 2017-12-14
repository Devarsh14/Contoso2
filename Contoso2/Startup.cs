using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contoso2.Startup))]
namespace Contoso2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

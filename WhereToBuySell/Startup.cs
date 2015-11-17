using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhereToBuySell.Startup))]
namespace WhereToBuySell
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

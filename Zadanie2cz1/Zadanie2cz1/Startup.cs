using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zadanie2cz1.Startup))]
namespace Zadanie2cz1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

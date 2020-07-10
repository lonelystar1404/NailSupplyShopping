using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NailSupplyShopping.Startup))]
namespace NailSupplyShopping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSisEvento.Startup))]
namespace WebAppSisEvento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

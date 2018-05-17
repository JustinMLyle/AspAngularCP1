using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspAngularCP1.Startup))]
namespace AspAngularCP1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

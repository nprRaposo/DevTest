using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevTest.Web.Startup))]
namespace DevTest.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

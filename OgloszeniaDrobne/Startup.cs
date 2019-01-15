using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OgloszeniaDrobne.Startup))]
namespace OgloszeniaDrobne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

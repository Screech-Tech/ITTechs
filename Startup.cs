using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITTechs.Startup))]
namespace ITTechs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FantasyNBA.Startup))]
namespace FantasyNBA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

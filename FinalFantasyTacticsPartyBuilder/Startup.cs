using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalFantasyTacticsPartyBuilder.Startup))]
namespace FinalFantasyTacticsPartyBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

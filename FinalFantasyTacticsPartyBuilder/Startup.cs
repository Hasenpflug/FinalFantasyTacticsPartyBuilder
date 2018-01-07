using Microsoft.Owin;
using Owin;
using System.Data.Entity.Migrations;

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

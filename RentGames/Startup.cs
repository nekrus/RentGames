using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentGames.Startup))]
namespace RentGames
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

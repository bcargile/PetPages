using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetPages.Startup))]
namespace PetPages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

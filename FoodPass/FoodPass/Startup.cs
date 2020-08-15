using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodPass.Startup))]
namespace FoodPass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

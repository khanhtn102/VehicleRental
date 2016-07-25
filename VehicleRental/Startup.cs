using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleRental.Startup))]
namespace VehicleRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TSBusiness.Startup))]
namespace TSBusiness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
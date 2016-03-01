using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PddEvent.Startup))]
namespace PddEvent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

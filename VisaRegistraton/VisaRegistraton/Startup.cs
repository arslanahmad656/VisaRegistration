using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisaRegistraton.Startup))]
namespace VisaRegistraton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendimDeneme.Startup))]
namespace KendimDeneme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

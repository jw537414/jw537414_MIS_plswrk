using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jw537414_MIS_plswrk.Startup))]
namespace jw537414_MIS_plswrk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

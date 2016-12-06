using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamProject2_Part2.Startup))]
namespace TeamProject2_Part2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

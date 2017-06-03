using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkPlanner.Startup))]
namespace WorkPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

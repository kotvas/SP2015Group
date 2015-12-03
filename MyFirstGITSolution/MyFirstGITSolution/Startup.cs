using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstGITSolution.Startup))]
namespace MyFirstGITSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

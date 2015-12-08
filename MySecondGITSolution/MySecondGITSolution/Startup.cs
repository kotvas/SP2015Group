using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySecondGITSolution.Startup))]
namespace MySecondGITSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

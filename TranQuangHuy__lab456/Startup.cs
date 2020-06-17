using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranQuangHuy__lab456.Startup))]
namespace TranQuangHuy__lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

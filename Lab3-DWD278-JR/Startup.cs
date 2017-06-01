using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_DWD278_JR.Startup))]
namespace Lab3_DWD278_JR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

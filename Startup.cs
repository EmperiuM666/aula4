using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aula4.Startup))]
namespace aula4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

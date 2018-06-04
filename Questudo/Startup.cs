using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Questudo.Startup))]
namespace Questudo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlePatrimonio.Startup))]
namespace ControlePatrimonio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

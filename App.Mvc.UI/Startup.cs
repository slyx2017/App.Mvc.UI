using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App.Mvc.UI.Startup))]
namespace App.Mvc.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

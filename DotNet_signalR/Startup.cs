using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNet_signalR.Startup))]
namespace DotNet_signalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRProgressBarSimpleExample.Startup))]
namespace SignalRProgressBarSimpleExample
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

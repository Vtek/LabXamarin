using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LabXamarin.Server.Startup))]
namespace LabXamarin.Server
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.MapSignalR();
		}
	}
}


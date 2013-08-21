
using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.Logging.Support.Logging;
using ServiceStack.Common.Web;

namespace FullStackDG
{
	public class FullStackDGAppHost:AppHostBase
	{
		public FullStackDGAppHost() : base("FullStackDG Web Services",  typeof(FullStackDG.FullStackDGAppHost).Assembly) { }
		
		public override void Configure(Funq.Container container)
		{
			ServiceStack.Logging.LogManager.LogFactory = new ConsoleLogFactory();
			
			SetConfig(new EndpointHostConfig {
				DefaultContentType = ContentType.Json 
			});
		}
	}

	public class Global : System.Web.HttpApplication
	{
		
		protected virtual void Application_Start (Object sender, EventArgs e)
		{
			new FullStackDGAppHost().Init();
		}
		
		protected virtual void Session_Start (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_BeginRequest (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_EndRequest (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_AuthenticateRequest (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_Error (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Session_End (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_End (Object sender, EventArgs e)
		{
		}
	}
}


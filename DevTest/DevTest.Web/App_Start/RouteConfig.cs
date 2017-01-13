using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DevTest.Web
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default",
			"{controller}/{action}/{id}",
			new { controller = "Campaigns", action = "Index", id = UrlParameter.Optional }
					).DataTokens.Add("area", "Campaigns");
		}


	}
}

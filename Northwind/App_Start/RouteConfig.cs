﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Northwind
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
			
			routes.MapRoute(
                name: "banana",
                url: "{controller}/{action}/{name}/{age}/{color}",
                defaults: new { controller = "Free", action = "Bird", name = UrlParameter.Optional, age = UrlParameter.Optional, color = UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "freebird",
                url: "{controller}/{action}/{id}/{name}"
            );
        }
    }
}

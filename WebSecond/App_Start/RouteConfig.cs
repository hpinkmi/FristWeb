using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebSecond
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "default", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Assignment",
                url: "{controller}/{action}",
                defaults: new { controller = "stuff", action = "assign" }
                );
        }
    }
}

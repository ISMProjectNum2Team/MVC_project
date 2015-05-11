using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "Events",
                url: "Events",
                defaults: new { controller = "Events", action = "Index" }
            );
            routes.MapRoute(
                name: "AddEvent",
                url: "Events/AddEvent",
                defaults: new { controller = "Events", action = "AddEvent" }
            );
            routes.MapRoute(
                name: "Details",
                url: "{controller}/Details/{id}",
                defaults: new { conroller = "Events", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Error.NotFound",
               url: "not-found",
               defaults: new { controller = "Error", action = "NotFound" }
           );
            routes.MapRoute(
                name: "Error-404",
                url: "{*url}",
                defaults: new { controller = "Error", action = "NotFound"}
            );
        }
    }
}
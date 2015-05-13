using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestMVC
{
    public static class RouteCollectionExtensions
    {
        public static Route MapRouteWithName(this RouteCollection routes,
            string name, string url, object defaults)
        {
            Route route = routes.MapRoute(name, url, defaults);
            route.DataTokens = new RouteValueDictionary();
            route.DataTokens.Add("RouteName", name);

            return route;
        }
    }

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRouteWithName(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRouteWithName(
                name: "Events",
                url: "Events",
                defaults: new { controller = "Events", action = "Index" }
            );
            routes.MapRouteWithName(
                name: "AddEvent",
                url: "Events/AddEvent",
                defaults: new { controller = "Events", action = "AddEvent" }
            );
            routes.MapRouteWithName(
                name: "Details",
                url: "{controller}/Details/{id}",
                defaults: new { conroller = "Events", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRouteWithName(
               name: "Error.NotFound",
               url: "not-found",
               defaults: new { controller = "Error", action = "NotFound" }
           );
            routes.MapRouteWithName(
                name: "Error-404",
                url: "{*url}",
                defaults: new { controller = "Error", action = "NotFound"}
            );
        }
    }
}
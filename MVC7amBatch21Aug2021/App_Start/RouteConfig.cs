using MVC7amBatch21Aug2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC7amBatch21Aug2021
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.IgnoreRoute("new/index");

            routes.MapMvcAttributeRoutes();

            routes.Add(new Route("test", new customRouteHandler()));
            routes.MapRoute(
               name: "Default123",
               url: "CountryClub/Music",
               defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
             name: "Default1253",
             url: "amrita/office/{id}",
             defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional },
             constraints:new {id=@"\d+"}
         );

            routes.MapRoute(
           name: "Default1254",
           url: "amrita/office2/{id}",
           defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional },
           constraints: new { id = @"[a-zA-Z]+" }
       );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Forest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ArtistRecordingsInGenre",
                url: "{controller}/{action}/{category}/{artist}",
                defaults: new { controller = "Music", action = "Categories", category = UrlParameter.Optional, artist = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Category",
                url: "{controller}/{action}/{category}",
                defaults: new { controller = "Music", action = "Categories", category = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Music", action = "Categories", id = UrlParameter.Optional }
            );

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookMyShow
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            ////Cutom routeManual
            //routes.MapRoute(
            //        name: "MoviesByReleaseDate",
            //        url:"movies/released/{year}/{month}",
            //        defaults: new {controller ="Movies", action="ByReleaseDate"},
            //        constraints: new {year = @"2021|2022", month = @"\d{2}"}
            //    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

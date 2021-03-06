﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AzureSQLDatabaseAndService
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //Can we Push in INdividial Commits#1
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } /* Local Comment#1 */ /* Remote Comment#2 */
                 /*The remote routing comment is here*/
                /*The local routing comment is here*/

            );
        }
    }
}

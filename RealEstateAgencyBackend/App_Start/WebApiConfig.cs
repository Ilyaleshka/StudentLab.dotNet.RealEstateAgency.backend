﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RealEstateAgencyBackend
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			// Web API configuration and services
			//var corsAttribute = new EnableCorsAttribute("*", "*", "*")
			var corsAttribute = new EnableCorsAttribute("http://localhost:3000", "*", "*")
			{
				SupportsCredentials = true
			};

			config.EnableCors(corsAttribute);
			
															 // Web API routes
			config.MapHttpAttributeRoutes();


            /*
            config.RouteExistingFiles = true;
            config.MapRoute(
                name: "staticFileRoute",
                url: "api/images/{*file}",
                defaults: new { controller = "Image", action = "Get" }
            );
            */

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.
        }
    }
}

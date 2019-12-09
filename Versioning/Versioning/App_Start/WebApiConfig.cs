using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Versioning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "version1",
                routeTemplate: "api/v1/students/{id}",
                defaults: new { id = RouteParameter.Optional,Controller="Studentv1" }
            );
            config.Routes.MapHttpRoute(
              name: "version2",
              routeTemplate: "api/v2/students/{id}",
              defaults: new { id = RouteParameter.Optional, Controller = "Studentv2" }
          );
        }
    }
}

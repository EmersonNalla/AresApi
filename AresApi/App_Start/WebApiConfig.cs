using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using AresApi.ActionFilters;
using Swashbuckle.Application;

namespace AresApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new LoggingFilterAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();

            //var cors = new EnableCorsAttribute("www.example.com", "*", "*");
            //config.EnableCors(cors);
            config.EnableCors();

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.EnableSystemDiagnosticsTracing();
        }
    }
}

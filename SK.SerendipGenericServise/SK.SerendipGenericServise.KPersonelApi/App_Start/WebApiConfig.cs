﻿using System.Web.Http;

namespace SK.SerendipGenericServise.KPersonelApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        { 
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new {
                    id = RouteParameter.Optional
                }
            );
        }
    }
}
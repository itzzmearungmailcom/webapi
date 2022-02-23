using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using TestConstrains;
using webapi20220212.Handler;

namespace webapi20220212
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MessageHandlers.Add(new DelegateHandler());
            //config.MapHttpAttributeRoutes();

            var validateAccount = new DefaultInlineConstraintResolver();
            validateAccount.ConstraintMap.Add("validateAccounts", typeof(AccountValidateContrains));
            config.MapHttpAttributeRoutes(validateAccount);

            //config.Routes.MapHttpRoute(
            //    name: "ProdApi",
            //    routeTemplate: "prod/{id}",
            //    defaults: new {controller="Product", id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}

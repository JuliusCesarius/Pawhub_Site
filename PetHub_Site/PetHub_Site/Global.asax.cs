using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PetHub_Site.Models.Helpers;

namespace PetHub_Site
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("demo/{*pathInfo}");
            routes.IgnoreRoute("presentacion/{*pathInfo}");
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
            routes.MapRoute(
                 "Reports",
                 "LAF/Reports/{id}",
                 new { controller = "LostAndFound", action = "Get_ById", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                "ReportsCategories",
                "LAF/Reports/{category}",
                new { controller = "LostAndFound", action = "Get_ByCategoria", category = "" }
            );
            routes.MapRoute(
                "ReportsCategoryAndId",
                "LAF/Reports/{category}/{id}",
                new { controller = "LostAndFound", action = "Get_ByCategoria_ById", category = "", id = UrlParameter.Optional }
            );


        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            AutoMapperBootStrapperHelper.Bootstrap();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
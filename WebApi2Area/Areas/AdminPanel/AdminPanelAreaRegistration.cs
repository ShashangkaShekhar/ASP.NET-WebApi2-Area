using System.Web.Http;
using System.Web.Mvc;

namespace WebApi2Area.Areas.AdminPanel
{
    public class AdminPanelAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AdminPanel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //****************=======Default Api Route=========*******************

            context.Routes.MapHttpRoute(
                name: "AdminPanelApiAction",
                routeTemplate: "AdminPanel/api/{controller}/{action}",
                defaults: new { id = UrlParameter.Optional }
            );

            context.Routes.MapHttpRoute(
                name: "AdminPanelApi",
                routeTemplate: "AdminPanel/api/{controller}"
            );

            //****************=======Default Route=========*******************
            context.MapRoute(
                "AdminPanel_dashboard",
                "AdminPanel/{controller}/{action}/{id}",
                new { Controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "AdminPanel_default",
                "AdminPanel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
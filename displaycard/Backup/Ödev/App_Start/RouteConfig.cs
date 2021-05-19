using System.Web.Mvc;
using System.Web.Routing;

namespace Ödev
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{order}",
                defaults: new { controller = "Home", action = "Index", order = UrlParameter.Optional }
            );
        }
    }
}

using System.Web.Mvc;

namespace WebApplication1.Areas.Collab
{
    public class CollabAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Collab";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            //context.MapRoute(
            //    "Add_Item",
            //    "Collab/{action}/{name}",
            //    new { controller = "Items", action = "Index", id = UrlParameter.Optional }
            //);

            //context.MapRoute(
            //    "Shop",
            //    "Shop/{action}/{name}",
            //    new {controller = "Shop", action = "Index", name = UrlParameter.Optional},
            //    new[] {"e-Shop.Controllers"}
            //);

            context.MapRoute(
                "Collab_default",
                "Collab/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
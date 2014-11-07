using System.Web.Mvc;

namespace MaxThrottle.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdministrationIndex",
                "Administration/{controller}/{page}",
                new { action = "Index", page = UrlParameter.Optional },
                new { page = @"\d+" }
            );

            context.MapRoute(
                "Administration_default",
                "Administration/{controller}/{action}/{id}",
                new { controller = "Administration", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
using System.Web.Mvc;

namespace SmartPortal.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "System", action = "Index", id = UrlParameter.Optional },
                new string[] { "SmartPortal.Areas.Admin.Controllers" }
            );
        }
    }
}

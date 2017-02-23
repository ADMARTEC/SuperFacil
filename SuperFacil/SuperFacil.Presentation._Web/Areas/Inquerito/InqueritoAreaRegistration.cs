using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Inquerito
{
    public class InqueritoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Inquerito";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Inquerito_default",
                "Inquerito/{controller}/{action}/{id}",
                new { Controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "SuperFacil.Presentation._Web.Areas.Inquerito.Controllers" }
            );
        }
    }
}
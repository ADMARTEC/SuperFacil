using System.Web.Mvc;

namespace SuperFacil.UI._Web.Areas.Gesmidia
{
    public class GesmidiaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Gesmidia";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Gesmidia_default",
                "Gesmidia/{controller}/{action}/{id}",
                new { Controller="Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "SuperFacil.UI._Web.Areas.Gesmidia.Controllers"}
            );
        }
    }
}
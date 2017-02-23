using SuperFacil.Presentation._Web.Controllers;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Inquerito.Controllers
{
    public class HomeController : Base_InqueritoController
    {
        // GET: Inquerito/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Analise()
        {
            return View();
        }
    }
}
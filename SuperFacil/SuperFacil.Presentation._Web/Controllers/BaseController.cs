using SuperFacil.Application.Interface.Sistema.Generico;
using SuperFacil.Infraestructure.IoC;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Controllers
{
    public class BaseController : Controller
    {       
        internal readonly ISis_Gen_Pais_AppService _PaisAppService;

        public BaseController()
        {
            var container = IoC.Start();
                       
            _PaisAppService = container.GetService<ISis_Gen_Pais_AppService>();
        }
        

        internal async Task GetProvincia_dropdown()
        {
            ViewBag.Provincia = new SelectList((await _PaisAppService.GetAll()).Where(x => x.Provincia_ID == 1 & x.Municipio_ID == null & !x.Deleted)
                                                                                 .Select(x => new { x.Pais_ID, x.Designacao })
                                                                                 .OrderBy(x => x.Designacao).ToList(), "Pais_ID", "Designacao");
        }

    }
}
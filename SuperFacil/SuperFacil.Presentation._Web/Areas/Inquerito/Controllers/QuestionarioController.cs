using AutoMapper;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Application.Interface.Sistema.Generico;
using SuperFacil.Presentation._Web.Areas.Inquerito.Controllers;
using SuperFacil.Presentation._Web.Areas.Inquerito.ViewModel;
using SuperFacil.Presentation._Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Inquerito.Controllers
{
    public class QuestionarioController : Base_InqueritoController
    {

        public QuestionarioController()
        {
        }

        
        [HttpGet]
        public async Task<JsonResult> Get_Lista_Municipio(int? _value)
        {
            var result = (await _PaisAppService.GetAll()).Where(x => x.Municipio_ID == _value)
                                               .OrderBy(x => x.Designacao)
                                               .ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // GET: Inquerito/Questionario/Create
        public async Task<ActionResult> Create()
        {
            //var test = new Inq_Questionario_ViewModel();
            //var result = Mapper.Map<IEnumerable<Inq_Inquerito_ViewModel>>(await _InqueritoAppService.GetAll());

            //test.Inquerito = result.FirstOrDefault();

         

            //ViewBag.Inquerito = result?.Designacao;

            await GetProvincia_dropdown();

            return View();
        }

        // POST: Inquerito/Questionario/Create
        [HttpPost]
        public ActionResult Create(Inq_Questionario_ViewModel _Questionario)
        {
            try
            {
                _Questionario = _Questionario.Create(_Questionario);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

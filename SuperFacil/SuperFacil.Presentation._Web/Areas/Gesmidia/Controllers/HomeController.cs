using AutoMapper;
using PagedList;
using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels;
using SuperFacil.Presentation._Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Gesmidia.Controllers
{
    public class HomeController : BaseController
    {
        internal readonly IMul_Autor_AppService _autorapp;

        public HomeController(IMul_Autor_AppService autorapp)
        {
            _autorapp = autorapp;
        }

        // GET: Gesmidia/Home
        public async Task<ActionResult> Index(string _value = null, int _page = 1)
        {

            var result = Mapper.Map<IEnumerable<Autor_ViewModel>>(await _autorapp.GetAll());

            if (!String.IsNullOrEmpty(_value))
                result = result.Where(x => x.Midia.Any(j => j.Designacao.ToUpper().Contains(_value.ToUpper())) || x.Nome.ToUpper().Contains(_value.ToUpper()));

            result = result.OrderBy(x => x.Nome);

            ViewBag.currentFilter = _value;

            ViewData.Model = result.ToPagedList(_page, 10);

            return View();
        }
    }
}
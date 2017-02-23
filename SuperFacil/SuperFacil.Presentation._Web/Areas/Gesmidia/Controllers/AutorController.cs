using AutoMapper;
using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels;
using SuperFacil.Presentation._Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using PagedList;

namespace SuperFacil.Presentation._Web.Areas.Gesmidia.Controllers
{
    public class AutorController : BaseController
    {
        private readonly IMul_Autor_AppService _autorservice;

        public AutorController(IMul_Autor_AppService autorservice)
        {
            _autorservice = autorservice;
        }

        // GET: Gesmidia/Autor
        [HttpGet]
        public async Task<ActionResult> Index(string _value = "", int page = 1)
        {
            var result = Mapper.Map<IEnumerable<Autor_ViewModel>>(await _autorservice.GetAll());

            if (!String.IsNullOrEmpty(_value))
                result = result.Where(x => x.Nome.ToUpper().Contains(_value.ToUpper()));

            ViewBag.currentFilter = _value;
            ViewData.Model = result.OrderBy(x => x.Nome).ToPagedList(page, 10);

            return View();
        }


        // GET: Gesmidia/Autor/Especial
        public async Task<ActionResult> Especial()
        {
            ViewData.Model = Mapper.Map<IEnumerable<Autor_ViewModel>>(await _autorservice.Autor_Especial());

            return View();
        }

        // GET: Gesmidia/Autor/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ViewData.Model = Mapper.Map<Autor_ViewModel>(await _autorservice.GetID(id));

            return View();
        }

        // GET: Gesmidia/Autor/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gesmidia/Autor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Autor_ViewModel _autor)
        {
            try
            {
                _autor = _autor.Create_vm(_autor);

                if (ModelState.IsValid)
                {
                    _autorservice.Create(Mapper.Map<Mul_Autor>(_autor));

                    return RedirectToAction("Index", "Home");
                }

                return View(_autor);
            }
            catch
            {
                return View();
            }
        }

        // GET: Gesmidia/Autor/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            ViewData.Model = Mapper.Map<Autor_ViewModel>(await _autorservice.GetID(id));

            return View();
        }

        // POST: Gesmidia/Autor/Edit/5
        [HttpPost]
        public ActionResult Edit(Autor_ViewModel _autor)
        {
            try
            {
                _autor = _autor.Edit_vm(_autor);

                if (ModelState.IsValid)
                {
                    _autorservice.Update(Mapper.Map<Mul_Autor>(_autor));

                    return RedirectToAction("Index", "Autor");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Gesmidia/Autor/Delete/5
        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            ViewData.Model = Mapper.Map<Autor_ViewModel>(await _autorservice.GetID(id));

            return View();
        }

        // POST: Gesmidia/Autor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var autor = Mapper.Map<Autor_ViewModel>(await _autorservice.GetID(id));

                autor = autor.Delete_vm(autor);
                var _autor = Mapper.Map<Mul_Autor>(autor);

                _autorservice.Delete(_autor);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<JsonResult> Get_AllAutor(string _value)
        {
            var db = Mapper.Map<IEnumerable<Autor_ViewModel>>(await _autorservice.GetAll());

            var result = db.Where(x => x.Deleted = false)
                .Where(x => x.Nome.ToLower().Contains(_value.ToLower()))
                .Select(s => new { Nome = s.Nome, Autor_ID = s.Autor_ID })
                .Distinct().ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}

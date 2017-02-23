using AutoMapper;
using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels;
using SuperFacil.Presentation._Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Gesmidia.Controllers
{
    public class MidiaController : BaseController
    {
        private readonly IMul_Midia_AppService _midiaapp;
        private readonly IMul_Autor_AppService _autorapp;
        private readonly IMul_Localizacao_AppService _localapp;

        public MidiaController(IMul_Midia_AppService midiaapp,
                               IMul_Autor_AppService autorapp,
                               IMul_Localizacao_AppService localapp)
        {
            _midiaapp = midiaapp;
            _autorapp = autorapp;
            _localapp = localapp;
        }
        // GET: Gesmidia/Midia
        public async Task<ActionResult> Index(string _value = null, int page = 1)
        {
            var result = Mapper.Map<IEnumerable<Midia_ViewModel>>(await _midiaapp.GetAll());

            if (!String.IsNullOrEmpty(_value))
                result = result.Where(x => x.Designacao.ToUpper().Contains(_value.ToUpper()));

            ViewBag.currentFilter = _value;
            ViewData.Model = result;

            return View();
        }

        // GET: Gesmidia/Midia/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ViewData.Model = Mapper.Map<Midia_ViewModel>(await _midiaapp.GetID(id));

            return View();
        }

        // GET: Gesmidia/Midia/Create
        public async Task<ActionResult> Create()
        {
           // _midiaapp.GetOrganizarLocal();

            ViewBag.Autor = new SelectList((await _autorapp.GetAll()).OrderBy(x => x.Nome).ToList(), "Autor_ID", "Nome");
            ViewBag.Localizacao = new SelectList((await _localapp.GetAll()).OrderBy(x => new { x.Localizacao_ID, x.Designacao }).ToList(), "Localizacao_ID", "Designacao");

            return View();
        }

        // POST: Gesmidia/Midia/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Midia_ViewModel _midia)
        {
            _midia = _midia.Create_vm(_midia);

            if (ModelState.IsValid)
            {
                _midiaapp.Create(Mapper.Map<Mul_Midia>(_midia));

                return RedirectToAction("Index", "Home");
            }

            return View(_midia);

        }

        // GET: Gesmidia/Midia/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var midia = Mapper.Map<Midia_ViewModel>(await _midiaapp.GetID(id));

            if (midia == null)
            {
                return HttpNotFound();
            }

            ViewBag.Autor = new SelectList((await _autorapp.GetAll()).ToList(), "Autor_ID", "Nome");
            ViewBag.Localizacao = new SelectList((await _localapp.GetAll()).ToList(), "Localizacao_ID", "Designacao");

            ViewData.Model = midia;

            return View();
        }

        // POST: Gesmidia/Midia/Edit/5
        [HttpPost]
        public ActionResult Edit(Midia_ViewModel _midia)
        {
            _midia = _midia.Edit_vm(_midia);

            if (ModelState.IsValid)
            {
                _midiaapp.Update(Mapper.Map<Mul_Midia>(_midia));

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // GET: Gesmidia/Midia/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            ViewData.Model = Mapper.Map<Midia_ViewModel>(await _midiaapp.GetID(id));

            return View();
        }

        // POST: Gesmidia/Midia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var midia = Mapper.Map<Midia_ViewModel>(await _midiaapp.GetID(id));
                midia = midia.Delete_vm(midia);

                if (ModelState.IsValid)
                {
                    var _midia = Mapper.Map<Mul_Midia>(midia);

                    _midiaapp.Delete(_midia);

                    return RedirectToAction("Index", "Home");
                }

                return View(midia);
            }
            catch
            {
                return View();
            }
        }
    }
}

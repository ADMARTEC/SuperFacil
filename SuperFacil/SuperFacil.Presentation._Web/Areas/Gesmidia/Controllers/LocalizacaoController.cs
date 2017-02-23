using AutoMapper;
using PagedList;
using SuperFacil.Application.Interface.Multimidia;
using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels;
using SuperFacil.Presentation._Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Gesmidia.Controllers
{
    public class LocalizacaoController : BaseController
    {
        private readonly IMul_Localizacao_AppService _localApp;

        public LocalizacaoController(IMul_Localizacao_AppService localApp)
        {
            _localApp = localApp;
        }

        // GET: Gesmidia/Localizacao
        public async Task< ActionResult> Index(string _value = null, int _page = 1)
        {
            var result = Mapper.Map<IEnumerable<Localizacao_ViewModel>>(await _localApp.GetAll());

            if (!String.IsNullOrEmpty(_value))
                result = result.Where(x => x.Designacao.ToUpper().Contains(_value.ToUpper()));

            result = result.OrderBy(x => x.Designacao);

            ViewBag.currentFilter = _value;

            ViewData.Model = result.ToPagedList(_page, 10);

            return View();
        }

        // GET: Gesmidia/Localizacao/Details/5
        public async Task<ActionResult> Details(int id)
        {

            ViewData.Model = Mapper.Map<Localizacao_ViewModel>(await _localApp.GetID(id));

            return View();
        }

        // GET: Gesmidia/Localizacao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gesmidia/Localizacao/Create
        [HttpPost]
        public ActionResult Create(Localizacao_ViewModel _local)
        {
            try
            {
                _local = _local.Create_vm(_local);

                if (ModelState.IsValid)
                {
                    _localApp.Create(Mapper.Map<Mul_Localizacao>(_local));

                    return RedirectToAction("Index","Home");
                }

                return View(_local);
            }
            catch
            {
                return View();
            }
        }

        // GET: Gesmidia/Localizacao/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            ViewData.Model = Mapper.Map<Localizacao_ViewModel>(await _localApp.GetID(id));

            return View();
        }

        // POST: Gesmidia/Localizacao/Edit/5
        [HttpPost]
        public ActionResult Edit( Localizacao_ViewModel _local)
        {
            try
            {
                _local = _local.Edit_vm(_local);

                if (ModelState.IsValid)
                {
                    _localApp.Update(Mapper.Map<Mul_Localizacao>(_local));

                    return RedirectToAction("Index", "Localizacao");
                }

                return View(_local);
            }
            catch
            {
                return View();
            }
        }

        // GET: Gesmidia/Localizacao/Delete/5
        public async Task< ActionResult> Delete(int id)
        {
            ViewData.Model = Mapper.Map<Localizacao_ViewModel>(await _localApp.GetID(id));

            return View();
        }

        // POST: Gesmidia/Localizacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task< ActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var local = Mapper.Map<Autor_ViewModel>(await _localApp.GetID(id));

                local = local.Delete_vm(local);
                var _local = Mapper.Map<Mul_Localizacao>(local);

                _localApp.Delete(_local);

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}

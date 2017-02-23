using AutoMapper;
using SuperFacil.Application.Interface.Inquerito;
using SuperFacil.Presentation._Web.Areas.Inquerito.ViewModel;
using SuperFacil.Presentation._Web.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuperFacil.Presentation._Web.Areas.Inquerito.Controllers
{
    public class InqueritoController : Base_InqueritoController
    {
        private readonly IInq_Inquerito_AppService _Service;

        public InqueritoController(IInq_Inquerito_AppService Service)
        {
            _Service = Service;
        }

        // GET: Inquerito/Inquerito
        public async Task<ActionResult> Index()
        {
            var result = Mapper.Map<IEnumerable<Inq_Inquerito_ViewModel>>(await _Service.GetAll());

            ViewData.Model = result;

            return View();
        }

        // GET: Inquerito/Inquerito/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inquerito/Inquerito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inquerito/Inquerito/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inquerito/Inquerito/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inquerito/Inquerito/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inquerito/Inquerito/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inquerito/Inquerito/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

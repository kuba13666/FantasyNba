using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarsCms.Models;
using CarsCms.Repository.Interfaces;
using CarsCms.ViewModels;
using CarsCms.Validation;

namespace CarsCms.Controllers
{
    public class EngineEntitiesController : Controller
    {
        private IEngineRepository _engineRepository;
        public EngineEntitiesController(IEngineRepository engineRepository)
        {
            _engineRepository = engineRepository;
        }


        // GET: EngineEntities
        public ActionResult Index()
        {
            var viewModel = new VMEngines();
            viewModel.EngineList = _engineRepository.GetWhere(x => x.Id > 0);
            return View(viewModel);
        }

        // GET: EngineEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EngineEntity engineEntity = _engineRepository.GetWhere(x => x.Id == id.Value).SingleOrDefault();
            var viewModel = new VMEngines();
            viewModel.EngineEntity = engineEntity;
            if (engineEntity == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }

        // GET: EngineEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EngineEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VMEngines model)
        {
            var validator = new EngineValidator();
            var result = validator.Validate(model.EngineEntity);
            if (result.Errors.Any())
                foreach (var item in result.Errors)
                    ModelState.AddModelError("", item.ErrorMessage);
            else
            {
                _engineRepository.Create(model.EngineEntity);
                return RedirectToAction("Index");
            }


            return View(model);
        }

        // GET: EngineEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var viewModel = new VMEngines();
            EngineEntity engineEntity = _engineRepository.GetWhere(x => x.Id == id.Value).SingleOrDefault();
            viewModel.EngineEntity = engineEntity;
            if (engineEntity == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }

        // POST: EngineEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VMEngines engineEntity)
        {
            if (ModelState.IsValid)
            {
                _engineRepository.Update(engineEntity.EngineEntity);
                return RedirectToAction("Index");
            }
            return View(engineEntity);
        }

        // GET: EngineEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var viewModel = new VMEngines();
            viewModel.EngineEntity = _engineRepository.GetWhere(x => x.Id == id.Value).FirstOrDefault();
            if (viewModel.EngineEntity == null)
            {
                return HttpNotFound();
            }
            return View(viewModel);
        }

        // POST: EngineEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var engineEntity = _engineRepository.GetWhere(x => x.Id == id).FirstOrDefault();
            _engineRepository.Delete(engineEntity);
            return RedirectToAction("Index");
        }
    }
}

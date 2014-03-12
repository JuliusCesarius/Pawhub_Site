using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetHub_Site.Services;
using PetHub_Site.Models.MongoDB.LostAndFound;
using MongoDB.Bson;

namespace PetHub_Site.Controllers
{
    public class LostAndFoundController : Controller
    {
        LostAndFoundService _service;
        LostAndFoundService Service
        {
            get
            {
                if (_service == null)
                {
                    _service = new LostAndFoundService();
                }
                return _service;
            }
        }

        public ActionResult Index()
        {
            return View(Service.GetReports());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            Report report = new Report
            {
                _userId = new ObjectId(),
                description = "Test",
                viewBy2 = 3
                //detail = new Abuse
                //{
                //    name = "chachita"
                //}
            };
            Service.Add(report);
            return View();
        }

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

        public ActionResult Edit(int id)
        {
            return View();
        }

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

        public ActionResult Delete(int id)
        {
            return View();
        }

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

        [HttpGet]
        public JsonResult Get_ById(int id)
        {
            return Json(new Report {   description="HOla"}, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Get_ByCategoria(string category)
        {
            return Json(new Report { description = "Get_ByCategoria" }, JsonRequestBehavior.AllowGet);
        }
        
        [HttpGet]
        public JsonResult Get_ByCategoria_ById(string category, int id)
        {
            return Json(new Report { description = "Get_ByCategoria_ById" }, JsonRequestBehavior.AllowGet);
        }
    }
}

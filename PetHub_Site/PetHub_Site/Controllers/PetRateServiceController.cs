using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetHub_Site.Services;
using PetHub_Site.Models.ViewModels;

namespace PetHub_Site.Controllers
{
    public class PetRateServiceController : Controller
    {
        private PetMatchService _service = null;
        private PetMatchService Service
        {
            get
            {
                if (_service == null)
                {
                    _service = new PetMatchService();
                }
                return _service;
            }
        }

        [HttpGet]
        public JsonResult GetTopCategoryByUserId(Guid id)
        {
            var topByUser = Service.GetTopCategoryByUserId(id, 3, 10);
            return Json(topByUser, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetRateCategories()
        {
            var rateCategories = Service.GetRateCategories();
            return Json(rateCategories, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetPetRateByCategory(short id, Guid PetId)
        {
            var petRateByCategory = Service.GetPetRateByCategory(id, PetId);
            return Json(petRateByCategory, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTopCategories()
        {
            var topCategories = Service.GetTopCategories();
            return Json(topCategories, JsonRequestBehavior.AllowGet);
        }

        //TODO:Borrar este Action
        [HttpGet]
        public JsonResult GetRandomUser()
        {
            var topCategories = Service.GetRandomUser();
            return Json(topCategories, JsonRequestBehavior.AllowGet);
        }
        //TODO:Borrar este Action
        [HttpGet]
        public JsonResult GetAllTypes()
        {
            var topCategories = new AllClases();
            return Json(topCategories, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetPetRate(Guid? id, short CategoryId)
        {
            if (id != null)
            {
                Guid petId = (Guid)id;
                return Json(Service.GetPetRate(petId, CategoryId), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult RateAPet(Guid Id, Guid? PetId, List<RatingVM> Ratings)
        {
            Guid petGuid = PetId != null ? PetId.Value : new Guid();
            //TODO: Ver como evitar hacer este código modificando el Model Binding, porque solo asigna propiedades cuando tiene el formato: Ratings[0].RateCategoryId
            if (Ratings != null)
            {
                short i = 0;
                foreach (var ratingVM in Ratings)
                {
                    var rateCategoryId = Request.Form["Ratings[" + i.ToString() + "][RateCategoryId]"];
                    var stars = Request.Form["Ratings[" + i.ToString() + "][Stars]"];
                    i++;
                    ratingVM.RateCategoryId = Convert.ToInt16(rateCategoryId);
                    ratingVM.Stars = Convert.ToInt16(stars);
                }
            }
            var nextPetToRate = Service.RateAPet(Id, petGuid, Ratings);
            return Json(nextPetToRate,JsonRequestBehavior.AllowGet);
        }
    }
}

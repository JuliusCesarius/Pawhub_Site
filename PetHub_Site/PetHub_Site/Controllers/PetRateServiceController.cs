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

        public JsonResult GetTopCategoryByUserId(Guid id)
        {
            var topByUser = Service.GetTopCategoryByUserId(id, 3, 10);
            return Json(topByUser, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTopCategories()
        {
            var topCategories = Service.GetTopCategories();
            return Json(topCategories, JsonRequestBehavior.AllowGet);
        }

        public JsonResult RateAPet(Guid Id, Guid? PetId, List<RatingVM> Ratings)
        {
            Guid petGuid = PetId != null ? PetId.Value : new Guid();
            var nextPetToRate = Service.RateAPet(Id, petGuid, Ratings);
            return Json(nextPetToRate, JsonRequestBehavior.AllowGet);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetHub_Site.Models.ViewModels;
using PetHub_Site.Services;

namespace PetHub_Site.Controllers
{
    public class ProfileController : Controller
    {
        private ProfileService _service = null;
        private ProfileService Service
        {
            get
            {
                if (_service == null)
                {
                    _service = new ProfileService();
                }
                return _service;
            }
        }
        [HttpGet]
        public JsonResult GetKinds()
        {
            return Json(Service.GetKinds(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetBreeds(short? id)
        {
            short kindId = id != null ? (short)id : (short) 0;
            return Json(Service.GetBreedsByKindId(kindId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetPetProfile(Guid? id)
        {
            if (id != null)
            {
                Guid petId = (Guid)id;
                return Json(Service.GetPetProfile(petId), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult GetUserProfile(Guid? id)
        {
            if (id != null)
            {
                Guid userId = (Guid)id;
                return Json(Service.GetUserProfile(userId), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult RegisterUserProfile(ProfileVM profile)
        {
            bool succeed = false;
            if (ModelState.IsValid)
            {
                return Json(Service.RegisterUserProfile(profile));
            }
            return Json(succeed);
        }

        [HttpPost]
        public JsonResult RegisterPetProfile(PetProfileVM PetProfile)
        {
            bool succeed = false;
            if (ModelState.IsValid)
            {
                return Json(Service.RegisterPetProfile(PetProfile));
            }
            return Json(succeed);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetHub_Site.Services;
using PetHub_Site.Models.ViewModels;
using PetHub_Site.Models.Classes;

namespace PetHub_Site.Controllers
{
    public class RegisterController : Controller
    {
        private RegisterService _service = null;
        private RegisterService Service
        {
            get
            {
                if (_service == null)
                {
                    _service = new RegisterService();
                }
                return _service;
            }
        }

        [HttpGet]
        public ActionResult RegisteredUsers()
        {
            var usuarios = Service.GetRegisteredUsers();
            return View(usuarios);
        }

        [HttpGet]
        public JsonpResult PreUser(PreregistroVM preregistroVM)
        {           
            var topByUser = Service.PreUser(preregistroVM);
            return new JsonpResult
            {
                Data = topByUser,
                JsonRequestBehavior =JsonRequestBehavior.AllowGet
            };
        }

        [HttpGet]
        public JsonpResult Exist(string email)
        {
            var exist = Service.Exist(email);
            return new JsonpResult
            {
                Data = exist,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}

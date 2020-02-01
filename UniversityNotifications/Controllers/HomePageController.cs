using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityNotifications.DataBase;
using UniversityNotifications.Models;

namespace UniversityNotifications.Controllers
{
    public class HomePageController : Controller
    {
        DataBaseBusiness database = new DataBaseBusiness();

        // GET: HomePage
        public ActionResult Index()
        {
            return View();

        }

        [HttpPost]
        public ActionResult RegisterInNewsLetter(RegisterInNewsLetter model)
        {
            database.RegisterInNewsLetter(model);
            return Json("");
        }


        [HttpPost]
        public ActionResult ManagerLogin(ManagerLoginRequest model)
        {
            var result = database.ManagerLogin(model);
            return Json(result);
        }

    }
}
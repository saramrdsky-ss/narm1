using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityNotifications.DataBase;
using UniversityNotifications.Models;

namespace UniversityNotifications.Controllers
{
    public class NewsManegmentController : Controller
    {
        DataBaseBusiness database = new DataBaseBusiness();
        // GET: NewsManegment
        public ActionResult NewsManagement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetUniversity()
        {
            List<UniversityResponse> result = database.GetUniversity();
            return Json(result);
        }
        [HttpPost]
        public ActionResult GetCollege(int id)
        {
            List<CollegeResponse> result = database.GetCollege(id);
            return Json(result);
        }
        [HttpPost]
        public ActionResult GetLocation(int id)
        {
            List<LocationResponse> result = database.GetLocation(id);
            return Json(result);
        }
        [HttpPost]
        public ActionResult GetScreen()
        {
            List<ScreenResponse> result = database.GetScreen();
            return Json(result);
        }


        [HttpPost]
        public ActionResult InsertNotification(Notification model)
        {
            database.InsertNotification(model);
            return Json("");
        }

    }
}
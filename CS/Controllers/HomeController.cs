using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;

namespace Example.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View(HomeController.GetObjects());
        }

        public ActionResult GridViewPartial() {
            return PartialView("GridViewPartial", HomeController.GetObjects());
        }

        [HttpGet]
        public String CustomAction(Int32 id) {
            return String.Format("A row with the {0} key was selected", id);
        }

        public static List<MyObject> GetObjects() {
            List<MyObject> list = new List<MyObject> {
                new MyObject { Key = 1, Name = "Name 1" },
                new MyObject { Key = 2, Name = "Test 2" },
                new MyObject { Key = 3, Name = "Something 3" }
            };

            return list;
        }
    }
}

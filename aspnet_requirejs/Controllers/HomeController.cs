using aspnet_requirejs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_requirejs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<User>();
            model.Add(new User { Id = 1, Name = "Kwon" });
            model.Add(new User { Id = 2, Name = "Hyojung" });

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
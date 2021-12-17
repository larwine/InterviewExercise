using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechnicalExercise.Models;

namespace TechnicalExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Register()
        {
            ViewBag.Message = "Register";

            var model = new CandidateModel();
            model.PositionList.Add(new SelectListItem { Text = "Web Developer", Value = "1" });
            model.PositionList.Add(new SelectListItem { Text = "Platform Developer", Value = "2" });
            model.PositionList.Add(new SelectListItem { Text = "Business Analyst", Value = "3" });
            model.PositionList.Add(new SelectListItem { Text = "Project Manager", Value = "4" });
            model.JoinDate = DateTime.Today;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CandidateModel model)
        {
            ViewBag.Message = "Register";

            return View("Index", model);
        }
    }
}
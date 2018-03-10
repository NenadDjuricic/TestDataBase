﻿using System.Web.Mvc;

namespace TestDataBase.Controllers
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

        public ActionResult oNama()
        {
            ViewBag.Message = "O nama";

            return View();
        }
        public ActionResult galerija()
        {
            ViewBag.Message = "Galerija";

            return View();
        }
    }
}
using DemoAsp.FullMvc.Infrastructure;
using DemoAsp.FullMvc.Infrastructure.Attributes;
using DemoAsp.FullMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAsp.FullMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //return View("Error");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AuthorizeManager]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AuthorizeManager(RoleUser.Admin)]
        public ActionResult Secret()
        {
            return View();
        }
    }
}
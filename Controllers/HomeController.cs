using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WellBeingCampaign.Controllers
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
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.CookieIsSet = HttpContext.Request.Cookies["AppCookie"] != null ? true : false;

            return View();
        }
        [HttpPost]
        public ActionResult Contact(FormCollection collection)
        {
            ViewBag.Message = "Your contact page.";
            if (!string.IsNullOrEmpty(collection["message"]))
            {
                HttpCookie appcookie = new HttpCookie("AppCookie", "form submitted");
                Response.Cookies.Add(appcookie);
            }
            ViewBag.CookieIsSet = true;

            return View();
        }
    }
}
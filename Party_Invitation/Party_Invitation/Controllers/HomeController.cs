using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Party_Invitation.Models;
namespace Party_Invitation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Greating = (DateTime.Now.Hour < 12) ? "Good Morning" : (DateTime.Now.Hour < 18) ? "Good Afternoon" : "Good Evening";
            return View();
        }
        [HttpGet]
        public ActionResult Reservation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reservation(Guest Guest)
        {
            if (ModelState.IsValid == true)
                return View("Thanks", Guest);
            else
                return View();
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Party_Invitation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.Greating = (DateTime.Now.Hour < 12) ? "Good Morning" : (DateTime.Now.Hour < 18) ? "Good Afternoon" : "Good Evening";
            return View();
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpDesk.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Userd()
        {
            return View();
        }
        public ActionResult Tickets()
        {
            return View();
        }
        public ActionResult Department()
        {
            return View();
        }
    }
}
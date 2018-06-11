using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MAEMS.Data;
namespace MAEMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private IEventDataSource _db;

        public HomeController(IEventDataSource dataSource)
        {
            _db = dataSource;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var allEvents = _db.Events;

            return View(allEvents);
        }
    }
}

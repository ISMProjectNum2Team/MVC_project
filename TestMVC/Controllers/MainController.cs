using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;
namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            ViewBag.Event = ListModel.getByID(id);
            return View();
        }

        public ActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public string AddEvent(string title, string description, string details, string location)
        {
            ListModel.getEventList().Add(new Event(title, description, details, location));
            return "<div style='text-align: center'>Event added! You will be redirected to list at 3 seconds.</div><script>setTimeout(function() { document.location='/home/list'; }, 3000)</script>";
        }
    }
}

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

    }
}

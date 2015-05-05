using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;
namespace TestMVC.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            var model = new ListModel();
            return View(model);
        }
        //[HttpGet]
        //public ActionResult Details(int id)
        //{
        //    Event e = ListModel.getByID(id);
        //    return View(e);
        //}
    }
}

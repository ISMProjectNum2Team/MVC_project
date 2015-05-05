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
            var model = new EventDataProvider();
            return View(model.GetEventList());
        }
        [HttpGet]
        public ActionResult Details(string id)
        {
            var model = new EventDataProvider();
            var result = model.GetByID(id);
            if (result == null) {
                return HttpNotFound();
            }
            return View(result);
        }
    }
}

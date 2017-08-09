using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Services;
using Admin.Models;

namespace SASweb.Controllers
{
    public class HandlerController : Controller
    {
        HandlerServices handlerservices = new HandlerServices();
        // GET: Handler
        public ActionResult HandlerForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HandlerForm(HandlerModel handlerModel)
        {
            handlerservices.addHandler(handlerModel);
            return View();
        }
        public ActionResult HandlerList()
        {
            var handlers = handlerservices.getAllHandler();
            return View(handlers);
        }
    }
}
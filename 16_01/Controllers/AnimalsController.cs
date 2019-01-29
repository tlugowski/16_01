using _16_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_01.Controllers
{
    public class AnimalsController : Controller
    {
        // GET: Animals
        public ActionResult Animals()
        {
            var model = new Animals();
            model.GeneralType = "Psy";
            model.Kind = "Owczarek niemiecki";
            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
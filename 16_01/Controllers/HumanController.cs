using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_01.Controllers
{
    public class HumanController : Controller
    {
        // GET: Human
        public ActionResult ShowForm()
        {
            return View("Human");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_01.Controllers
{
    public class CarRegistrationController : Controller
    {
        // GET: CarRegistration
        public ActionResult ShowCarRegistration()
        {
            return View("CarRegistration");
        }
    }
}
using _16_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpGet]
        public ActionResult ShowUser()
        {
            var model = new UserCredentials();
            model.Login = "kam";
            model.Password = "123";
         
            return View(model);
        }

    }
}
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
            model.Login = "tom";
            model.Password = "123";
         
            return View(model);
        }
        [HttpPost]
        public ActionResult ShowUser(CD model)
        {
            if (ModelState.IsValid)
            {
                //dane sa poprawne
                //zapisz do bazy 
                //przygotuj potwierdzenie 

            }
            else
            {

                //dane nie sa poprawne 
            }

            //if (model.Title.Length > 64) throw new Exception("Błedne dane" );
            //if (model.Title.Length < 3) throw new Exception("Błedne dane");

            //return null
            throw new NotImplementedException();
        }

    }
}
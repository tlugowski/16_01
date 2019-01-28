using _16_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_01.Controllers
{
    public class CDController : Controller
    {
        /// <summary>
        /// Wyświetla formularz do rejestracji płyty
        /// </summary>
        [HttpGet]
        public ActionResult Create()
        {
            return View("CD");
        }

        /// <summary>
        /// Przyjecie informacji z formularza
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(CD model)
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
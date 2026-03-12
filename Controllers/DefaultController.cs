using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StudentRegistration()
        {

            return View();
        }

        [HttpPost]
        public ActionResult StudentRegistration(Student student)
        {
            if (ModelState.IsValid)
            {
                
                return View("RegisterSuccess", student);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult RegisterSuccess()
        {

            return View();
        }

    }
}
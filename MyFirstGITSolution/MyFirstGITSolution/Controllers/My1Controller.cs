using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstGITSolution.Controllers
{
    public class My1Controller : Controller
    {
        //
        // GET: /My1/
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Message2 = "Hello2";
            return View();
        }
	}
}
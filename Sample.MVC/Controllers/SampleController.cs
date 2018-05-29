using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.MVC.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GridView()
        {
            return View();
        }

        public ActionResult TreeView()
        {
            return View();
        }

        public ActionResult UploadFile()
        {
            return View();
        }


    }
}
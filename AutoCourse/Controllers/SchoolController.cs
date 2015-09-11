using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoCourse.BLL;

namespace AutoCourse.Controllers
{
    [Authorize]
    public class SchoolController : Controller
    {
        //
        // GET: /School/
        public ActionResult Index()
        {
            return View(new BLLSchool().FindList(m => true));
        }

        public ActionResult CreateNew()
        {
            return View();
        }
    }
}
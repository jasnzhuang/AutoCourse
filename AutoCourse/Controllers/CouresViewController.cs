using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCourse.Controllers
{
    public class CouresViewController : Controller
    {
        //
        // GET: /CouresView/
        public ActionResult Index(int schoolid)
        {
            return View();
        }
    }
}
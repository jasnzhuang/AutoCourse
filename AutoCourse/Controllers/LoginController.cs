using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCourse.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username)
        {
            AutoCourse.BLL.BLLManageUser m = new BLL.BLLManageUser();
            AutoCourse.Models.ManageUser mu = m.Find(username);
            
        }
	}
}
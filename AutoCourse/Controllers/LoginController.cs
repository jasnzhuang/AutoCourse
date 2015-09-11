using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoCourse.BLL;

namespace AutoCourse.Controllers
{
    public class LoginController : Controller
    {

        //
        // GET: /Login/
        public ActionResult Index()
        {
            BLLManageUser mu = new BLLManageUser();
            ViewData["username"] = mu.GetUserName(User);
            ViewData["schoolid"] = mu.GetSchoolID(User);
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            string username = Request.Form["tbusername"];

            BLLManageUser mu = new BLLManageUser();
            AutoCourse.Models.ManageUser m = mu.Find(u => u.UserName == username);
            mu.Authentication(Request.RequestContext.HttpContext, username, m);

            ViewData["username"] = mu.GetUserName(User);
            ViewData["schoolid"] = mu.GetSchoolID(User);

            return View("index");
            //return Redirect("~/School/index");
        }

        public ActionResult LoginOut()
        {
            BLLManageUser.LoginOut(Request.RequestContext.HttpContext);

            BLLManageUser mu = new BLLManageUser();
            string s = mu.GetUserName(User) + "|" + mu.GetSchoolID(User);
            return Content(s);
        }
    }
}
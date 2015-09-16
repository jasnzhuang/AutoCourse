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
            ViewData["SchoolID"] = User.GetSchoolID();
            return View(new BLLSchool().FindList(m => true));
        }

        public ActionResult CreateNew()
        {
            BLLSchool bs = new BLLSchool();
            Models.School sc = new Models.School();
            sc.SchoolName = "";
            bs.Add(sc);
            //创建学校，同时创建学校和用户的关系
            Models.ManageUser mu = new Models.ManageUser();
            mu.UserName = User.GetUserName();
            mu.SchoolID = sc.SchoolID;
            new BLLManageUser().Add(mu);
            return View("Edit", sc);
            //return Redirect("Edit?schoolid=" + sc.SchoolID);
            //return RedirectToAction("Edit", new { schoolid = sc.SchoolID });
        }

        public ActionResult Edit(int schoolid)
        {
            return View(new BLLSchool().Find(schoolid));
        }

        public ActionResult UpDate()
        {

            return View("Edit");
        }
    }
}
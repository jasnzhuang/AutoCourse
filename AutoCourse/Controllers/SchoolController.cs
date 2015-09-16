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
            sc.SchoolName = "新学校";
            bs.Add(sc);
            //创建学校，同时创建学校和用户的关系
            Models.ManageUser mu = new Models.ManageUser();
            mu.UserName = User.GetUserName();
            mu.SchoolID = sc.SchoolID;
            User.SetSchoolID(sc.SchoolID);

            new BLLManageUser().Add(mu);
            return View("Edit", sc);
            //return Redirect("Edit?schoolid=" + sc.SchoolID);
            //return RedirectToAction("Edit", new { schoolid = sc.SchoolID });
        }

        public ActionResult Edit()
        {
            return View(new BLLSchool().Find(User.GetSchoolID()));
        }

        [HttpPost]
        public ActionResult Edit(Models.School school)
        {
            BLL.BLLSchool bs = new BLLSchool();
            Models.School sc = bs.Find(school.SchoolID);
            sc.SchoolName = school.SchoolName;
            bs.UpDate(sc);
            return View(sc);
        }

        [HttpPost]
        public ActionResult CreateCourese()
        {
            int schoolid = User.GetSchoolID();
            BLL.ACBaseExecService.ExecSQL("Delete Courses Where SchoolID={0}", schoolid);
            string s = Request.Form["data"];
            BLLCousrse bc = new BLLCousrse();
            foreach (var c in s.Split('\n'))
            {
                Models.Course mc = new Models.Course();
                mc.CourseName = c;
                mc.SchoolID = schoolid;
                bc.Add(mc, false);

            }
            bc.Save();
            return Content("T");
        }

        [HttpPost]
        public ActionResult CreateClass()
        {
            int schoolid = User.GetSchoolID();
            BLL.ACBaseExecService.ExecSQL("Delete Classes Where SchoolID={0}", schoolid);
            string s = Request.Form["data"];
            BLLClass bc = new BLLClass();
            foreach (var c in s.Split('\n'))
            {
                Models.Class mc = new Models.Class();
                mc.ClassName = c;
                mc.SchoolID = schoolid;
                bc.Add(mc, false);

            }
            bc.Save();
            return Content("T");
        }

        [HttpPost]
        public ActionResult CreateTeacher()
        {
            int schoolid = User.GetSchoolID();
            BLL.ACBaseExecService.ExecSQL("Delete Teachers Where SchoolID={0}", schoolid);
            string s = Request.Form["data"];
            BllTeacher bc = new BllTeacher();
            foreach (var c in s.Split('\n'))
            {
                Models.Teacher mc = new Models.Teacher();
                mc.TeacherName = c;                
                mc.SchoolID = schoolid;
                bc.Add(mc, false);

            }
            bc.Save();
            return Content("T");
        }
    }
}
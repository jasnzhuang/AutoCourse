using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Security.Principal;
using System.Web.Mvc;
using AutoCourse.Models;


namespace AutoCourse.BLL
{
    public class BLLManageUser : ACBaseServices<ManageUser>
    {
        public ManageUser Login(string username)
        {
            ManageUser mu = Find(m => m.UserName == username);
            return mu;
        }

        
    }
}

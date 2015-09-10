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

        public void Authentication(HttpContextBase httpcontext, string username, AutoCourse.Models.ManageUser manageuser)
        {
            ClaimsIdentity _identity = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
            if (manageuser == null)
            {
                _identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, username));
                _identity.AddClaim(new Claim(ClaimTypes.GroupSid, "0"));
            }
            else
            {
                _identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, manageuser.UserName));
                _identity.AddClaim(new Claim(ClaimTypes.GroupSid, manageuser.SchoolID.ToString()));
            }

            httpcontext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            httpcontext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties() { IsPersistent = true }, _identity);
        }
    }
}

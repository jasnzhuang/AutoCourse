using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AutoCourse.BLL
{
    public static class UserAuthentication
    {
        public static void Authentication(this HttpContextBase httpcontext, string username, AutoCourse.Models.ManageUser manageuser)
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
            _identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity"));

            httpcontext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            httpcontext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties() { IsPersistent = true }, _identity);
        }

        public static void LoginOut(this HttpContextBase httpcontext)
        {
            httpcontext.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        public static string GetUserName(this IPrincipal user)
        {
            var claim = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.NameIdentifier);
            return claim == null ? null : claim.Value;
        }

        public static void SetSchoolID(this IPrincipal user,int schoolid)
        {
            ClaimsIdentity _identity = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
            _identity.AddClaim(new Claim(ClaimTypes.GroupSid, schoolid.ToString()));

        }

        public static int GetSchoolID(this IPrincipal user)
        {
            var claim = ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.GroupSid);
            return claim == null ? 0 : Convert.ToInt32(claim.Value);
        }
    }
}

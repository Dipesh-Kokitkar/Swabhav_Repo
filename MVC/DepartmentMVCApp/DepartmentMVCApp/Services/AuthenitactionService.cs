using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DepartmentMVCApp.Services
{
    public class AuthenitactionService
    {
        public bool Validate(string username, string password)
        {
            if (username.Equals("dipesh") && password.Equals("dsk@123"))
            {
                FormsAuthentication.SetAuthCookie("dipesh", false);
                return true; 
            }
            return false;
        }

        public void Logout() {
            if (FormsAuthentication.FormsCookieName != null) {
                FormsAuthentication.SignOut();
            }
        }
    }
}
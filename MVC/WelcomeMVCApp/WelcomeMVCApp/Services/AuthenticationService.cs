using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMVCApp.Services
{
    public class AuthenticationService
    {
        public bool Validate(string username ,string password) {
            if (username.Equals("dipesh") && password.Equals("dsk@123")) {
                return true;
            }
            return false;
        }
    }
}
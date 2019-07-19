﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WelcomeMVCApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Session_Start() {
            if (Session["Isloggedin"] == null)
            {
                Session["Isloggedin"] = false;
            }
        }
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();
           
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace DepartmentMVCApp.Filter
{
    public class CustomLogger:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string path = @"D:\Swabhav Respositry\MVC\DepartmentMVCApp\DepartmentMVCApp\DepartmentAppLog.txt";
            File.AppendAllText(path,DateTime.Now+":"+filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +" "+filterContext.ActionDescriptor.ActionName
                +" action is performed"+Environment.NewLine);
            base.OnActionExecuted(filterContext);
        }
    }
}
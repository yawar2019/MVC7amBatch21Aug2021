using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amBatch21Aug2021.Filter
{
    
    public class UserDefined  :ActionFilterAttribute
    {
        
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
           
        }
       
         
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
             
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewBag.PlayerName = "Kohli";
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }

    }
}
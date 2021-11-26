using PhoDiem_TLU.Commons;
using PhoDiem_TLU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PhoDiem_TLU.Core
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filerContext)
        {
            var sess = (TokenResult)Session[SeesionSystems.USER_TOKEN];
            if (sess == null)
            {
                filerContext.Result = new RedirectToRouteResult
                    (new RouteValueDictionary(new { controller = "Login", action = "Index" }));
            }
            base.OnActionExecuting(filerContext);
        }

        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
    }
}
using PhoDiem_TLU.Commons;
using PhoDiem_TLU.Core;
using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoDiem_TLU.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if(Session[SeesionSystems.USER_TOKEN].ToString() != null)
            {
                TokenResult tokenResult =(TokenResult) Session[SeesionSystems.USER_TOKEN];
                IEnumerable<RoleViewModel> roles = LoginTokenHttpClient.getAllRoles(tokenResult).AsEnumerable();
                ViewBag.type = roles.GetType();
                UserViewModel model = new UserViewModel();
                model.roles = roles;
                SelectList r = new SelectList((from s in roles select s), "id", "name");
                ViewBag.roles = r;
                return View(model);
            }
            return RedirectToAction("Error", "Login");
        }
    }
}
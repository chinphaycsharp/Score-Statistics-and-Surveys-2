using Newtonsoft.Json;
using PhoDiem_TLU.Commons;
using PhoDiem_TLU.Core;
using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PhoDiem_TLU.Controllers
{
    public class UserController : BaseController
    {
        private static int pageSize = 10;
        public ActionResult ListUser(int page = 1)
        {
            if(page < 1)
            {
                page = 1;
            }

            TokenResult tokenResult = (TokenResult)Session[SeesionSystems.USER_TOKEN];
            DataViewModels pagination = LoginTokenHttpClient.GetListUser(tokenResult,page,pageSize);

            var pager = new Pager(pagination.totalElements, page, pageSize);

            int recSkip = (page - 1) * pageSize;

            ViewBag.content = pagination.content;
            ViewBag.Pager = pager;
            IEnumerable<RoleViewModel> roles = LoginTokenHttpClient.getAllRoles(tokenResult).AsEnumerable();
            ViewBag.type = roles.GetType();
            UserViewModel model = new UserViewModel();
            model.roles = roles;
            SelectList r = new SelectList((from s in roles select s), "id", "name");
            ViewBag.roles = r;
            var genderList = new List<SelectListItem>
                {
                    new SelectListItem { Value="M", Text = "1"},
                    new SelectListItem { Value="F", Text = "0"},
                     new SelectListItem { Value="Khac", Text = "-1"}
                };

            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var row in genderList)
            {
                list.Add(new SelectListItem()
                {
                    Text = row.Value,
                    Value = row.Value
                });
            }

            ViewBag.genderList = ToSelectList(list, "Value", "Value");
            return View(model);
        
        }

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
                var genderList = new List<SelectListItem>
                {
                    new SelectListItem { Value="M", Text = "1"},
                    new SelectListItem { Value="F", Text = "0"},
                     new SelectListItem { Value="Khac", Text = "-1"}
                };

                List<SelectListItem> list = new List<SelectListItem>();
                foreach (var row in genderList)
                {
                    list.Add(new SelectListItem()
                    {
                        Text = row.Value,
                        Value = row.Value
                    });
                }

                ViewBag.genderList = ToSelectList(list, "Value", "Value");

                return View(model);
            }
            return RedirectToAction("Error", "Login");
        }

        [NonAction]
        public SelectList ToSelectList(List<SelectListItem> input, string valueField, string textField)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var row in input)
            {
                list.Add(new SelectListItem()
                {
                    Text = row.Value.ToString(),
                    Value = row.Text.ToString()
                });
            }

            return new SelectList(list, "Value", "Value");
        }

        public ActionResult CreateUser(UserViewModel model)
        {
            if(model != null)
            {
                string json = JsonConvert.SerializeObject(model);
                TokenResult tokenResult = (TokenResult)Session[SeesionSystems.USER_TOKEN];
                UserAddViewModel user = new UserAddViewModel();
                List<RoleAddViewModel> roleViews = new List<RoleAddViewModel>();
                user.person.displayName = model.displayName;
                user.username = model.username;
                user.email = model.email;
                user.person.firstName = model.firstName;
                user.person.lastName = model.lastName;
                user.password = model.password;
                user.confirmPassword = model.confirmPassword;
                user.active = 0;
                //user.createBy = "lequang";
                //user.createDate = DateTime.Now;
                user.person.gender = model.gender.ToString();
                user.isNew = true;
                user.changePass = false;
                IEnumerable<RoleViewModel> roles = LoginTokenHttpClient.getAllRoles(tokenResult).AsEnumerable();
                for (int i = 0; i < model.roleIds.Length; i++)
                {
                    foreach (var item in roles)
                    {
                        if(item.id == model.roleIds[i])
                        {
                            RoleAddViewModel roleAddView = new RoleAddViewModel();
                            roleAddView.id = item.id;
                            roleAddView.name = item.name;
                            roleAddView.description = item.description;
                            roleAddView.authority = item.authority;
                            roleViews.Add(roleAddView);
                        }
                    }
                }
                user.roles = roleViews.AsEnumerable();
                if(user.password != user.confirmPassword)
                {
                    SetAlert("Nhap lai mat khau khong dung", "warning");
                    return RedirectToAction("Index");
                }
                Task<bool> check = LoginTokenHttpClient.AddUserAsync(user,tokenResult);
                SetAlert("Them nguoi dung thanh cong", "success");
                return RedirectToAction("ListUser", "User");
            }
            return RedirectToAction("ListUser", "User");
        }

        [HttpPost]
        public ActionResult Delete(int [] selectedUsers)
        {
            TokenResult tokenResult = (TokenResult)Session[SeesionSystems.USER_TOKEN];
            bool result = LoginTokenHttpClient.DeleteUsers(tokenResult,selectedUsers);
            if(result)
            {
                SetAlert("Xoa nguoi dung thanh cong !", "success");
                return RedirectToAction("ListUser", "User");
            }
            return RedirectToAction("ListUser", "User");
        }
    }
}
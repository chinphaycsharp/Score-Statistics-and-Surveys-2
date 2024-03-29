﻿using Newtonsoft.Json;
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
    public class UserController : Controller
    {
        private static int pageSize = 10;
        private static int idUser = 0;
        public ActionResult ListUser(int page = 1)
        {
            if(page < 1)
            {
                page = 1;
            }

            TokenResult tokenResult = (TokenResult)Session[SeesionSystems.USER_TOKEN];
            DataViewModels pagination = LoginTokenHttpClient.GetListUser(tokenResult,page,pageSize);
            Pager pager = null;
            if (pagination != null)
            {
                pager = new Pager(pagination.totalElements, page, pageSize);
            }
            else
            {
                //Chỗ này thêm thông báo nếu người dùng k có quyền hiển thị ra
                return RedirectToAction("Index", "Login");
            }


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
                    
                    return RedirectToAction("Index");
                }
                Task<bool> check = LoginTokenHttpClient.AddUserAsync(user,tokenResult);
                if(check.Result)
                {
                    
                }
                else
                {
                    
                }
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
                return RedirectToAction("ListUser", "User");
            }
            return RedirectToAction("ListUser", "User");
        }

        [HttpGet]
        public JsonResult Detail(int id)
        {
            idUser = id;
            TokenResult tokenResult = (TokenResult)Session[SeesionSystems.USER_TOKEN];
            UserViewModel model = LoginTokenHttpClient.DetailUser(tokenResult, id);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DetailAndEditUser(int id)
        {
            TokenResult tokenResult = (TokenResult)Session[SeesionSystems.USER_TOKEN];
            UserViewModel model = LoginTokenHttpClient.DetailUser(tokenResult, id);
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
            List<SelectListItem> listroles = new List<SelectListItem>();
            int i = 0;
            model.roleIds = new long[model.roles.Count()];
            foreach (var row in model.roles)
            {
                model.roleIds[i] = row.id;
                listroles.Add(new SelectListItem()
                {
                    Text = row.name,
                    Value = row.id.ToString()
                });
                i++;
            }
            ViewBag.genderList = ToSelectList(list, "Value", "Value");
            ViewBag.SkillListItem = ToSelectList(listroles,"id","name");
            IEnumerable<RoleViewModel> roles = LoginTokenHttpClient.getAllRoles(tokenResult).AsEnumerable();
            ViewBag.roles = roles;
            return PartialView("DetailAndEditUser", model);
        }

        public ActionResult UpdateUser(int id, UserViewModel model)
        {
            bool isAdmin = false;
            TokenResult tokenResult = (TokenResult)Session[SeesionSystems.USER_TOKEN];
            UserViewModel detail = LoginTokenHttpClient.DetailUser(tokenResult, id);
            UserLogin user = LoginTokenHttpClient.GetUser(tokenResult);
            foreach (var item in user.roles)
            {
                if(item.name == Constants.ROLE_ADMIN)
                {
                    isAdmin = true;
                    break;
                }
            }
            if(isAdmin)
            {
                if (model != null)
                {

                    UpdateUserViewModel updateUser = new UpdateUserViewModel();
                    updateUser.id = (long)id;
                    updateUser.birthPlace = model.birthPlace;
                    updateUser.confirmPassword = model.confirmPassword;
                    updateUser.createdBy = "lequang";
                    updateUser.displayName = model.displayName;
                    updateUser.dob = model.dob;
                    updateUser.email = model.email;
                    updateUser.firstName = model.firstName;
                    updateUser.hasPhoto = true;
                    updateUser.isNew = false;
                    updateUser.lastName = model.lastName;
                    updateUser.password = model.password;
                    updateUser.username = model.username;
                    updateUser.person = detail.person;
                    updateUser.person.lastName = String.Empty;
                    updateUser.person.firstName = String.Empty;
                    string fullName = model.person.displayName;
                    string[] nameSlice = fullName.Split(' ');
                    updateUser.person.firstName = nameSlice[nameSlice.Length - 1];
                    for (int i = 0; i < nameSlice.Length - 1; i++)
                    {
                        updateUser.person.lastName += nameSlice[i] + " ";
                    }
                    updateUser.active = model.active == 1 ? true : false;
                    updateUser.groups = new List<GruopUpdateViewModel>();
                    updateUser.person.displayName = fullName;
                    IEnumerable<RoleViewModel> roles = LoginTokenHttpClient.getAllRoles(tokenResult).AsEnumerable();
                    List<RoleViewModel> roleupdate = new List<RoleViewModel>();
                    foreach (var item in roles)
                    {
                        for (int i = 0; i < model.roleIds.Length; i++)
                        {
                            if (item.id == model.roleIds[i])
                            {
                                roleupdate.Add(item);
                            }
                        }
                    }
                    updateUser.roles = roleupdate;

                    updateUser.person.address = detail.person.address;
                    if (model.password != null)
                    {
                        updateUser.password = model.password;
                    }

                    if (model.password != null || model.confirmPassword != null)
                    {
                        model.setPassword = true;
                        updateUser.changePass = true;
                        if (!model.password.Contains(model.confirmPassword))
                        {
                            return RedirectToAction("ListUser", "User");
                        }
                    }
                    else
                    {
                        updateUser.changePass = false;
                        model.setPassword = false;
                    }
                    Task<bool> check = LoginTokenHttpClient.UpdateUserAsync(updateUser, tokenResult);
                    if(check.Result)
                    {
                        
                    }
                    else
                    {
                        
                    }
                    return RedirectToAction("ListUser", "User");
                }
            }
            else
            {
                return RedirectToAction("ListUser", "User");
            }
           
           return RedirectToAction("ListUser", "User");
        }
    }
}
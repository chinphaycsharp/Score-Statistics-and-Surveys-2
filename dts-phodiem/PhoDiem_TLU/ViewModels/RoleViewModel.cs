using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class RoleViewModel
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string authority { get; set; }

        public static List<RoleViewModel> getRoles(JToken json)
        {
            List<RoleViewModel> roles = new List<RoleViewModel>();
            foreach(var item in json)
            {
                RoleViewModel role = new RoleViewModel();
                role.id = (long)item["id"];
                role.name = (string)item["name"];
                role.description = (string)item["description"];
                role.authority = (string)item["authority"];
                roles.Add(role);
            }

            return roles;
        }
    }
}
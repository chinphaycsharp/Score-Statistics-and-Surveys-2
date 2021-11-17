using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.Commons
{
    public class UserLogin
    {
        public string name { get; set; }
        public List<RoleViewModel> roles { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class UserViewModel
    {
        public long id { get; set; }
        public RoleViewModel roles { get; set; }

        public UserViewModel()
        {
            roles = new RoleViewModel();
        }
    }
}
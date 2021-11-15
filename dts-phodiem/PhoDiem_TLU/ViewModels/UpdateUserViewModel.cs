using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class UpdateUserViewModel
    {
        public DateTime createDate { get; set; }
        public string createBy { get; set; }
        public DateTime modifyDate { get; set; }
        public string modifiedBy { get; set; }
        public long id { get; set; }
        public string displayName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public bool changePass { get; set; }
        public bool active { get; set; }
        public string lastName { get; set; }
        public string fisrtName { get; set; }
        public string dob { get; set; }
        public string birthPlace { get; set; }
        public string email { get; set; }
        public PersonViewModel person { get; set; }
        public bool hasPhoto { get; set; }
        public IEnumerable<RoleViewModel> roles { get; set; }
        public List<GruopUpdateViewModel> groups { get; set; }
        public bool setPassword { get; set; }
        public bool isNew { get; set; }
    }

    public class GruopUpdateViewModel
    {

    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class UserAddViewModel
    {
        [DisplayName("Kich hoat")]
        public int active { get; set; }
        [DisplayName("Doi Pass")]
        public bool changePass { get; set; }
        [DisplayName("Nhap lai mat khau")]
        public string confirmPassword { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Tai khoan moi")]
        public bool isNew{ get; set; }
        [DisplayName("Mat khau")]
        public string password{ get; set; }
        [DisplayName("Ten tai khoan")]
        public string username { get; set; }
        public PersonAddViewModel person;
        public IEnumerable<RoleAddViewModel> roles;
        //public DateTime createDate { get; set; }
        //public string createBy { get; set; }
        //public DateTime modifyDate { get; set; }
        //public string modifyBy { get; set; }
        public UserAddViewModel()
        {
            person = new PersonAddViewModel();
        }

    }

    public class PersonAddViewModel
    {
        public string displayName { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public string lastName { get; set; }
    }

    public class RoleAddViewModel
    {
        public string authority { get; set; }
        public string description { get; set; }
        public long id { get; set; }
        public string name { get; set; }
    }
}
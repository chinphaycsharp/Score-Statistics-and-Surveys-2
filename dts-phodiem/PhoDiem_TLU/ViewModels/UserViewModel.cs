using Newtonsoft.Json.Linq;
using PhoDiem_TLU.Commons;
using PhoDiem_TLU.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class UserViewModel
    {
        public long id { get; set; }
        public int active { get; set; }
        public string birthPlace { get; set; }
        [DisplayName("Doi mat khau")]
        public bool changePass { get; set; }
        [DisplayName("Xac nhan mat khau")]
        public string confirmPassword { get; set; }
        public DateTime createDate { get; set; }
        public string createBy { get; set; }
        [DisplayName("Ho va ten")]
        public string displayName { get; set; }
        public DateTime dob { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Ho")]
        public string firstName { get; set; }
        public bool hasPhoto { get; set; }
        [DisplayName("Ten")]
        public string lastName { get; set; }
        public string modifiedBy { get; set; }
        public DateTime modifyDate { get; set; }
        [DisplayName("Mat khau")]
        public string password { get; set; }
        public PersonViewModel person { get; set; }
        public long[] roleIds { get; set; }
        public IEnumerable<RoleViewModel> roles { get; set; }
        public bool setPassword { get; set; }
        [DisplayName("Ten dang nhap")]
        public string username { get; set; }
        public string gender { get; set; }
        public bool isNew { get; set; }

        public UserViewModel()
        {
            person = new PersonViewModel();
        }

        public static List<UserViewModel> HandleJtokenToUserResult(JToken input)
        {
            List<UserViewModel> users = new List<UserViewModel>();
            foreach(var item in input)
            {
                UserViewModel user = new UserViewModel();
                user.id = (long)item["id"];
                user.active = (int)item["active"];
                user.birthPlace = (string)item["birthPlace"];
                user.changePass = (bool)item["changePass"];
                user.confirmPassword = (string)item["confirmPassword"];
                user.createDate = Constants.HandleJtokenToDate(item["createDate"]) ;
                user.createBy = (string)item["createdBy"];
                user.displayName = (string)item["displayName"];
                user.dob = Constants.HandleJtokenToDate((string)item["dob"]);
                user.email = (string)item["email"];
                user.firstName = (string)item["firstName"];
                user.lastName = (string)item["lastName"];
                user.modifiedBy = (string)item["modifiedBy"];
                user.username = (string)item["username"];
                user.setPassword = (bool)item["setPassword"];
                user.password = (string)item["password"];
                user.modifyDate = Constants.HandleJtokenToDate(item["modifyDate"]);
                var person = item["person"];
                if(person.HasValues)
                {
                    user.person.createBy = (string)person["createdBy"];
                    user.person.displayName = (string)person["displayName"];
                    user.person.firstName = (string)person["firstName"];
                    user.person.lasttName = (string)person["lastName"];
                    user.person.modifiedBy = (string)person["modifiedBy"];
                    user.person.modifyDate = Constants.HandleJtokenToDate(person["modifyDate"]);
                    user.person.createDate = Constants.HandleJtokenToDate(person["createDate"]);
                    user.person.userId = (string)person["userId"];
                }
                var roles = item["roles"];
                if(roles != null)
                {
                    List<RoleViewModel> roleViews = RoleViewModel.getRoles(roles);
                    user.roles = roleViews;
                }
                users.Add(user);
            }
            return users;
        }
    }

    public class PersonViewModel
    {
        public long id { get; set; }
        public List<AddressViewModel> address { get; set; }
        public DateTime birthDate { get; set; }
        public string birthDateString { get; set; }
        public string birthPlace { get; set; }
        public string carrer { get; set; }
        public DateTime communistPartyJoinDate { get; set; }
        public string communistPartyJoinDateString { get; set; }
        public DateTime communistYouthUnionJoinDate { get; set; }
        public string communistYouthUnionJoinDateString { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public string modifiedBy { get; set; }
        public string createIp { get; set; }
        public string createBy { get; set; }
        public string displayName { get; set; }
        public string email { get; set; }
        public DateTime endDate { get; set; }
        public string ethnics { get; set; }
        public string lasttName { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public string modifyIp { get; set; }
        public string nationality { get; set; }
        public string nativeVillage { get; set; }
        public string phoneNumber { get; set; }
        public string photo { get; set; }
        public string photoCropped { get; set; }
        public string religion { get; set; }
        public string shortName { get; set; }
        public DateTime startDate { get; set; }
        public string userId { get; set; }
    }

    public class AddressViewModel
    {

    }
}
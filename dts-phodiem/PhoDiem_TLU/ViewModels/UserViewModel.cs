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
        public string dob { get; set; }
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
                user.dob = (string)item["dob"];
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

       

        public static UserViewModel getUser(JToken input)
        {
            UserViewModel user = new UserViewModel();
            user.createDate = Constants.HandleJtokenToDate(input["createDate"]);
            user.active = (int)input["active"];
            user.changePass = (bool)input["changePass"];
            user.createBy = (string)input["createdBy"];
            user.displayName = (string)input["displayName"];
            user.email = (string)input["email"];
            user.id = (int)input["id"];
            user.modifiedBy = (string)input["modifiedBy"];
            user.modifyDate = Constants.HandleJtokenToDate(input["modifyDate"]);
            user.password = (string)input["password"];
            user.confirmPassword = (string)input["confirmPassword"];
            user.username = (string)input["username"];
            user.birthPlace = (string)input["birthPlace"];
            user.dob = (string)input["dob"];
            var person = input["person"];
            if(person.HasValues)
            {
                user.person.createDate = Constants.HandleJtokenToDate(person["createDate"]);
                user.person.email = (string)person["email"];
                user.person.createBy = (string)person["createBy"];
                user.person.displayName = (string)person["displayName"];
                user.person.firstName = (string)person["firstName"];
                user.person.gender = (string)person["gender"];
                user.person.id = (long)person["id"];
                user.person.lasttName = (string)person["lastName"];
                user.person.modifyDate = Constants.HandleJtokenToDate(person["modifyDate"]);
                user.person.userId = (string)person["userId"];
                user.person.phoneNumber = (string)person["phoneNumber"];
                user.person.phoneNumber = (string)person["idNumberIssueDate"];
                user.person.phoneNumber = (string)person["idNumberIssueBy"];
                user.person.phoneNumber = (string)person["idNumber"];
                user.person.phoneNumber = (string)person["birthDateString"];
                user.person.phoneNumber = (string)person["birthDate"];
                var address = person["address"];
                if(address.HasValues)
                {
                    AddressViewModel add = new AddressViewModel();
                    List<AddressViewModel> addresses = new List<AddressViewModel>();
                    foreach (var item in address)
                    {
                        add.address = (string)item["address"];
                        add.id = (long)item["id"];
                        add.personId = (long)item["personId"];
                        addresses.Add(add);
                    }
                    user.person.address = addresses;
                }
            }
            var roles = input["roles"];
            if(roles.HasValues)
            {
                List<RoleViewModel> roleViews = new List<RoleViewModel>();
                foreach (var item in roles)
                {
                    RoleViewModel r = new RoleViewModel();
                    r.authority = (string)item["authority"];
                    r.description = (string)item["description"];
                    r.id = (int)item["id"];
                    r.name = (string)item["name"];
                    roleViews.Add(r);
                }
                user.roles = roleViews.AsEnumerable();
            }
            return user;
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
        [DisplayName("Họ")]
        public string lasttName { get; set; }
        [DisplayName("Tên")]
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
        public long id { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string latitude { get; set; }
        public string longtitude { get; set; }
        public long personId { get; set; }
        public string type { get; set; }
        public long provinceId { get; set; }
        public long cityId { get; set; }
        public long villageId { get; set; }
    }
}
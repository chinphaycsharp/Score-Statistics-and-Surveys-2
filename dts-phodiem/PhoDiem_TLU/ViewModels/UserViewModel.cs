using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class UserViewModel
    {
        public long id { get; set; }
        public bool active { get; set; }
        public string birthPlace { get; set; }
        public bool changePass { get; set; }
        public string confirmPassword { get; set; }
        public DateTime createDate { get; set; }
        public string createBy { get; set; }
        public string displayName { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public IEnumerable<GroupViewModel> groups { get; set; }
        public bool hasPhoto { get; set; }
        public string lastName { get; set; }
        public string modifiedBy { get; set; }
        public DateTime modifyDate { get; set; }
        public string password { get; set; }
        public PersonViewModel person { get; set; }
        public long roleIds { get; set; }
        public IEnumerable<RoleViewModel> roles { get; set; }
        public bool setPassword { get; set; }
        public string username { get; set; }

        public UserViewModel()
        {
            person = new PersonViewModel();
        }
    }

    public class GroupViewModel
    {

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
        public string createIp { get; set; }
        public string createBy { get; set; }
        public string displayName { get; set; }
        public string email { get; set; }
        public DateTime endDate { get; set; }
        public string ethnics { get; set; }
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
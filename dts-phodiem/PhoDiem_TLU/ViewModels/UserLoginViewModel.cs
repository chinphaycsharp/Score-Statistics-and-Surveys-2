using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.Models
{
    public class UserLoginViewModel
    {
        public string client_id { get; set; }
        public string grant_type { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string client_secret { get; set; }
    }
}
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.Commons
{
    public class Constants
    {
        public static string ROLE_EXAM_MANAGERMENT = "ROLE_EXAM_MANAGERMENT";

        public static DateTime HandleJtokenToDate(JToken token)
        {
            var a = token.Children().ToList();
            if(a.Count > 0)
            {
                DateTime date = new DateTime(Convert.ToInt32(a[0]), Convert.ToInt32(a[1]), Convert.ToInt32(a[2]), Convert.ToInt32(a[3]), Convert.ToInt32(a[4]), Convert.ToInt32(a[5]));
                return date;
            }
            return new DateTime();
        }
    }
}
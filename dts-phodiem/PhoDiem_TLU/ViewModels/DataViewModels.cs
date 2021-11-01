using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class DataViewModels
    {
        public bool first { get; set; }
        public bool last { get; set; }
        public int number{ get; set; }
        public int numberOfElements { get; set; }
        public int size{ get; set; }
        public int totalElements{ get; set; }
        public int totalPages{ get; set; }

        public List<UserViewModel> content;
    }
}
namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StudentDocument2019
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [StringLength(1000)]
        public string DocName { get; set; }

        public int? Amount { get; set; }

        public bool? Gender { get; set; }

        public int? DisplayOrder { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string CreatedUser { get; set; }

        [StringLength(100)]
        public string ModifiedUser { get; set; }

        public byte? Status { get; set; }

        public bool? IsDeleted { get; set; }
    }
}

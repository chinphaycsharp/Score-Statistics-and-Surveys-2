namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_staff_civil_servant_grade
    {
        public long id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime create_date { get; set; }

        [Required]
        [StringLength(100)]
        public string created_by { get; set; }

        [StringLength(100)]
        public string modified_by { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modify_date { get; set; }

        [StringLength(255)]
        public string uuid_key { get; set; }

        public bool? voided { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? from_date { get; set; }

        public bool? is_current { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? to_date { get; set; }

        public long? civil_servant_category_grade_id { get; set; }

        public long? staff_id { get; set; }

        public virtual tbl_civil_servant_category_grade tbl_civil_servant_category_grade { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }
    }
}

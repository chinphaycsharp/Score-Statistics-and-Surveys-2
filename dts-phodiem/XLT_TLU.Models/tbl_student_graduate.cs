namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_graduate
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

        public bool? isEligible { get; set; }

        public int? status { get; set; }

        public long? education_program_id { get; set; }

        public long? graduation_period_id { get; set; }

        public long? student_id { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        public virtual tbl_graduation_period tbl_graduation_period { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

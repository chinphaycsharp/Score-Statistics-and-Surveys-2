namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_certificate
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
        public DateTime? date_of_signing_decisive { get; set; }

        public double? mark { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? number_of_decisive { get; set; }

        public long? certificate_id { get; set; }

        public long? classification_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public virtual tbl_certificate tbl_certificate { get; set; }

        public virtual tbl_classification tbl_classification { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

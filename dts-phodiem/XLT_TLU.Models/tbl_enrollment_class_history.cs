namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_enrollment_class_history
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
        public DateTime? dateModify { get; set; }

        [StringLength(255)]
        public string userModify { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? student_id { get; set; }

        [StringLength(255)]
        public string reason { get; set; }

        public long? enrollment_class_old_id { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class1 { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_study_alert_level_lower
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

        public bool? is_lowered { get; set; }

        public double? learning_mark4 { get; set; }

        public double? learning_mark4_semester { get; set; }

        public double? learning_mark_semester { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date_lowered { get; set; }

        public double? mark { get; set; }

        public double? mark4 { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? number_of_credit { get; set; }

        public int? number_of_credit_debt { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public long? student_study_alert_level_id { get; set; }

        public bool? is_delete { get; set; }

        public int? number_of_credit_semeste { get; set; }

        public int? study_alert_type { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_study_alert_level tbl_student_study_alert_level { get; set; }
    }
}

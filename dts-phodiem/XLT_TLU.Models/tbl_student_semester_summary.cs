namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_semester_summary
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

        public double? cumulative_mark { get; set; }

        public double? cumulative_mark_2_semester { get; set; }

        public double? cumulative_mark4 { get; set; }

        public double? cumulative_mark4_2_semester { get; set; }

        public double? cumulative_mark4_semester { get; set; }

        public double? cumulative_mark_semester { get; set; }

        public bool? is_not_complete_tuition_fee { get; set; }

        public double? learning_mark { get; set; }

        public double? learning_mark_2_semester { get; set; }

        public double? learning_mark4 { get; set; }

        public double? learning_mark4_2_semester { get; set; }

        public double? learning_mark_semester { get; set; }

        public int? number_cumulative_credit { get; set; }

        public int? number_cumulative_credit_2_semester { get; set; }

        public int? number_cumulative_credit_semester { get; set; }

        public int? total_incomplete_credit { get; set; }

        public int? total_learning_credit_2_semester { get; set; }

        public int? total_learning_credit_semester { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

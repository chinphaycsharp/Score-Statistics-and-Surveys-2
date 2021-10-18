namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_reward
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
        public DateTime? decision_date { get; set; }

        public int? first_sort_student_semester_behavior_mark { get; set; }

        public int? first_sort_student_semester_summary_mark { get; set; }

        public double? first_student_semester_behavior_mark { get; set; }

        public double? first_student_semester_summary_mark { get; set; }

        public bool? is_end_course_year { get; set; }

        public long? number_disciplined { get; set; }

        public long? number_rewarded { get; set; }

        [StringLength(255)]
        public string reason { get; set; }

        public int? second_sort_student_semester_behavior_mark { get; set; }

        public int? second_sort_student_semester_summary_mark { get; set; }

        public double? second_student_semester_behavior_mark { get; set; }

        public double? second_student_semester_summary_mark { get; set; }

        public int? sort_student_behavior_summary_mark { get; set; }

        public int? sort_student_school_year_behavior_mark { get; set; }

        public int? second_sort_student_school_year_summary_mark { get; set; }

        public int? sort_student_summary_mark { get; set; }

        public int? status { get; set; }

        public double? student_behavior_summary_mark { get; set; }

        public double? student_school_year_behavior_mark { get; set; }

        public double? student_school_year_summary_mark { get; set; }

        public double? student_summary_mark { get; set; }

        public long? reward_id { get; set; }

        public long? reward_decree_id { get; set; }

        public long? school_year_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public long? student_reward_condition { get; set; }

        public bool? is_lock { get; set; }

        public virtual tbl_reward tbl_reward { get; set; }

        public virtual tbl_reward_decree tbl_reward_decree { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_reward_condition tbl_student_reward_condition { get; set; }
    }
}

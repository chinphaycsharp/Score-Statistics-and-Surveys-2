namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_behavior_criteria_mark
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

        public double? mark { get; set; }

        public long? behavior_mark_criteria_id { get; set; }

        public long? student_semester_behavior_mark_id { get; set; }

        public double? mark_department_managerment { get; set; }

        public double? mark_student_managerment { get; set; }

        public double? mark_teacher { get; set; }

        public long? behavior_mark_criteria { get; set; }

        public virtual tbl_behavior_mark_criteria tbl_behavior_mark_criteria { get; set; }

        public virtual tbl_behavior_mark_criteria tbl_behavior_mark_criteria1 { get; set; }

        public virtual tbl_student_semester_behavior_mark tbl_student_semester_behavior_mark { get; set; }
    }
}

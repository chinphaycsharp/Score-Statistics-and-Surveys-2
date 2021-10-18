namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_mark
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

        public double? coeffiecient { get; set; }

        public int? exam_round { get; set; }

        public bool? is_lock { get; set; }

        public bool? is_updated { get; set; }

        public double? mark { get; set; }

        public int? mark_status { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public double? old_mark { get; set; }

        public double? original_mark { get; set; }

        public int? update_type { get; set; }

        public long? mark_type_id { get; set; }

        public long? semester_subject_id { get; set; }

        public long? special_point { get; set; }

        public long? student_id { get; set; }

        public long? student_course_subject_id { get; set; }

        public long? student_exam_room_id { get; set; }

        public long? student_subject_mark_id { get; set; }

        public long? subject_id { get; set; }

        public long? subject_exam_id { get; set; }

        public int? exam_status { get; set; }

        public int? subject_status { get; set; }

        public virtual tbl_mark_type tbl_mark_type { get; set; }

        public virtual tbl_semester_subject tbl_semester_subject { get; set; }

        public virtual tbl_special_point tbl_special_point { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_course_subject tbl_student_course_subject { get; set; }

        public virtual tbl_subject_exam tbl_subject_exam { get; set; }

        public virtual tbl_student_semester_subject_exam_room tbl_student_semester_subject_exam_room { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }

        public virtual tbl_student_subject_mark tbl_student_subject_mark { get; set; }
    }
}

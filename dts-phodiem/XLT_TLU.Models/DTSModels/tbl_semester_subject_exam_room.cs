namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_semester_subject_exam_room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_semester_subject_exam_room()
        {
            tbl_student_semester_subject_exam_room = new HashSet<tbl_student_semester_subject_exam_room>();
        }

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

        public int duration { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? examDate { get; set; }

        public bool? is_added_full_to_test_bag { get; set; }

        public bool? is_added_to_test_bag { get; set; }

        public int? number_expected_student { get; set; }

        public int? number_student { get; set; }

        [StringLength(255)]
        public string roomCode { get; set; }

        public long? end_hour_id { get; set; }

        public long? exam_hour_id { get; set; }

        public long? exam_skill_id { get; set; }

        public long? room_id { get; set; }

        public long? semester_subject_exam_id { get; set; }

        public long? start_hour_id { get; set; }

        public long? training_base_id { get; set; }

        public long? subject_exam_hour_id { get; set; }

        public int? viewOrder { get; set; }

        public int? view_order { get; set; }

        public virtual tbl_course_hour tbl_course_hour { get; set; }

        public virtual tbl_course_hour tbl_course_hour1 { get; set; }

        public virtual tbl_exam_hour tbl_exam_hour { get; set; }

        public virtual tbl_exam_skill tbl_exam_skill { get; set; }

        public virtual tbl_room tbl_room { get; set; }

        public virtual tbl_semester_subject_exam tbl_semester_subject_exam { get; set; }

        public virtual tbl_semester_subject_exam_hour tbl_semester_subject_exam_hour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_subject_exam_room> tbl_student_semester_subject_exam_room { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }
    }
}

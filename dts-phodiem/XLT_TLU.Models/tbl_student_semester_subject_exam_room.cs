namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_semester_subject_exam_room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_semester_subject_exam_room()
        {
            tbl_student_mark = new HashSet<tbl_student_mark>();
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

        [StringLength(255)]
        public string examCode { get; set; }

        public bool? isExempt { get; set; }

        [StringLength(255)]
        public string markingCode { get; set; }

        public int? status { get; set; }

        public long? semester_subject_exam_room_id { get; set; }

        public long? exam_status_id { get; set; }

        public long? special_point_id { get; set; }

        public long? student_id { get; set; }

        public long? student_course_subject_id { get; set; }

        public long? test_bag_id { get; set; }

        public bool? is_arranged_room { get; set; }

        public long? student_exam_id { get; set; }

        public virtual tbl_exam_status tbl_exam_status { get; set; }

        public virtual tbl_semester_subject_exam_room tbl_semester_subject_exam_room { get; set; }

        public virtual tbl_special_point tbl_special_point { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_course_subject tbl_student_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }

        public virtual tbl_test_bag tbl_test_bag { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_subject_exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_subject_exam()
        {
            tbl_course_subject_subject_exam_formula = new HashSet<tbl_course_subject_subject_exam_formula>();
            tbl_student_mark = new HashSet<tbl_student_mark>();
            tbl_subject_exam1 = new HashSet<tbl_subject_exam>();
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
        public string code { get; set; }

        public double? coefficient { get; set; }

        public int? exam_type { get; set; }

        public int? input_mark_type { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public long? parent_id { get; set; }

        public long? program_subject_id { get; set; }

        public long? semester_subject_id { get; set; }

        public long? subject_id { get; set; }

        public long? course_subject_id { get; set; }

        public long? subject_exam_type_id { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_subject_exam_formula> tbl_course_subject_subject_exam_formula { get; set; }

        public virtual tbl_program_subject tbl_program_subject { get; set; }

        public virtual tbl_semester_subject tbl_semester_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_exam> tbl_subject_exam1 { get; set; }

        public virtual tbl_subject_exam tbl_subject_exam2 { get; set; }

        public virtual tbl_subject_exam_type tbl_subject_exam_type { get; set; }
    }
}

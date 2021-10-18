namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_semester_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_semester_subject()
        {
            tbl_course_subject = new HashSet<tbl_course_subject>();
            tbl_course_subject_subject_exam_formula = new HashSet<tbl_course_subject_subject_exam_formula>();
            tbl_semester_subject_learning_skill = new HashSet<tbl_semester_subject_learning_skill>();
            tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
            tbl_training_base_semester_subject = new HashSet<tbl_training_base_semester_subject>();
            tbl_subject_exam = new HashSet<tbl_subject_exam>();
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

        public int? child_course_type { get; set; }

        public bool? is_fee_by_subject { get; set; }

        public int? max_number_student_child_course { get; set; }

        public int? max_number_student_parent_course { get; set; }

        public int? min_number_student_child_course { get; set; }

        public int? min_number_student_parent_course { get; set; }

        public int? number_child_by_parent { get; set; }

        public int? number_course { get; set; }

        public double? numberMainSkillHours { get; set; }

        public int? parent_course_type { get; set; }

        public double? remuneration_coefficient { get; set; }

        public double? remuneration_fee { get; set; }

        public double? totalNumberHours { get; set; }

        public double? tuition_fee { get; set; }

        public double? tuition_fee_coefficient { get; set; }

        public bool? useByCourseYear { get; set; }

        public long? course_year_id { get; set; }

        public long? main_learning_skill_id { get; set; }

        public long? register_period_id { get; set; }

        public long? semester_id { get; set; }

        public long? sub_semester_id { get; set; }

        public long? subject_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject> tbl_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_subject_exam_formula> tbl_course_subject_subject_exam_formula { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_learning_skill tbl_learning_skill { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_semester tbl_semester1 { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_learning_skill> tbl_semester_subject_learning_skill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_training_base_semester_subject> tbl_training_base_semester_subject { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_exam> tbl_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }
    }
}

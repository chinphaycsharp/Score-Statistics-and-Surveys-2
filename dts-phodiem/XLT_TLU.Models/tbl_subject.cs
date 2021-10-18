namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_subject()
        {
            tbl_criteria_search_student_except_subject = new HashSet<tbl_criteria_search_student_except_subject>();
            tbl_equivalent_subject = new HashSet<tbl_equivalent_subject>();
            tbl_expectation_register = new HashSet<tbl_expectation_register>();
            tbl_prerequisite_subject = new HashSet<tbl_prerequisite_subject>();
            tbl_program_subject = new HashSet<tbl_program_subject>();
            tbl_semester_subject = new HashSet<tbl_semester_subject>();
            tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
            tbl_student_mark = new HashSet<tbl_student_mark>();
            tbl_student_subject_mark = new HashSet<tbl_student_subject_mark>();
            tbl_subject_education_level_type = new HashSet<tbl_subject_education_level_type>();
            tbl_subject_exam = new HashSet<tbl_subject_exam>();
            tbl_subject_learning_skill = new HashSet<tbl_subject_learning_skill>();
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

        public int? examTime { get; set; }

        public bool? is_calculate_mark { get; set; }

        public bool? is_currently_using { get; set; }

        public int? number_of_credit { get; set; }

        [StringLength(255)]
        public string subject_code { get; set; }

        [StringLength(255)]
        public string subject_name { get; set; }

        [StringLength(255)]
        public string subject_name_eng { get; set; }

        public int? subject_type { get; set; }

        public long? department_id { get; set; }

        public long? exam_skill_id { get; set; }

        [StringLength(255)]
        public string define_code { get; set; }

        public int? fee_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_criteria_search_student_except_subject> tbl_criteria_search_student_except_subject { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_equivalent_subject> tbl_equivalent_subject { get; set; }

        public virtual tbl_exam_skill tbl_exam_skill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_expectation_register> tbl_expectation_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_prerequisite_subject> tbl_prerequisite_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_program_subject> tbl_program_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject> tbl_semester_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_subject_mark> tbl_student_subject_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_education_level_type> tbl_subject_education_level_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_exam> tbl_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_learning_skill> tbl_subject_learning_skill { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_semester_subject_exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_semester_subject_exam()
        {
            tbl_semester_subject_exam_room = new HashSet<tbl_semester_subject_exam_room>();
            tbl_student_fee_calculate = new HashSet<tbl_student_fee_calculate>();
            tbl_training_base_semester_subject_exam = new HashSet<tbl_training_base_semester_subject_exam>();
            tbl_semester_subject_exam_date = new HashSet<tbl_semester_subject_exam_date>();
            tbl_testBag_create_time = new HashSet<tbl_testBag_create_time>();
            tbl_test_bag = new HashSet<tbl_test_bag>();
            tbl_semester_subject_exam_course_subject = new HashSet<tbl_semester_subject_exam_course_subject>();
            tbl_student_semester_subject_exam = new HashSet<tbl_student_semester_subject_exam>();
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
        public string description { get; set; }

        public int? exam_round { get; set; }

        public int? number_estimate_student { get; set; }

        public int? number_room { get; set; }

        public int? number_student { get; set; }

        public long? course_year_id { get; set; }

        public long? exam_register_period_id { get; set; }

        public long? register_period_id { get; set; }

        public long? semester_id { get; set; }

        public long? subject_id { get; set; }

        public long? semester_exam_period_id { get; set; }

        public long? semester_subject_id { get; set; }

        public long? exam_type_id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_exam_register_period tbl_exam_register_period { get; set; }

        public virtual tbl_exam_type tbl_exam_type { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        public virtual tbl_semester_subject tbl_semester_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_room> tbl_semester_subject_exam_room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_fee_calculate> tbl_student_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_training_base_semester_subject_exam> tbl_training_base_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_date> tbl_semester_subject_exam_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_testBag_create_time> tbl_testBag_create_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_test_bag> tbl_test_bag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_course_subject> tbl_semester_subject_exam_course_subject { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_subject_exam> tbl_student_semester_subject_exam { get; set; }
    }
}

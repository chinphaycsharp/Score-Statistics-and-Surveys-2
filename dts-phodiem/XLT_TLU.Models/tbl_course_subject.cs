namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_course_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_course_subject()
        {
            tbl_student_course_subject_cancel_fee = new HashSet<tbl_student_course_subject_cancel_fee>();
            tbl_semester_subject_exam_course_subject = new HashSet<tbl_semester_subject_exam_course_subject>();
            tbl_course_subject1 = new HashSet<tbl_course_subject>();
            tbl_student_tuition_fee_calculate_detail = new HashSet<tbl_student_tuition_fee_calculate_detail>();
            tbl_course_subject_config = new HashSet<tbl_course_subject_config>();
            tbl_student_course_subject = new HashSet<tbl_student_course_subject>();
            tbl_subject_exam = new HashSet<tbl_subject_exam>();
            tbl_timetable_detail = new HashSet<tbl_timetable_detail>();
            tbl_student_fee_calculate = new HashSet<tbl_student_fee_calculate>();
            tbl_transfer_schedule_history = new HashSet<tbl_transfer_schedule_history>();
            //tbl_course_subject_tbl_course_subject_timetable = new HashSet<tbl_course_subject_tbl_course_subject_timetable>();
            tbl_course_subject_subject_exam_formula = new HashSet<tbl_course_subject_subject_exam_formula>();
            tbl_student_course_subject_history = new HashSet<tbl_student_course_subject_history>();
            tbl_course_subject_timetable = new HashSet<tbl_course_subject_timetable>();
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

        public int courseSubjectType { get; set; }

        public double? fee_per_credit { get; set; }

        public double? fee_per_student { get; set; }

        public bool? is_denied_all { get; set; }

        public bool? is_fee_by_course_subject { get; set; }

        public bool? is_grant_all { get; set; }

        public bool? is_using_config { get; set; }

        public int? max_student { get; set; }

        public double? min_fee { get; set; }

        public int? min_student { get; set; }

        public double? number_hours { get; set; }

        public int numberStudent { get; set; }

        [StringLength(255)]
        public string short_code { get; set; }

        public double? total_fee { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? learning_skill_id { get; set; }

        public long? parent_id { get; set; }

        public long? semester_subject_id { get; set; }

        public long? teacher_id { get; set; }

        public long? training_base_id { get; set; }

        public long? semester_exam_period_id { get; set; }

        [StringLength(255)]
        public string display_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        public int? learning_method { get; set; }

        public int? status { get; set; }

        public double? tuition_coefficient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_course_subject> tbl_semester_subject_exam_course_subject { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }

        public virtual tbl_semester_exam_period tbl_semester_exam_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject> tbl_course_subject1 { get; set; }

        public virtual tbl_course_subject tbl_course_subject2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate_detail> tbl_student_tuition_fee_calculate_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_config> tbl_course_subject_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject> tbl_student_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_exam> tbl_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_timetable_detail> tbl_timetable_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_fee_calculate> tbl_student_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_transfer_schedule_history> tbl_transfer_schedule_history { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<tbl_course_subject_tbl_course_subject_timetable> tbl_course_subject_tbl_course_subject_timetable { get; set; }

        public virtual tbl_semester_subject tbl_semester_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_subject_exam_formula> tbl_course_subject_subject_exam_formula { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_history> tbl_student_course_subject_history { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_learning_skill tbl_learning_skill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_timetable> tbl_course_subject_timetable { get; set; }
    }
}

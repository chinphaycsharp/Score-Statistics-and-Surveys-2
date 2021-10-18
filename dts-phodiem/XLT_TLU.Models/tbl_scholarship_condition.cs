namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_scholarship_condition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_scholarship_condition()
        {
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
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

        public double? amount { get; set; }

        public double? behaviour_mark { get; set; }

        [StringLength(255)]
        public string behaviour_mark_compare { get; set; }

        public double? certificate_mark10 { get; set; }

        public double? certificate_mark4 { get; set; }

        public double? certificate_mark_char { get; set; }

        [StringLength(255)]
        public string certificate_mark_compare { get; set; }

        public bool? check_full_school_year_mark { get; set; }

        public bool? check_full_year_certificate_mark { get; set; }

        public bool? check_full_year_min_mark { get; set; }

        public bool? check_full_year_number_subject_failed { get; set; }

        public bool? check_pre_year_mark { get; set; }

        public bool? check_subject_not_counted { get; set; }

        public bool? check_subject_not_counted_min_mark { get; set; }

        public bool? check_subject_not_mark { get; set; }

        public bool? check_subject_not_mark_register { get; set; }

        public bool? check_time { get; set; }

        public bool? check_year_mark { get; set; }

        public int? level { get; set; }

        public double? mark10 { get; set; }

        public double? mark4 { get; set; }

        public double? mark_char { get; set; }

        [StringLength(255)]
        public string mark_compare { get; set; }

        public double? mark_extend { get; set; }

        [StringLength(255)]
        public string mark_extend_compare { get; set; }

        public double? min_mark10 { get; set; }

        public double? min_mark4 { get; set; }

        public double? min_mark_char { get; set; }

        [StringLength(255)]
        public string min_mark_compare { get; set; }

        public int? number_credit_pre_semester { get; set; }

        [StringLength(255)]
        public string number_credit_pre_semester_compare { get; set; }

        public int? number_credit_register { get; set; }

        [StringLength(255)]
        public string number_credit_register_compare { get; set; }

        public int? number_credit_semester { get; set; }

        [StringLength(255)]
        public string number_credit_semester_compare { get; set; }

        public int? number_credit_to_semester { get; set; }

        [StringLength(255)]
        public string number_credit_to_semester_compare { get; set; }

        public int? number_subject_failed { get; set; }

        [StringLength(255)]
        public string number_subject_failed_compare { get; set; }

        public int? number_subject_not_exam { get; set; }

        [StringLength(255)]
        public string number_subject_not_exam_compare { get; set; }

        [StringLength(255)]
        public string student_object_compare { get; set; }

        [StringLength(255)]
        public string student_object_semester_compare { get; set; }

        public long? course_year_id { get; set; }

        public long? discipline_id { get; set; }

        public long? class_id { get; set; }

        public long? scholarship_fund_id { get; set; }

        public long? semester_id { get; set; }

        public long? speciality_id { get; set; }

        public long? student_object_id { get; set; }

        public long? student_object_semester_id { get; set; }

        public double? amount_number_of_credit { get; set; }

        public long? department_id { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        public virtual tbl_discipline tbl_discipline { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_scholarship_fund tbl_scholarship_fund { get; set; }

        public virtual tbl_student_object tbl_student_object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        public virtual tbl_student_object tbl_student_object1 { get; set; }
    }
}

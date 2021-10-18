namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_course_year
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_course_year()
        {
            tbl_behavior_mark_classification_standard = new HashSet<tbl_behavior_mark_classification_standard>();
            tbl_behavior_mark_criteria = new HashSet<tbl_behavior_mark_criteria>();
            tbl_budget_distribution = new HashSet<tbl_budget_distribution>();
            tbl_course_subject_config = new HashSet<tbl_course_subject_config>();
            tbl_education_program_tuition_fee = new HashSet<tbl_education_program_tuition_fee>();
            tbl_receive_pay_able = new HashSet<tbl_receive_pay_able>();
            tbl_education_program_number_of_credit = new HashSet<tbl_education_program_number_of_credit>();
            tbl_study_alert_condition = new HashSet<tbl_study_alert_condition>();
            tbl_student_candidate_profile = new HashSet<tbl_student_candidate_profile>();
            tbl_criteria_search_student = new HashSet<tbl_criteria_search_student>();
            tbl_specialty_admissions_map = new HashSet<tbl_specialty_admissions_map>();
            tbl_enrollment_class = new HashSet<tbl_enrollment_class>();
            tbl_education_voucher = new HashSet<tbl_education_voucher>();
            tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
            tbl_education_program = new HashSet<tbl_education_program>();
            tbl_scholarship_condition = new HashSet<tbl_scholarship_condition>();
            tbl_semester_subject = new HashSet<tbl_semester_subject>();
            tbl_school_fee_config = new HashSet<tbl_school_fee_config>();
            tbl_student_object_subsidize = new HashSet<tbl_student_object_subsidize>();
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
            tbl_education_fee_config = new HashSet<tbl_education_fee_config>();
            tbl_discount_tuition_fee = new HashSet<tbl_discount_tuition_fee>();
            tbl_student_reward_condition = new HashSet<tbl_student_reward_condition>();
            tbl_expectation_register = new HashSet<tbl_expectation_register>();
            tbl_enrollment_class_reward_condition = new HashSet<tbl_enrollment_class_reward_condition>();
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

        [StringLength(255)]
        public string name { get; set; }

        public int? year { get; set; }

        public long? education_level_id { get; set; }

        public long? education_type_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_behavior_mark_classification_standard> tbl_behavior_mark_classification_standard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_behavior_mark_criteria> tbl_behavior_mark_criteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_budget_distribution> tbl_budget_distribution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_config> tbl_course_subject_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_number_of_credit> tbl_education_program_number_of_credit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_condition> tbl_study_alert_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_candidate_profile> tbl_student_candidate_profile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_criteria_search_student> tbl_criteria_search_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_specialty_admissions_map> tbl_specialty_admissions_map { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class> tbl_enrollment_class { get; set; }

        public virtual tbl_education_level tbl_education_level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher> tbl_education_voucher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program> tbl_education_program { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_scholarship_condition> tbl_scholarship_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject> tbl_semester_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_school_fee_config> tbl_school_fee_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_subsidize> tbl_student_object_subsidize { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_fee_config> tbl_education_fee_config { get; set; }

        public virtual tbl_education_type tbl_education_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_discount_tuition_fee> tbl_discount_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reward_condition> tbl_student_reward_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_expectation_register> tbl_expectation_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_reward_condition> tbl_enrollment_class_reward_condition { get; set; }
    }
}

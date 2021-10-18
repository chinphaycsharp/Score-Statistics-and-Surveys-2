namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_enrollment_class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_enrollment_class()
        {
            tbl_budget_distribution = new HashSet<tbl_budget_distribution>();
            tbl_course_subject = new HashSet<tbl_course_subject>();
            tbl_course_subject_config = new HashSet<tbl_course_subject_config>();
            tbl_education_program_number_of_credit = new HashSet<tbl_education_program_number_of_credit>();
            tbl_education_program_tuition_fee = new HashSet<tbl_education_program_tuition_fee>();
            tbl_education_voucher = new HashSet<tbl_education_voucher>();
            tbl_enrollment_class_history = new HashSet<tbl_enrollment_class_history>();
            tbl_student_candidate_profile = new HashSet<tbl_student_candidate_profile>();
            tbl_receive_pay_able = new HashSet<tbl_receive_pay_able>();
            tbl_register_period_time_config = new HashSet<tbl_register_period_time_config>();
            tbl_enrollment_class_reward = new HashSet<tbl_enrollment_class_reward>();
            tbl_student = new HashSet<tbl_student>();
            tbl_enrollment_class_history1 = new HashSet<tbl_enrollment_class_history>();
            tbl_scholarship_condition = new HashSet<tbl_scholarship_condition>();
            tbl_role_tution_enrollment_class = new HashSet<tbl_role_tution_enrollment_class>();
            tbl_enrollment_class_staff = new HashSet<tbl_enrollment_class_staff>();
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
            tbl_study_alert_condition = new HashSet<tbl_study_alert_condition>();
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
        public string classCode { get; set; }

        [StringLength(255)]
        public string className { get; set; }

        public long? number_of_student { get; set; }

        public int? schoolYear { get; set; }

        public long? course_year_id { get; set; }

        public long? department_id { get; set; }

        public long? education_id { get; set; }

        public long? speciality_id { get; set; }

        public long? staff_id { get; set; }

        public long? training_base_id { get; set; }

        public long? program_id { get; set; }

        public long? numberOfStudent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_budget_distribution> tbl_budget_distribution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject> tbl_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_config> tbl_course_subject_config { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        public virtual tbl_education_level tbl_education_level { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_number_of_credit> tbl_education_program_number_of_credit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher> tbl_education_voucher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_history> tbl_enrollment_class_history { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_candidate_profile> tbl_student_candidate_profile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_register_period_time_config> tbl_register_period_time_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_reward> tbl_enrollment_class_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student> tbl_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_history> tbl_enrollment_class_history1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_scholarship_condition> tbl_scholarship_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_role_tution_enrollment_class> tbl_role_tution_enrollment_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_staff> tbl_enrollment_class_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_condition> tbl_study_alert_condition { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_semester
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_semester()
        {
            tbl_behavior_mark_classification_standard = new HashSet<tbl_behavior_mark_classification_standard>();
            tbl_behavior_mark_criteria = new HashSet<tbl_behavior_mark_criteria>();
            tbl_budget_distribution = new HashSet<tbl_budget_distribution>();
            tbl_decision = new HashSet<tbl_decision>();
            tbl_discount_tuition_fee = new HashSet<tbl_discount_tuition_fee>();
            tbl_education_fee_config = new HashSet<tbl_education_fee_config>();
            tbl_education_program_number_of_credit = new HashSet<tbl_education_program_number_of_credit>();
            tbl_education_program_tuition_fee = new HashSet<tbl_education_program_tuition_fee>();
            tbl_education_voucher = new HashSet<tbl_education_voucher>();
            tbl_enrollment_class_reward = new HashSet<tbl_enrollment_class_reward>();
            tbl_exam_register_period = new HashSet<tbl_exam_register_period>();
            tbl_expectation_register = new HashSet<tbl_expectation_register>();
            tbl_expectation_register1 = new HashSet<tbl_expectation_register>();
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
            tbl_program_subject_semester = new HashSet<tbl_program_subject_semester>();
            tbl_receive_pay_able = new HashSet<tbl_receive_pay_able>();
            tbl_scholarship_condition = new HashSet<tbl_scholarship_condition>();
            tbl_student_discipline = new HashSet<tbl_student_discipline>();
            tbl_student_certificate = new HashSet<tbl_student_certificate>();
            tbl_student_research = new HashSet<tbl_student_research>();
            tbl_student_fee_calculate = new HashSet<tbl_student_fee_calculate>();
            tbl_student_not_complete_fee_semester = new HashSet<tbl_student_not_complete_fee_semester>();
            tbl_student_decision = new HashSet<tbl_student_decision>();
            tbl_student_discipline1 = new HashSet<tbl_student_discipline>();
            tbl_student_object_student_semester = new HashSet<tbl_student_object_student_semester>();
            tbl_student_object_subsidize = new HashSet<tbl_student_object_subsidize>();
            tbl_student_reward = new HashSet<tbl_student_reward>();
            tbl_semester_subject = new HashSet<tbl_semester_subject>();
            tbl_student_course_subject_edited = new HashSet<tbl_student_course_subject_edited>();
            tbl_student_semester_summary_mark = new HashSet<tbl_student_semester_summary_mark>();
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
            tbl_student_semester_behavior_mark = new HashSet<tbl_student_semester_behavior_mark>();
            tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
            tbl_student_decision1 = new HashSet<tbl_student_decision>();
            tbl_student_scholarship_stock = new HashSet<tbl_student_scholarship_stock>();
            tbl_student_status_student_semester = new HashSet<tbl_student_status_student_semester>();
            tbl_semester1 = new HashSet<tbl_semester>();
            tbl_semester_register_period = new HashSet<tbl_semester_register_period>();
            tbl_study_alert_condition = new HashSet<tbl_study_alert_condition>();
            tbl_student_tuition_fee_calculate = new HashSet<tbl_student_tuition_fee_calculate>();
            tbl_student_semester_summary = new HashSet<tbl_student_semester_summary>();
            tbl_student_subject_mark = new HashSet<tbl_student_subject_mark>();
            tbl_student_process_assessment_point = new HashSet<tbl_student_process_assessment_point>();
            tbl_student_study_alert_level = new HashSet<tbl_student_study_alert_level>();
            tbl_semester11 = new HashSet<tbl_semester>();
            tbl_student_study_alert_level_lower = new HashSet<tbl_student_study_alert_level_lower>();
            tbl_student_register_change = new HashSet<tbl_student_register_change>();
            tbl_semester_subject1 = new HashSet<tbl_semester_subject>();
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

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_register_date { get; set; }

        public bool? is_current { get; set; }

        public bool? is_lock_register { get; set; }

        public int? ordinal_numbers { get; set; }

        [StringLength(255)]
        public string semester_code { get; set; }

        [StringLength(255)]
        public string semester_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_register_date { get; set; }

        public double? tuition_fee_per_credit { get; set; }

        public int? year { get; set; }

        public int? fromWeek { get; set; }

        public int? toWeek { get; set; }

        public long? parent_id { get; set; }

        public long? school_year_id { get; set; }

        public long? semester_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? behavior_mark_end { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? behavior_mark_start { get; set; }

        public int? type_mark_recognition { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? education_end { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? education_start { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? student_end { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? student_start { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_behavior_mark_classification_standard> tbl_behavior_mark_classification_standard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_behavior_mark_criteria> tbl_behavior_mark_criteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_budget_distribution> tbl_budget_distribution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_decision> tbl_decision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_discount_tuition_fee> tbl_discount_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_fee_config> tbl_education_fee_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_number_of_credit> tbl_education_program_number_of_credit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher> tbl_education_voucher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_reward> tbl_enrollment_class_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_exam_register_period> tbl_exam_register_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_expectation_register> tbl_expectation_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_expectation_register> tbl_expectation_register1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_program_subject_semester> tbl_program_subject_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_scholarship_condition> tbl_scholarship_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_discipline> tbl_student_discipline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_certificate> tbl_student_certificate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_research> tbl_student_research { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_fee_calculate> tbl_student_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_not_complete_fee_semester> tbl_student_not_complete_fee_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_decision> tbl_student_decision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_discipline> tbl_student_discipline1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_student_semester> tbl_student_object_student_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_subsidize> tbl_student_object_subsidize { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reward> tbl_student_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject> tbl_semester_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_edited> tbl_student_course_subject_edited { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_summary_mark> tbl_student_semester_summary_mark { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_behavior_mark> tbl_student_semester_behavior_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_decision> tbl_student_decision1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_stock> tbl_student_scholarship_stock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_status_student_semester> tbl_student_status_student_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester> tbl_semester1 { get; set; }

        public virtual tbl_semester tbl_semester2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_register_period> tbl_semester_register_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_condition> tbl_study_alert_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_summary> tbl_student_semester_summary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_subject_mark> tbl_student_subject_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_process_assessment_point> tbl_student_process_assessment_point { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_study_alert_level> tbl_student_study_alert_level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester> tbl_semester11 { get; set; }

        public virtual tbl_semester tbl_semester3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_study_alert_level_lower> tbl_student_study_alert_level_lower { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_register_change> tbl_student_register_change { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject> tbl_semester_subject1 { get; set; }
    }
}

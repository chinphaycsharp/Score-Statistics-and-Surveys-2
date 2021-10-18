namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student()
        {
            tbl__student_student_group = new HashSet<tbl__student_student_group>();
            tbl_education_voucher = new HashSet<tbl_education_voucher>();
            tbl_enrollment_class_history = new HashSet<tbl_enrollment_class_history>();
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
            tbl_receive_pay_able = new HashSet<tbl_receive_pay_able>();
            tbl_student_fee_calculate = new HashSet<tbl_student_fee_calculate>();
            tbl_student_school_year_summary_mark = new HashSet<tbl_student_school_year_summary_mark>();
            tbl_student_subject_mark = new HashSet<tbl_student_subject_mark>();
            tbl_student_expectation_register = new HashSet<tbl_student_expectation_register>();
            tbl_student_study_alert_level_lower = new HashSet<tbl_student_study_alert_level_lower>();
            tbl_student_graduate_conditional = new HashSet<tbl_student_graduate_conditional>();
            tbl_student_not_complete_fee_semester = new HashSet<tbl_student_not_complete_fee_semester>();
            tbl_student_course_subject_edited = new HashSet<tbl_student_course_subject_edited>();
            tbl_student_study_alert_level = new HashSet<tbl_student_study_alert_level>();
            tbl_student_course_subject_history = new HashSet<tbl_student_course_subject_history>();
            tbl_student_discipline = new HashSet<tbl_student_discipline>();
            tbl_student_research = new HashSet<tbl_student_research>();
            tbl_student_scholarship_stock = new HashSet<tbl_student_scholarship_stock>();
            tbl_student_object_student = new HashSet<tbl_student_object_student>();
            tbl_student_object_subsidize_semester = new HashSet<tbl_student_object_subsidize_semester>();
            tbl_student_semester_summary = new HashSet<tbl_student_semester_summary>();
            tbl_student_tuition_fee_calculate = new HashSet<tbl_student_tuition_fee_calculate>();
            tbl_student_status_student_semester = new HashSet<tbl_student_status_student_semester>();
            tbl_student_semester_behavior_mark = new HashSet<tbl_student_semester_behavior_mark>();
            tbl_student_decision = new HashSet<tbl_student_decision>();
            tbl_student_reward = new HashSet<tbl_student_reward>();
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
            tbl_student_semester_subject_exam_room = new HashSet<tbl_student_semester_subject_exam_room>();
            tbl_student_graduate = new HashSet<tbl_student_graduate>();
            tbl_student_summary_mark = new HashSet<tbl_student_summary_mark>();
            tbl_student_semester_subject_exam = new HashSet<tbl_student_semester_subject_exam>();
            tbl_student_mark = new HashSet<tbl_student_mark>();
            tbl_student_student_private_document = new HashSet<tbl_student_student_private_document>();
            tbl_student_call_roll = new HashSet<tbl_student_call_roll>();
            tbl_student_education_program = new HashSet<tbl_student_education_program>();
            tbl_student_register_change = new HashSet<tbl_student_register_change>();
            tbl_student_candidate_profile1 = new HashSet<tbl_student_candidate_profile>();
            tbl_student_course_subject = new HashSet<tbl_student_course_subject>();
            tbl_student_semester_summary_mark = new HashSet<tbl_student_semester_summary_mark>();
            tbl_student_process_assessment_point = new HashSet<tbl_student_process_assessment_point>();
            tbl_student_object_student_semester = new HashSet<tbl_student_object_student_semester>();
            tbl_student_certificate = new HashSet<tbl_student_certificate>();
            tbl_student_course_subject_cancel_fee = new HashSet<tbl_student_course_subject_cancel_fee>();
        }

        [StringLength(255)]
        public string bank_account { get; set; }

        [StringLength(255)]
        public string bank_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? father_birth_date { get; set; }

        [StringLength(255)]
        public string father_full_name { get; set; }

        public int? high_school_graduation_year { get; set; }

        public bool? is_boarder { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? mother_birth_date { get; set; }

        [StringLength(255)]
        public string mother_full_name { get; set; }

        public int? status { get; set; }

        [StringLength(255)]
        public string student_code { get; set; }

        public int? year_of_admission { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? candidate_profile_id { get; set; }

        public long? class_id { get; set; }

        public long? father_profession_id { get; set; }

        public long? mother_profession_id { get; set; }

        [StringLength(255)]
        public string father_phone_number { get; set; }

        [StringLength(255)]
        public string mother_phone_number { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public long? status_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl__student_student_group> tbl__student_student_group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher> tbl_education_voucher { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_history> tbl_enrollment_class_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        public virtual tbl_profession tbl_profession { get; set; }

        public virtual tbl_profession tbl_profession1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }

        public virtual tbl_status tbl_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_fee_calculate> tbl_student_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_school_year_summary_mark> tbl_student_school_year_summary_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_subject_mark> tbl_student_subject_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_expectation_register> tbl_student_expectation_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_study_alert_level_lower> tbl_student_study_alert_level_lower { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_graduate_conditional> tbl_student_graduate_conditional { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_not_complete_fee_semester> tbl_student_not_complete_fee_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_edited> tbl_student_course_subject_edited { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_study_alert_level> tbl_student_study_alert_level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_history> tbl_student_course_subject_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_discipline> tbl_student_discipline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_research> tbl_student_research { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_stock> tbl_student_scholarship_stock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_student> tbl_student_object_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_subsidize_semester> tbl_student_object_subsidize_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_summary> tbl_student_semester_summary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_status_student_semester> tbl_student_status_student_semester { get; set; }

        public virtual tbl_student_candidate_profile tbl_student_candidate_profile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_behavior_mark> tbl_student_semester_behavior_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_decision> tbl_student_decision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reward> tbl_student_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_subject_exam_room> tbl_student_semester_subject_exam_room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_graduate> tbl_student_graduate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_summary_mark> tbl_student_summary_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_subject_exam> tbl_student_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_student_private_document> tbl_student_student_private_document { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_call_roll> tbl_student_call_roll { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_education_program> tbl_student_education_program { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_register_change> tbl_student_register_change { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_candidate_profile> tbl_student_candidate_profile1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject> tbl_student_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_summary_mark> tbl_student_semester_summary_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_process_assessment_point> tbl_student_process_assessment_point { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_student_semester> tbl_student_object_student_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_certificate> tbl_student_certificate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }
    }
}

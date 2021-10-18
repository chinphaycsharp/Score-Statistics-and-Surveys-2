namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_department()
        {
            tbl_budget_distribution = new HashSet<tbl_budget_distribution>();
            tbl_calendar_event = new HashSet<tbl_calendar_event>();
            tbl_calendar_event1 = new HashSet<tbl_calendar_event>();
            tbl_calendar_event_attendee = new HashSet<tbl_calendar_event_attendee>();
            tbl_course_subject_config = new HashSet<tbl_course_subject_config>();
            tbl_education_program_tuition_fee = new HashSet<tbl_education_program_tuition_fee>();
            tbl_education_fee_config = new HashSet<tbl_education_fee_config>();
            tbl_department1 = new HashSet<tbl_department>();
            tbl_position_staff = new HashSet<tbl_position_staff>();
            tbl_study_alert_condition = new HashSet<tbl_study_alert_condition>();
            tbl_position = new HashSet<tbl_position>();
            tbl_enrollment_class = new HashSet<tbl_enrollment_class>();
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
            tbl_receive_pay_able = new HashSet<tbl_receive_pay_able>();
            tbl_speciality = new HashSet<tbl_speciality>();
            tbl_scholarship_condition = new HashSet<tbl_scholarship_condition>();
            tbl_subject = new HashSet<tbl_subject>();
            tbl_school_fee_config = new HashSet<tbl_school_fee_config>();
            tbl_salary_config = new HashSet<tbl_salary_config>();
            tbl_education_voucher = new HashSet<tbl_education_voucher>();
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

        public int? department_type { get; set; }

        [StringLength(255)]
        public string display_order { get; set; }

        public int? level { get; set; }

        [StringLength(255)]
        public string line_path { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string short_name { get; set; }

        public long? parent_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_budget_distribution> tbl_budget_distribution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event> tbl_calendar_event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event> tbl_calendar_event1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event_attendee> tbl_calendar_event_attendee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_config> tbl_course_subject_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_fee_config> tbl_education_fee_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_department> tbl_department1 { get; set; }

        public virtual tbl_department tbl_department2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_position_staff> tbl_position_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_condition> tbl_study_alert_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_position> tbl_position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class> tbl_enrollment_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_speciality> tbl_speciality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_scholarship_condition> tbl_scholarship_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject> tbl_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_school_fee_config> tbl_school_fee_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_salary_config> tbl_salary_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher> tbl_education_voucher { get; set; }
    }
}

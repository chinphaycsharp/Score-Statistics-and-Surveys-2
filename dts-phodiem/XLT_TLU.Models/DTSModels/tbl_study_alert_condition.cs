namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_study_alert_condition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_study_alert_condition()
        {
            tbl_student_study_alert_level = new HashSet<tbl_student_study_alert_level>();
            tbl_study_alert_condition_student_object = new HashSet<tbl_study_alert_condition_student_object>();
            tbl_study_alert_condition_certificate = new HashSet<tbl_study_alert_condition_certificate>();
            tbl_study_alert_running = new HashSet<tbl_study_alert_running>();
            tbl_study_alert_condition_level = new HashSet<tbl_study_alert_condition_level>();
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

        public double? cumumlative_mark { get; set; }

        public double? cumulative_mark_2_semester { get; set; }

        [StringLength(255)]
        public string cumulative_mark_2_semester_operator { get; set; }

        [StringLength(255)]
        public string cumulative_mark_2_semester_type { get; set; }

        [StringLength(255)]
        public string cumulativeMarkOperator { get; set; }

        public double? cumulative_mark_semester { get; set; }

        [StringLength(255)]
        public string number_cumulative_mark_semester_operator { get; set; }

        [StringLength(255)]
        public string cumulative_mark_semester_type { get; set; }

        [StringLength(255)]
        public string cumumlative_mark_type { get; set; }

        public bool? is_include_retain { get; set; }

        public bool? is_not_complete_tuition_fee { get; set; }

        public bool? is_out_of_duration_time { get; set; }

        public double? learning_mark { get; set; }

        public double? learning_mark_2_semester { get; set; }

        [StringLength(255)]
        public string learning_mark_2_semester_operator { get; set; }

        [StringLength(255)]
        public string learning_mark_2_semester_type { get; set; }

        [StringLength(255)]
        public string learning_mark_operator { get; set; }

        public double? learning_mark_school_year { get; set; }

        [StringLength(255)]
        public string learning_mark_school_year_operator { get; set; }

        [StringLength(255)]
        public string learning_mark_school_year_type { get; set; }

        public double? learning_mark_semester { get; set; }

        [StringLength(255)]
        public string learning_semester_operator { get; set; }

        [StringLength(255)]
        public string learning_semester_type { get; set; }

        [StringLength(255)]
        public string learning_mark_type { get; set; }

        public double? max_duration { get; set; }

        public double? max_duration_include_retain { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? number_cumumlative_credit { get; set; }

        public int? number_cumulative_credit_2_semester { get; set; }

        [StringLength(255)]
        public string number_cumulative_credit_2_semester_operator { get; set; }

        [StringLength(255)]
        public string number_cumumlative_credit_operator { get; set; }

        public int? number_cumulative_credit_semester { get; set; }

        [StringLength(255)]
        public string number_cumulative_credit_semester_operator { get; set; }

        public int? number_discipline { get; set; }

        public int? number_learning_credit { get; set; }

        public int? number_learning_credit_2_semester { get; set; }

        [StringLength(255)]
        public string number_learning_credit_2_semester_operator { get; set; }

        [StringLength(255)]
        public string number_learning_credit_operator { get; set; }

        public int? number_learning_credit_school_year { get; set; }

        [StringLength(255)]
        public string number_learning_credit_school_year_operator { get; set; }

        public int? number_learning_credit_semester { get; set; }

        [StringLength(255)]
        public string number_learning_credit_semester_operator { get; set; }

        public int? study_alert_type { get; set; }

        public long? course_year_id { get; set; }

        public long? discipline_id { get; set; }

        public long? class_id { get; set; }

        public long? semester_id { get; set; }

        public long? speciality_id { get; set; }

        public long? study_alert_level_id { get; set; }

        public int? number_of_credit_debt { get; set; }

        [StringLength(255)]
        public string number_of_credit_debt_operator { get; set; }

        public long? department_id { get; set; }

        public bool? check_number_of_credit_debt { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        public virtual tbl_discipline tbl_discipline { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_study_alert_level> tbl_student_study_alert_level { get; set; }

        public virtual tbl_study_alert_level tbl_study_alert_level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_condition_student_object> tbl_study_alert_condition_student_object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_condition_certificate> tbl_study_alert_condition_certificate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_running> tbl_study_alert_running { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_study_alert_condition_level> tbl_study_alert_condition_level { get; set; }
    }
}

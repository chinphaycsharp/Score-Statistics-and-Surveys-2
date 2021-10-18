namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_study_alert_level
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_study_alert_level()
        {
            tbl_student_study_alert_level_lower = new HashSet<tbl_student_study_alert_level_lower>();
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
        public string note { get; set; }

        public int? status { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public long? study_alert_condition_id { get; set; }

        public long? study_alert_level_id { get; set; }

        public bool? is_lock { get; set; }

        public double? learning_mark4 { get; set; }

        public int? learning_number_of_credit { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date_lock { get; set; }

        public double? mark4 { get; set; }

        public double? mark4_pre_semester { get; set; }

        public double? mark4_semester { get; set; }

        public double? mark4_year { get; set; }

        public int? number_of_credit_debt { get; set; }

        public int? number_of_credit_pre_semester { get; set; }

        public int? number_of_credit_semester { get; set; }

        public int? study_alert_type { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_study_alert_level tbl_study_alert_level { get; set; }

        public virtual tbl_study_alert_condition tbl_study_alert_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_study_alert_level_lower> tbl_student_study_alert_level_lower { get; set; }
    }
}

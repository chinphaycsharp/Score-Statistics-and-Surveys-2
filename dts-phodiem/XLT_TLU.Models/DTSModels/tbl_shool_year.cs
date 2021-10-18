namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_shool_year
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_shool_year()
        {
            tbl_behavior_mark_classification_standard = new HashSet<tbl_behavior_mark_classification_standard>();
            tbl_enrollment_class_reward = new HashSet<tbl_enrollment_class_reward>();
            tbl_enrollment_class_reward_condition = new HashSet<tbl_enrollment_class_reward_condition>();
            tbl_semester = new HashSet<tbl_semester>();
            tbl_student_semester_behavior_mark = new HashSet<tbl_student_semester_behavior_mark>();
            tbl_student_reward = new HashSet<tbl_student_reward>();
            tbl_student_school_year_summary_mark = new HashSet<tbl_student_school_year_summary_mark>();
            tbl_student_reward_condition = new HashSet<tbl_student_reward_condition>();
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

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        public bool? is_current { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        public int? year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_behavior_mark_classification_standard> tbl_behavior_mark_classification_standard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_reward> tbl_enrollment_class_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_reward_condition> tbl_enrollment_class_reward_condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester> tbl_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_behavior_mark> tbl_student_semester_behavior_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reward> tbl_student_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_school_year_summary_mark> tbl_student_school_year_summary_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reward_condition> tbl_student_reward_condition { get; set; }
    }
}

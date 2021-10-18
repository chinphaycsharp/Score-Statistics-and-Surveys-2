namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_enrollment_class_reward_condition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_enrollment_class_reward_condition()
        {
            tbl_enrollment_class_reward = new HashSet<tbl_enrollment_class_reward>();
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

        public int? academic_classification { get; set; }

        public double? academic_classification_percent { get; set; }

        public int? inspect_course_year { get; set; }

        public int? inspect_school_year { get; set; }

        public bool? is_warning { get; set; }

        public int? reward_name { get; set; }

        public double? student_alert_percent { get; set; }

        public long? course_year_id { get; set; }

        public long? school_year_id { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_reward> tbl_enrollment_class_reward { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }
    }
}

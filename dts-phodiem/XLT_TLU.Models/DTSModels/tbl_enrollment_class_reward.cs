namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_enrollment_class_reward
    {
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

        [Column(TypeName = "datetime2")]
        public DateTime? decision_date { get; set; }

        public long? number_excellent_students { get; set; }

        public long? number_good_students { get; set; }

        public long? number_very_good_students { get; set; }

        public long? number_warning { get; set; }

        [StringLength(255)]
        public string reason { get; set; }

        public int? status { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? enrollment_class_reward_condition { get; set; }

        public long? reward_id { get; set; }

        public long? reward_decree_id { get; set; }

        public long? school_year_id { get; set; }

        public long? semester_id { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_enrollment_class_reward_condition tbl_enrollment_class_reward_condition { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }

        public virtual tbl_reward_decree tbl_reward_decree { get; set; }

        public virtual tbl_reward tbl_reward { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_study_alert_condition_level
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

        public int? condition_type { get; set; }

        public int? number_study_alert { get; set; }

        [Column("operator")]
        [StringLength(255)]
        public string _operator { get; set; }

        public long? study_alert_condition { get; set; }

        public long? study_alert_level { get; set; }

        public virtual tbl_study_alert_condition tbl_study_alert_condition { get; set; }

        public virtual tbl_study_alert_level tbl_study_alert_level { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_register_period_time_config
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
        public DateTime? end_register_date { get; set; }

        public bool? is_grant { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_register_date { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? register_period_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_unregister_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_unregister_time { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }
    }
}

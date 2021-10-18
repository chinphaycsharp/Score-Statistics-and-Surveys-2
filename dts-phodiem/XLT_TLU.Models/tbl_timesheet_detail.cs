namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_timesheet_detail
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

        public double? hours { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_time { get; set; }

        [StringLength(255)]
        public string working_item_title { get; set; }

        public long? timesheet_id { get; set; }

        public virtual tbl_timesheet tbl_timesheet { get; set; }
    }
}

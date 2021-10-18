namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_activity_log
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

        [Required]
        [StringLength(4000)]
        public string content_log { get; set; }

        [StringLength(255)]
        public string entity_object_type { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? log_date { get; set; }

        public int? log_type { get; set; }

        [StringLength(255)]
        public string module_log { get; set; }

        [StringLength(255)]
        public string user_name { get; set; }
    }
}

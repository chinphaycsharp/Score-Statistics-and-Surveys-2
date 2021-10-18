namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_transfer_schedule_history
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

        [StringLength(255)]
        public string code { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date_transfer { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public long? course_subject_id { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }
    }
}

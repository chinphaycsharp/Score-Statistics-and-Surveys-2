namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_semester_behavior_mark_history
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
        public DateTime? dateModify { get; set; }

        public int? level { get; set; }

        public double? mark { get; set; }

        public double? markBefore { get; set; }

        [StringLength(255)]
        public string userModify { get; set; }

        public long? student_semester_behavior_id { get; set; }

        public virtual tbl_student_semester_behavior_mark tbl_student_semester_behavior_mark { get; set; }
    }
}

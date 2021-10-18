namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_decision
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
        public string file_path { get; set; }

        [StringLength(255)]
        public string decision_code { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public long? decision_type_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public long? decision_id { get; set; }

        [StringLength(255)]
        public string attachedFilePath { get; set; }

        [StringLength(255)]
        public string decisionCode { get; set; }

        public virtual tbl_decision tbl_decision { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_semester tbl_semester1 { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_decision_type tbl_student_decision_type { get; set; }
    }
}

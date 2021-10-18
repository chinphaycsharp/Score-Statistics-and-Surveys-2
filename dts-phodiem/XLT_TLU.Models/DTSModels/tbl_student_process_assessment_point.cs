namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_process_assessment_point
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

        public double? class_mark { get; set; }

        public double? final_mark { get; set; }

        public int? mark_status { get; set; }

        public double? student_mark { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public double? classMark { get; set; }

        public double? finalMark { get; set; }

        public int? markStatus { get; set; }

        public double? studentMark { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

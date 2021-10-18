namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_course_subject_subject_exam_formula
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

        public double? coefficient { get; set; }

        public int? coffi { get; set; }

        public long? course_subject_id { get; set; }

        public long? semester_subject_id { get; set; }

        public long? subject_exam_id { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        public virtual tbl_subject_exam tbl_subject_exam { get; set; }

        public virtual tbl_semester_subject tbl_semester_subject { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_training_base_semester_subject_exam
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

        public int? numberOfExamRoom { get; set; }

        public long? semester_subject_exam_id { get; set; }

        public long? training_base_id { get; set; }

        public virtual tbl_semester_subject_exam tbl_semester_subject_exam { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_prerequisite_subject
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

        public double? prerequite_mark { get; set; }

        public int? prerequite_type { get; set; }

        public long prerequite_subject_id { get; set; }

        public long program_subject_id { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }

        public virtual tbl_program_subject tbl_program_subject { get; set; }
    }
}

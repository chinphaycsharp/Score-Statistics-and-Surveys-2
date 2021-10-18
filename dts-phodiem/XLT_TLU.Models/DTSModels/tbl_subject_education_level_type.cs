namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_subject_education_level_type
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

        public long? education_level_id { get; set; }

        public long? education_type_id { get; set; }

        public long? subject_id { get; set; }

        public virtual tbl_education_level tbl_education_level { get; set; }

        public virtual tbl_education_type tbl_education_type { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }
    }
}

namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_subject_learning_skill
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

        public bool? is_main_skill { get; set; }

        public double? number_hour { get; set; }

        public long? learning_skill_id { get; set; }

        public long? subject_id { get; set; }

        public virtual tbl_learning_skill tbl_learning_skill { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }
    }
}

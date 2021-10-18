namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_object_subsidize_semester
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

        public int? status { get; set; }

        public long? reward_decree_id { get; set; }

        public long? student_id { get; set; }

        public long? student_object_subsidize_id { get; set; }

        public virtual tbl_reward_decree tbl_reward_decree { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_object_subsidize tbl_student_object_subsidize { get; set; }
    }
}

namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_call_roll
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
        public string note { get; set; }

        public int? number_absences { get; set; }

        public int? number_hours { get; set; }

        public int? status { get; set; }

        public long? student_id { get; set; }

        public long? timetable_detail_id { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_timetable_detail tbl_timetable_detail { get; set; }
    }
}

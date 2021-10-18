namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_specialty_admissions_map
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
        public string admission_code { get; set; }

        public long? course_year_id { get; set; }

        public long? speciality_id { get; set; }

        [StringLength(255)]
        public string admissionCode { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }
    }
}

namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_speciality_program
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

        [Column(TypeName = "datetime2")]
        public DateTime? applyFromDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? applyToDate { get; set; }

        public long? applyFromSchoolYear { get; set; }

        public bool? isCurrent { get; set; }

        public long? applyToSchoolYear { get; set; }

        public long? program_id { get; set; }

        public long? sepeciality_id { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }
    }
}

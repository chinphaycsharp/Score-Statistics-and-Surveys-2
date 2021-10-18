namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_course_subject_config
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

        public int? configType { get; set; }

        public bool? is_denied { get; set; }

        public bool? is_grant { get; set; }

        public long? course_subject_id { get; set; }

        public long? course_year_id { get; set; }

        public long? deparment_id { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? program_id { get; set; }

        public long? speciality_id { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }
    }
}

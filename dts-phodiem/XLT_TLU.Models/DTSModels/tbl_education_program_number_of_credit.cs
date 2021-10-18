namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_education_program_number_of_credit
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

        public int? min_number_of_credit { get; set; }

        public int? min_number_of_credit_not_mark { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? number_of_credit { get; set; }

        public int? number_subject { get; set; }

        public int? number_subject_not_mark { get; set; }

        public long? course_year_id { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? semester_id { get; set; }

        public long? speciality_id { get; set; }

        public long? training_base_id { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }
    }
}

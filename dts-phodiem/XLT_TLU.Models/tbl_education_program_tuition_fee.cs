namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_education_program_tuition_fee
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

        public double? basic_main_spec_fee { get; set; }

        public double? basic_second_spec_fee { get; set; }

        public bool? is_current { get; set; }

        public double? main_spec_fee { get; set; }

        public double? main_spec_fee_improve { get; set; }

        public double? main_spec_fee_retake { get; set; }

        public double? second_spec_fee { get; set; }

        public double? second_spec_fee_improve { get; set; }

        public double? second_spec_fee_retake { get; set; }

        public int? type { get; set; }

        public long? course_year_id { get; set; }

        public long? education_level_id { get; set; }

        public long? education_program_id { get; set; }

        public long? education_type_id { get; set; }

        public long? class_id { get; set; }

        public long? register_period_id { get; set; }

        public long? semester_id { get; set; }

        public long? sepeciality_id { get; set; }

        public long? training_base_id { get; set; }

        public int? education_program_type { get; set; }

        public long? department_id { get; set; }

        public long? speciality_id { get; set; }

        public double? basicMainSpecFee { get; set; }

        public double? basicSecondSpecFee { get; set; }

        public bool? isCurrent { get; set; }

        public double? mainSpecFee { get; set; }

        public double? mainSpecFeeImprove { get; set; }

        public double? mainSpecFeeRetake { get; set; }

        public double? secondSpecFee { get; set; }

        public double? secondSpecFeeImprove { get; set; }

        public double? secondSpecFeeRetake { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        public virtual tbl_education_level tbl_education_level { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        public virtual tbl_speciality tbl_speciality1 { get; set; }

        public virtual tbl_education_type tbl_education_type { get; set; }
    }
}

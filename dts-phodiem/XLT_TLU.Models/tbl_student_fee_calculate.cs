namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_fee_calculate
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

        public double? amount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? calculate_date { get; set; }

        public double? discount_percent { get; set; }

        public double? discount_value { get; set; }

        public bool? is_lock { get; set; }

        public double? rest_amount { get; set; }

        public long? course_subject_id { get; set; }

        public long? education_fee_config_id { get; set; }

        public long? period_id { get; set; }

        public long? receive_payable_id { get; set; }

        public long semester_id { get; set; }

        public long? semester_subject_exam_id { get; set; }

        public long student_id { get; set; }

        public long? training_base_id { get; set; }

        public double? cancel_fee { get; set; }

        public double? cancel_fee_percent { get; set; }

        public long? feeItem_id { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? status { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        public virtual tbl_education_fee_config tbl_education_fee_config { get; set; }

        public virtual tbl_fee_item tbl_fee_item { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        public virtual tbl_semester_subject_exam tbl_semester_subject_exam { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }
    }
}

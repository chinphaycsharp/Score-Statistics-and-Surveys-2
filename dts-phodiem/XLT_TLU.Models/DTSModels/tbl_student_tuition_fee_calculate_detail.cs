namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_tuition_fee_calculate_detail
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

        public double? basic_fee_unit { get; set; }

        public double? discount_percent { get; set; }

        public double? discount_value { get; set; }

        public double? fee_unit { get; set; }

        public int? formula { get; set; }

        public bool? is_main_spec { get; set; }

        public int? learning_type { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public double? object_coefficient { get; set; }

        public double? rest_amount { get; set; }

        public double? subject_coefficient { get; set; }

        public double? tuition_fee { get; set; }

        public long? feeItem_id { get; set; }

        public long? student_course_subject_id { get; set; }

        public long? student_tuition_fee_calculate_id { get; set; }

        public int? status { get; set; }

        public int? number_of_credit { get; set; }

        public long? course_subject_id { get; set; }

        public double? cancel_fee { get; set; }

        public double? cancel_fee_percent { get; set; }

        public double? course_subject_coefficient { get; set; }

        public double? basicFeeUnit { get; set; }

        public double? discountPercent { get; set; }

        public double? discountValue { get; set; }

        public double? feeUnit { get; set; }

        public bool? isMainSpec { get; set; }

        public int? learningType { get; set; }

        public double? objectCoefficient { get; set; }

        public double? restAmount { get; set; }

        public double? subjectCoefficient { get; set; }

        public double? tuitionFee { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        public virtual tbl_fee_item tbl_fee_item { get; set; }

        public virtual tbl_student_course_subject tbl_student_course_subject { get; set; }

        public virtual tbl_student_tuition_fee_calculate tbl_student_tuition_fee_calculate { get; set; }
    }
}

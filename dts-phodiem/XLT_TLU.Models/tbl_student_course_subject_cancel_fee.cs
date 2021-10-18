namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_course_subject_cancel_fee
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

        public double? pay_amount { get; set; }

        public double? pay_percent { get; set; }

        public double? tuition_fee { get; set; }

        public long? course_subject_id { get; set; }

        public long? receive_pay_able_id { get; set; }

        public long? student_id { get; set; }

        public long? receive_pay_able_detail_id { get; set; }

        public long? student_register_change_id { get; set; }

        public double? tuition_fee_discount_percent { get; set; }

        public double? tuition_fee_per_credit { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }

        public virtual tbl_receive_pay_able_detail tbl_receive_pay_able_detail { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_register_change tbl_student_register_change { get; set; }
    }
}

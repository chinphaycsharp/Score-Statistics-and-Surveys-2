namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_receive_pay_able_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_receive_pay_able_detail()
        {
            tbl_education_voucher_detail = new HashSet<tbl_education_voucher_detail>();
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
            tbl_student_course_subject_cancel_fee = new HashSet<tbl_student_course_subject_cancel_fee>();
            tbl_receive_pay_able_detail1 = new HashSet<tbl_receive_pay_able_detail>();
        }

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

        public double? discount_amount { get; set; }

        public double? discount_percent { get; set; }

        public int? is_receive { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public double? total_amount { get; set; }

        public double? transfer_value { get; set; }

        public int? type { get; set; }

        public double? withdrawal_value { get; set; }

        public long? fee_item_id { get; set; }

        public long? fee_item_detail_id { get; set; }

        public long? receive_pay_able_id { get; set; }

        public long? receive_pay_able_detail_id { get; set; }

        public long? scholarship_fund_id { get; set; }

        public long? student_expectation_register_id { get; set; }

        public long? student_scholarship_history_id { get; set; }

        public long? student_semester_scholarship_id { get; set; }

        public long? student_tuition_fee_calculate_id { get; set; }

        public int? isReceive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher_detail> tbl_education_voucher_detail { get; set; }

        public virtual tbl_fee_item tbl_fee_item { get; set; }

        public virtual tbl_fee_item_detail tbl_fee_item_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }

        public virtual tbl_student_expectation_register tbl_student_expectation_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }

        public virtual tbl_student_semester_reward_scholarship tbl_student_semester_reward_scholarship { get; set; }

        public virtual tbl_student_tuition_fee_calculate tbl_student_tuition_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail1 { get; set; }

        public virtual tbl_receive_pay_able_detail tbl_receive_pay_able_detail2 { get; set; }

        public virtual tbl_scholarship_fund tbl_scholarship_fund { get; set; }

        public virtual tbl_student_scholarship_history tbl_student_scholarship_history { get; set; }
    }
}

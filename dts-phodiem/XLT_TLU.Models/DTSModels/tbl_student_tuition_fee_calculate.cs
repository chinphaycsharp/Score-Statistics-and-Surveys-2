namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_tuition_fee_calculate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_tuition_fee_calculate()
        {
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
            tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
            tbl_student_tuition_fee_calculate_detail = new HashSet<tbl_student_tuition_fee_calculate_detail>();
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

        public double? account { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? calculate_date { get; set; }

        public double? discount_percent { get; set; }

        public double? discount_value { get; set; }

        public double? first_time_learn_fee { get; set; }

        public bool? is_lock { get; set; }

        public int? number_of_credit { get; set; }

        public int? number_of_subject { get; set; }

        public double? relearn_fee { get; set; }

        public double? rest_amount { get; set; }

        public double? total_tuition_fee { get; set; }

        public int? type { get; set; }

        public double? upgrade_mark_fee { get; set; }

        public long? discount_tuition_fee_id { get; set; }

        public long? receive_payable_id { get; set; }

        public long? register_periods_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public long? training_base_id { get; set; }

        public virtual tbl_discount_tuition_fee tbl_discount_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate_detail> tbl_student_tuition_fee_calculate_detail { get; set; }
    }
}

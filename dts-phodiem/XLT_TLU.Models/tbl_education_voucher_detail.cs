namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_education_voucher_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_education_voucher_detail()
        {
            tbl_voucher_detail_to_voucher_detail_link = new HashSet<tbl_voucher_detail_to_voucher_detail_link>();
            tbl_voucher_detail_to_voucher_detail_link1 = new HashSet<tbl_voucher_detail_to_voucher_detail_link>();
            tbl_voucher_detail_recieve_pay_able_link = new HashSet<tbl_voucher_detail_recieve_pay_able_link>();
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
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

        public double? received_amount { get; set; }

        public int? type { get; set; }

        public long? education_voucher_id { get; set; }

        public long? fee_item_id { get; set; }

        public long? fee_item_detai_id { get; set; }

        public long? receive_pay_able_id { get; set; }

        public long? receive_pay_able_detail_id { get; set; }

        public bool? view_able { get; set; }

        public double? rest_amount { get; set; }

        public double? amount_done { get; set; }

        public double? discountAmount { get; set; }

        public double? discountPercent { get; set; }

        public int? isCredit { get; set; }

        public double? receivedAmount { get; set; }

        public virtual tbl_education_voucher tbl_education_voucher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_detail_to_voucher_detail_link> tbl_voucher_detail_to_voucher_detail_link { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_detail_to_voucher_detail_link> tbl_voucher_detail_to_voucher_detail_link1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_detail_recieve_pay_able_link> tbl_voucher_detail_recieve_pay_able_link { get; set; }

        public virtual tbl_receive_pay_able_detail tbl_receive_pay_able_detail { get; set; }

        public virtual tbl_fee_item tbl_fee_item { get; set; }

        public virtual tbl_fee_item_detail tbl_fee_item_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }
    }
}

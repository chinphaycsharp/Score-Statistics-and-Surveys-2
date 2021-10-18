namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_voucher_detail_recieve_pay_able_link
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

        public int? is_receive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? voucherDate { get; set; }

        public long? education_voucher_detail_id { get; set; }

        public long? receive_pay_able_id { get; set; }

        public virtual tbl_education_voucher_detail tbl_education_voucher_detail { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }
    }
}

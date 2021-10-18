namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_voucher_recieve_pay_able
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

        public double? amount_done { get; set; }

        public long? educationVoucher_id { get; set; }

        public long? receivePayAble_id { get; set; }

        public virtual tbl_education_voucher tbl_education_voucher { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }
    }
}

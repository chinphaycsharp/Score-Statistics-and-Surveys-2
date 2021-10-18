namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_discount_tuition_fee_item
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

        public double? proportion_discount { get; set; }

        public long? discount_tuition_fee_id { get; set; }

        public long? fee_item_id { get; set; }

        public virtual tbl_discount_tuition_fee tbl_discount_tuition_fee { get; set; }

        public virtual tbl_fee_item tbl_fee_item { get; set; }
    }
}

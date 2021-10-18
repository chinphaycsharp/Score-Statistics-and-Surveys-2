namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_other_fee
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
        public string class_name { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        public double? credit_amount { get; set; }

        public double? debit_amount { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? order_number { get; set; }

        public double? return_amount { get; set; }

        [StringLength(255)]
        public string student_code { get; set; }

        public long? student_id { get; set; }

        [StringLength(255)]
        public string student_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? voucher_date { get; set; }

        public int? voucher_type { get; set; }

        public double? additional { get; set; }

        [StringLength(255)]
        public string semester_code { get; set; }

        public long? semester_id { get; set; }

        [StringLength(255)]
        public string training_base_code { get; set; }

        public long? training_base_id { get; set; }

        [StringLength(255)]
        public string training_base_name { get; set; }
    }
}

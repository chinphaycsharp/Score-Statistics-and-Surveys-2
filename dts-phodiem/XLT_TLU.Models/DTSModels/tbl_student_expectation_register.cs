namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_expectation_register
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_expectation_register()
        {
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
            tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
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

        public bool? checked_fee { get; set; }

        public double? fee { get; set; }

        public int? status { get; set; }

        public long? expectation_register_id { get; set; }

        public long? student_id { get; set; }

        public virtual tbl_expectation_register tbl_expectation_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

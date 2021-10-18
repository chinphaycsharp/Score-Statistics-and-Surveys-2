namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_scholarship_fund
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_scholarship_fund()
        {
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
            tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
            tbl_scholarship_condition = new HashSet<tbl_scholarship_condition>();
            tbl_student_scholarship_stock_detail = new HashSet<tbl_student_scholarship_stock_detail>();
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
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

        [StringLength(255)]
        public string code { get; set; }

        [StringLength(255)]
        public string desciption { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? type { get; set; }

        public long? scholarship_fund_type_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_scholarship_condition> tbl_scholarship_condition { get; set; }

        public virtual tbl_scholarship_fund_type tbl_scholarship_fund_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_stock_detail> tbl_student_scholarship_stock_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }
    }
}

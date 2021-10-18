namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_scholarship_history
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_scholarship_history()
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

        public double? amount { get; set; }

        public double? amountBefore { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dateModify { get; set; }

        [StringLength(255)]
        public string userModify { get; set; }

        public long? receive_pay_able_id { get; set; }

        public long? student_semester_scholarship_id { get; set; }

        public int? level { get; set; }

        public double? mark { get; set; }

        public double? markBefore { get; set; }

        public long? student_semester_behavior_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }

        public virtual tbl_student_semester_reward_scholarship tbl_student_semester_reward_scholarship { get; set; }

        public virtual tbl_student_semester_behavior_mark tbl_student_semester_behavior_mark { get; set; }
    }
}

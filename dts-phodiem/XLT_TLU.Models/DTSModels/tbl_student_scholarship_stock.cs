namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_scholarship_stock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_scholarship_stock()
        {
            tbl_student_scholarship_stock_detail = new HashSet<tbl_student_scholarship_stock_detail>();
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

        public double? receive_semester_value { get; set; }

        public double? semester_changed_value { get; set; }

        public double? semester_receive_value { get; set; }

        public double? semester_tuition_balance { get; set; }

        public double? semester_value { get; set; }

        public double? semester_withdraw_value { get; set; }

        public double? stock_semester_value { get; set; }

        public double? total_changed_value { get; set; }

        public double? total_receive_value { get; set; }

        public double? total_stock_value { get; set; }

        public double? total_tuition_balance { get; set; }

        public double? total_value { get; set; }

        public double? total_withdraw_value { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_stock_detail> tbl_student_scholarship_stock_detail { get; set; }
    }
}

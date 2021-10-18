namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_discount_tuition_fee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_discount_tuition_fee()
        {
            tbl_discount_tuition_fee_item = new HashSet<tbl_discount_tuition_fee_item>();
            tbl_student_tuition_fee_calculate = new HashSet<tbl_student_tuition_fee_calculate>();
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

        public bool? is_discount_all { get; set; }

        public bool? is_discount_all_case { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public double? proportion_discount { get; set; }

        public long? course_year_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_object_id { get; set; }

        public bool? is_discount_by_tuition_fee { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_student_object tbl_student_object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_discount_tuition_fee_item> tbl_discount_tuition_fee_item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }
    }
}

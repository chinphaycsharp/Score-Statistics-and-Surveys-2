namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_school_year_summary_mark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_school_year_summary_mark()
        {
            tbl_student_semester_summary_mark = new HashSet<tbl_student_semester_summary_mark>();
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
        public string char_mark { get; set; }

        [StringLength(255)]
        public string char_mark_n2 { get; set; }

        public double? first_learning_mark { get; set; }

        public double? first_learning_mark4 { get; set; }

        public double? first_learning_mark_n2 { get; set; }

        public double? first_mark { get; set; }

        public double? first_mark4 { get; set; }

        public double? first_mark_n2 { get; set; }

        public int? first_total_credit { get; set; }

        public int? first_total_learning_credit { get; set; }

        public double? learning_mark { get; set; }

        public double? learning_mark4 { get; set; }

        public double? learning_mark4_n2 { get; set; }

        public double? learning_mark_n2 { get; set; }

        public int? learning_total_credit { get; set; }

        public int? learning_total_credit_n2 { get; set; }

        public double? mark { get; set; }

        public double? mark4 { get; set; }

        public double? mark4_n2 { get; set; }

        public double? mark_n2 { get; set; }

        public int? school_year_index { get; set; }

        public int? sort_mark { get; set; }

        public int? total_credit { get; set; }

        public int? total_credit_n2 { get; set; }

        public long? school_year_id { get; set; }

        public long? student_id { get; set; }

        public long? student_summary_mark_id { get; set; }

        public bool? is_lock { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        public virtual tbl_student_summary_mark tbl_student_summary_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_summary_mark> tbl_student_semester_summary_mark { get; set; }
    }
}

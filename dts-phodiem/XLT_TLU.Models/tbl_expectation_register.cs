namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_expectation_register
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_expectation_register()
        {
            tbl_student_expectation_register = new HashSet<tbl_student_expectation_register>();
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

        public double? fee { get; set; }

        public int? type { get; set; }

        public long? course_year_id { get; set; }

        public long? period_id { get; set; }

        public long? semester_id { get; set; }

        public long? subject_id { get; set; }

        public long? sub_semester_id { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_expectation_register> tbl_student_expectation_register { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_semester tbl_semester1 { get; set; }
    }
}

namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_object_subsidize
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_object_subsidize()
        {
            tbl_student_object_subsidize_semester = new HashSet<tbl_student_object_subsidize_semester>();
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

        public int? academic_classification { get; set; }

        public int? behavior_classification { get; set; }

        public bool? is_disciplined { get; set; }

        public double money_subsidize { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? number_of_credit_learning { get; set; }

        public int? number_of_retest_allowed { get; set; }

        public long? course_year_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_object_id { get; set; }

        public int number_month_subsidize { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student_object tbl_student_object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_subsidize_semester> tbl_student_object_subsidize_semester { get; set; }
    }
}

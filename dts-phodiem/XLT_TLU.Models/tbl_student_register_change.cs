namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_register_change
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_register_change()
        {
            tbl_student_course_subject_cancel_fee = new HashSet<tbl_student_course_subject_cancel_fee>();
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

        public int? change_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? first_time_change { get; set; }

        public bool? is_lock { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? last_time_change { get; set; }

        public long? register_period_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }
    }
}

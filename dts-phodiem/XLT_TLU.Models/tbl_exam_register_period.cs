namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_exam_register_period
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_exam_register_period()
        {
            tbl_exam_room_period = new HashSet<tbl_exam_room_period>();
            tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
            tbl_student_exam_group = new HashSet<tbl_student_exam_group>();
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

        [Column(TypeName = "datetime2")]
        public DateTime? end_time { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_time { get; set; }

        public long? semeter_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? from_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? to_date { get; set; }

        public long? semester_register_period_id { get; set; }

        public bool? is_published { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_exam_room_period> tbl_exam_room_period { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_exam_group> tbl_student_exam_group { get; set; }
    }
}

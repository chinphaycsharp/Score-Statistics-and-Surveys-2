namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_timetable_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_timetable_detail()
        {
            tbl_student_call_roll = new HashSet<tbl_student_call_roll>();
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

        [Column(TypeName = "datetime2")]
        public DateTime? date { get; set; }

        public int? status { get; set; }

        public int? week { get; set; }

        public long? course_subject_id { get; set; }

        public long? timetable_id { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        public virtual tbl_course_subject_timetable tbl_course_subject_timetable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_call_roll> tbl_student_call_roll { get; set; }
    }
}

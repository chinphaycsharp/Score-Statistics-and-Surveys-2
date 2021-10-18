namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_course_subject_timetable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_course_subject_timetable()
        {
            tbl_timetable_detail = new HashSet<tbl_timetable_detail>();
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

        public int? fromWeek { get; set; }

        public double? number_hours { get; set; }

        public int? toWeek { get; set; }

        public int? week { get; set; }

        public long? assistant_teacher_id { get; set; }

        public long? end_hour_id { get; set; }

        public long? room_id { get; set; }

        public long? start_hour_id { get; set; }

        public long? teacher_id { get; set; }

        public long? course_subject_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        public virtual tbl_course_hour tbl_course_hour { get; set; }

        public virtual tbl_course_hour tbl_course_hour1 { get; set; }

        public virtual tbl_course_subject tbl_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_timetable_detail> tbl_timetable_detail { get; set; }

        public virtual tbl_room tbl_room { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }

        public virtual tbl_staff tbl_staff1 { get; set; }
    }
}

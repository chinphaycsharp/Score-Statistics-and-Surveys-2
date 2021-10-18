namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_room()
        {
            tbl_calendar_event = new HashSet<tbl_calendar_event>();
            tbl_course_subject_timetable = new HashSet<tbl_course_subject_timetable>();
            tbl_exam_room_period = new HashSet<tbl_exam_room_period>();
            tbl_semester_subject_exam_date = new HashSet<tbl_semester_subject_exam_date>();
            tbl_semester_subject_exam_hour_room = new HashSet<tbl_semester_subject_exam_hour_room>();
            tbl_semester_subject_exam_room = new HashSet<tbl_semester_subject_exam_room>();
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

        public int? capacity { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public long? building_id { get; set; }

        public int? exam_capacity { get; set; }

        public virtual tbl_building tbl_building { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event> tbl_calendar_event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_timetable> tbl_course_subject_timetable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_exam_room_period> tbl_exam_room_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_date> tbl_semester_subject_exam_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_hour_room> tbl_semester_subject_exam_hour_room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_room> tbl_semester_subject_exam_room { get; set; }
    }
}

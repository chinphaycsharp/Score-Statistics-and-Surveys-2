namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_exam_hour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_exam_hour()
        {
            tbl_semester_subject_exam_hour = new HashSet<tbl_semester_subject_exam_hour>();
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

        [StringLength(255)]
        public string code { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_time { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_time { get; set; }

        public int? type { get; set; }

        public long? exam_date_id { get; set; }

        public long? exam_type { get; set; }

        public int? view_index { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_hour> tbl_semester_subject_exam_hour { get; set; }

        public virtual tbl_exam_type tbl_exam_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_room> tbl_semester_subject_exam_room { get; set; }
    }
}

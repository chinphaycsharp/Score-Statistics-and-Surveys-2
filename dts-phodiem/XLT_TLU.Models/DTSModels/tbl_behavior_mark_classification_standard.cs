namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_behavior_mark_classification_standard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_behavior_mark_classification_standard()
        {
            tbl_student_semester_behavior_mark = new HashSet<tbl_student_semester_behavior_mark>();
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

        public int? classification { get; set; }

        public double? highest_mark { get; set; }

        public bool? is_end_course_year { get; set; }

        public double? lowest_mark { get; set; }

        public long? course_year_id { get; set; }

        public long? highest_discipline_id { get; set; }

        public long? school_year_id { get; set; }

        public long? semester_id { get; set; }

        public virtual tbl_discipline tbl_discipline { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_behavior_mark> tbl_student_semester_behavior_mark { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_semester_behavior_mark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_semester_behavior_mark()
        {
            tbl_student_behavior_criteria_mark = new HashSet<tbl_student_behavior_criteria_mark>();
            tbl_student_scholarship_history = new HashSet<tbl_student_scholarship_history>();
            tbl_student_semester_behavior_mark_history = new HashSet<tbl_student_semester_behavior_mark_history>();
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

        public double? mark { get; set; }

        public int? sort_mark { get; set; }

        public long? school_year_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public int? level { get; set; }

        public long? classification_id { get; set; }

        public double? mark_conversion { get; set; }

        public bool? is_lock { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public virtual tbl_behavior_mark_classification_standard tbl_behavior_mark_classification_standard { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_behavior_criteria_mark> tbl_student_behavior_criteria_mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_history> tbl_student_scholarship_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_behavior_mark_history> tbl_student_semester_behavior_mark_history { get; set; }
    }
}

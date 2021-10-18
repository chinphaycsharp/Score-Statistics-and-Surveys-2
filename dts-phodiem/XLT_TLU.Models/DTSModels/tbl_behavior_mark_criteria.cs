namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_behavior_mark_criteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_behavior_mark_criteria()
        {
            tbl_behavior_mark_criteria1 = new HashSet<tbl_behavior_mark_criteria>();
            tbl_student_behavior_criteria_mark = new HashSet<tbl_student_behavior_criteria_mark>();
            tbl_student_behavior_criteria_mark1 = new HashSet<tbl_student_behavior_criteria_mark>();
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

        public double? mark { get; set; }

        public long? course_year_id { get; set; }

        public long? semester_id { get; set; }

        public long? parent_id { get; set; }

        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_behavior_mark_criteria> tbl_behavior_mark_criteria1 { get; set; }

        public virtual tbl_behavior_mark_criteria tbl_behavior_mark_criteria2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_behavior_criteria_mark> tbl_student_behavior_criteria_mark { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_behavior_criteria_mark> tbl_student_behavior_criteria_mark1 { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }
    }
}

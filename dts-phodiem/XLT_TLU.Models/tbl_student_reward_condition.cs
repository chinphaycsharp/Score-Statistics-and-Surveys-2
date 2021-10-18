namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_reward_condition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_reward_condition()
        {
            tbl_student_reward = new HashSet<tbl_student_reward>();
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

        [StringLength(255)]
        public string char_mark { get; set; }

        public int? inspect_course_year { get; set; }

        public int? inspect_school_year { get; set; }

        public bool? is_disciplined { get; set; }

        public bool? is_end_course_year { get; set; }

        public bool? is_rewarded { get; set; }

        public double? mark10 { get; set; }

        public double? mark4 { get; set; }

        public int? number_of_retest_allowed { get; set; }

        public int? reward_name { get; set; }

        public long? course_year_id { get; set; }

        public long? school_year_id { get; set; }

        public int? min_credit { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_shool_year tbl_shool_year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reward> tbl_student_reward { get; set; }
    }
}

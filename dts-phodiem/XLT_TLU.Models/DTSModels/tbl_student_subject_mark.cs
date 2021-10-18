namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_subject_mark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_subject_mark()
        {
            tbl_student_mark = new HashSet<tbl_student_mark>();
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
        public string char_mark { get; set; }

        public int? examRound { get; set; }

        public int? input_method { get; set; }

        public bool? is_accepted { get; set; }

        public bool? is_counted { get; set; }

        public bool? is_published { get; set; }

        public double? mark { get; set; }

        public double? mark4 { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? result { get; set; }

        public int? status { get; set; }

        public int? study_time { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public long? subject_id { get; set; }

        public bool? is_mark_equivalent { get; set; }

        public bool? is_conditional_mark { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }
    }
}

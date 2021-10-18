namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_program_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_program_subject()
        {
            tbl_equivalent_subject = new HashSet<tbl_equivalent_subject>();
            tbl_prerequisite_subject = new HashSet<tbl_prerequisite_subject>();
            tbl_subject_exam = new HashSet<tbl_subject_exam>();
            tbl_program_subject_semester = new HashSet<tbl_program_subject_semester>();
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

        public int? mark { get; set; }

        public int? semester { get; set; }

        public int? semester_index { get; set; }

        public int? subject_type { get; set; }

        public long? group_id { get; set; }

        public long? knowledge_program_id { get; set; }

        public long? program_id { get; set; }

        public long? subject_id { get; set; }

        public double? tuition_coefficient { get; set; }

        public double? fee_per_credit { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_equivalent_subject> tbl_equivalent_subject { get; set; }

        public virtual tbl_group_subject_program tbl_group_subject_program { get; set; }

        public virtual tbl_knowledge_program tbl_knowledge_program { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_prerequisite_subject> tbl_prerequisite_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_exam> tbl_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_program_subject_semester> tbl_program_subject_semester { get; set; }

        public virtual tbl_subject tbl_subject { get; set; }
    }
}

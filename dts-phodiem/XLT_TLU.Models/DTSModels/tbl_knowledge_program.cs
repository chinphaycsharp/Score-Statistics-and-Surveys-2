namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_knowledge_program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_knowledge_program()
        {
            tbl_program_subject = new HashSet<tbl_program_subject>();
            tbl_knowledge_program1 = new HashSet<tbl_knowledge_program>();
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

        public int? block_type { get; set; }

        public int? min_number_credit { get; set; }

        public int? number_course_subject { get; set; }

        public int? total_credit { get; set; }

        public long? knowledge_block_id { get; set; }

        public long? parent_id { get; set; }

        public long? program_id { get; set; }

        public long? sub_speciality_id { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        public virtual tbl_knowledge_block tbl_knowledge_block { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_program_subject> tbl_program_subject { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_knowledge_program> tbl_knowledge_program1 { get; set; }

        public virtual tbl_knowledge_program tbl_knowledge_program2 { get; set; }
    }
}

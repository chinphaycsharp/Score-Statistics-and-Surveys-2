namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_private_document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_private_document()
        {
            tbl_student_private_document1 = new HashSet<tbl_student_private_document>();
            tbl_student_student_private_document = new HashSet<tbl_student_student_private_document>();
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

        public int? amounts_of { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public bool? has_profile { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public long? parent_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_private_document> tbl_student_private_document1 { get; set; }

        public virtual tbl_student_private_document tbl_student_private_document2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_student_private_document> tbl_student_student_private_document { get; set; }
    }
}

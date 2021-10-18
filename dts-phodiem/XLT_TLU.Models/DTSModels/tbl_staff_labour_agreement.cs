namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_staff_labour_agreement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_staff_labour_agreement()
        {
            tbl_staff_labour_agreement_attachment = new HashSet<tbl_staff_labour_agreement_attachment>();
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

        public int? agreement_status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? signed_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        public long? labour_agreement_type_id { get; set; }

        public long? staff_id { get; set; }

        public virtual tbl_labour_agreement_type tbl_labour_agreement_type { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_labour_agreement_attachment> tbl_staff_labour_agreement_attachment { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_decision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_decision()
        {
            tbl_student_status_student_semester = new HashSet<tbl_student_status_student_semester>();
            tbl_student_decision = new HashSet<tbl_student_decision>();
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
        public string file_path { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? decision_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? expired_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? issued_date { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? official_date { get; set; }

        [StringLength(255)]
        public string the_signer { get; set; }

        [StringLength(255)]
        public string where_issued { get; set; }

        public long? semester_id { get; set; }

        public long? decision_type_id { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_status_student_semester> tbl_student_status_student_semester { get; set; }

        public virtual tbl_student_decision_type tbl_student_decision_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_decision> tbl_student_decision { get; set; }
    }
}

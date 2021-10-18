namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_school_fee_config
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_school_fee_config()
        {
            tbl_fee_config_item = new HashSet<tbl_fee_config_item>();
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

        [Column(TypeName = "datetime2")]
        public DateTime? from_date { get; set; }

        public bool? is_current { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? to_date { get; set; }

        public long? course_year_id { get; set; }

        public long? sepeciality_id { get; set; }

        public long? student_object_id { get; set; }

        public long? training_base_id { get; set; }

        public long? department_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fromDate { get; set; }

        public bool? isCurrent { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? toDate { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_fee_config_item> tbl_fee_config_item { get; set; }

        public virtual tbl_student_object tbl_student_object { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }
    }
}

namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_civil_servant_category_grade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_civil_servant_category_grade()
        {
            tbl_staff_civil_servant_grade = new HashSet<tbl_staff_civil_servant_grade>();
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

        [StringLength(255)]
        public string name { get; set; }

        public double? salary_coefficient { get; set; }

        public long? civil_servant_category_id { get; set; }

        public long? civil_servant_grade_id { get; set; }

        public virtual tbl_civil_servant_category tbl_civil_servant_category { get; set; }

        public virtual tbl_civil_servant_grade tbl_civil_servant_grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_civil_servant_grade> tbl_staff_civil_servant_grade { get; set; }
    }
}

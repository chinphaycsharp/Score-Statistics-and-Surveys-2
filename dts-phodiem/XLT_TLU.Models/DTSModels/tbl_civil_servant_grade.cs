namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_civil_servant_grade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_civil_servant_grade()
        {
            tbl_civil_servant_category_grade = new HashSet<tbl_civil_servant_category_grade>();
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

        public int? grade { get; set; }

        public int? max_grade { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? next_grade_id { get; set; }

        public double? salary_coefficient { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_civil_servant_category_grade> tbl_civil_servant_category_grade { get; set; }
    }
}

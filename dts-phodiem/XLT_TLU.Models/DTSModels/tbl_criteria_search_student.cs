namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_criteria_search_student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_criteria_search_student()
        {
            tbl_student_graduate_conditional = new HashSet<tbl_student_graduate_conditional>();
            tbl_criteria_search_student_except_subject = new HashSet<tbl_criteria_search_student_except_subject>();
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

        public double? max_mark { get; set; }

        public double? max_mark4 { get; set; }

        public int? max_number_credit_not_pass { get; set; }

        public int? max_number_subject_not_pass { get; set; }

        public double? min_mark { get; set; }

        public double? min_mark4 { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public bool? payFullTuitionFees { get; set; }

        public long? course_year_id { get; set; }

        public long? discipline_id { get; set; }

        public long? education_program_id { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_graduate_conditional> tbl_student_graduate_conditional { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_criteria_search_student_except_subject> tbl_criteria_search_student_except_subject { get; set; }

        public virtual tbl_discipline tbl_discipline { get; set; }
    }
}

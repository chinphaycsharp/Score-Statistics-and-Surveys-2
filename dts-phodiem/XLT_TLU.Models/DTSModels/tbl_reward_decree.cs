namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_reward_decree
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_reward_decree()
        {
            tbl_enrollment_class_reward = new HashSet<tbl_enrollment_class_reward>();
            tbl_student_reward = new HashSet<tbl_student_reward>();
            tbl_student_object_subsidize_semester = new HashSet<tbl_student_object_subsidize_semester>();
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
        public string content { get; set; }

        [StringLength(255)]
        public string reason { get; set; }

        [StringLength(255)]
        public string reward_decree_number { get; set; }

        [StringLength(255)]
        public string reward_format { get; set; }

        [StringLength(255)]
        public string reward_level { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? sign_date { get; set; }

        [StringLength(255)]
        public string signer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_reward> tbl_enrollment_class_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_reward> tbl_student_reward { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_object_subsidize_semester> tbl_student_object_subsidize_semester { get; set; }
    }
}

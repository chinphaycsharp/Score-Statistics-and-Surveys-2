namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_user()
        {
            tbl_organization_user = new HashSet<tbl_organization_user>();
            tbl_person = new HashSet<tbl_person>();
            tbl_role_tution_enrollment_class = new HashSet<tbl_role_tution_enrollment_class>();
            tbl_student_candidate_profile = new HashSet<tbl_student_candidate_profile>();
            tbl_user_trainning_base = new HashSet<tbl_user_trainning_base>();
            tbl_role = new HashSet<tbl_role>();
            tbl_user_group = new HashSet<tbl_user_group>();
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

        public bool? account_non_expired { get; set; }

        public bool? account_non_locked { get; set; }

        public bool active { get; set; }

        public bool? credentials_non_expired { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        public bool just_created { get; set; }

        public long? last_login_failures { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? last_login_time { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        public long? total_login_failures { get; set; }

        [Required]
        [StringLength(100)]
        public string username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_organization_user> tbl_organization_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_person> tbl_person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_role_tution_enrollment_class> tbl_role_tution_enrollment_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_candidate_profile> tbl_student_candidate_profile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user_trainning_base> tbl_user_trainning_base { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_role> tbl_role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user_group> tbl_user_group { get; set; }
    }
}

namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_person()
        {
            tbl_calendar_event = new HashSet<tbl_calendar_event>();
            tbl_calendar_event1 = new HashSet<tbl_calendar_event>();
            tbl_person_address = new HashSet<tbl_person_address>();
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
        public string email { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? birth_date { get; set; }

        [StringLength(255)]
        public string birth_place { get; set; }

        [StringLength(255)]
        public string carrer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? communist_party_join_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? communist_youth_union_join_date { get; set; }

        [StringLength(255)]
        public string display_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        [StringLength(255)]
        public string first_name { get; set; }

        [StringLength(255)]
        public string gender { get; set; }

        [StringLength(255)]
        public string id_number { get; set; }

        [StringLength(255)]
        public string id_number_issue_by { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? id_number_issue_date { get; set; }

        [StringLength(255)]
        public string image_path { get; set; }

        public bool? is_dead { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        public int? marital_status { get; set; }

        [StringLength(255)]
        public string phone_number { get; set; }

        public bool? photo_cropped { get; set; }

        [StringLength(255)]
        public string short_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        public long? ethnics_id { get; set; }

        public long? family_social_class_id { get; set; }

        public long? family_social_priority_id { get; set; }

        public long? country_id { get; set; }

        public long? native_village { get; set; }

        public long? personal_social_priority_id { get; set; }

        public long? religion_id { get; set; }

        public long? user_id { get; set; }

        public byte[] photo { get; set; }

        [StringLength(255)]
        public string create_ip { get; set; }

        [StringLength(255)]
        public string modify_ip { get; set; }

        public virtual tbl_administrative_unit tbl_administrative_unit { get; set; }

        public virtual tbl_budget_distribution tbl_budget_distribution { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event> tbl_calendar_event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event> tbl_calendar_event1 { get; set; }

        public virtual tbl_country tbl_country { get; set; }

        public virtual tbl_ethnics tbl_ethnics { get; set; }

        public virtual tbl_social_priority tbl_social_priority { get; set; }

        public virtual tbl_social_priority tbl_social_priority1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_person_address> tbl_person_address { get; set; }

        public virtual tbl_religion tbl_religion { get; set; }

        public virtual tbl_social_class tbl_social_class { get; set; }

        public virtual tbl_user tbl_user { get; set; }
    }
}

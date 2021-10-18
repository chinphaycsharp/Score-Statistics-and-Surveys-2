namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_calendar_event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_calendar_event()
        {
            tbl_calendar_event_attachment = new HashSet<tbl_calendar_event_attachment>();
            tbl_calendar_event_car = new HashSet<tbl_calendar_event_car>();
            tbl_calendar_event_attendee = new HashSet<tbl_calendar_event_attendee>();
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

        public bool car_registered { get; set; }

        [StringLength(255)]
        public string chair_person_name { get; set; }

        [StringLength(255)]
        public string content_by { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? duplicate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_time { get; set; }

        public int event_type { get; set; }

        public bool is_other_chair_person { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(255)]
        public string last_update_person_name { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? origin_end_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? origin_start_time { get; set; }

        [StringLength(255)]
        public string other_attendees { get; set; }

        public bool other_location { get; set; }

        public int? persons_require_travelling { get; set; }

        public int scope { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_time { get; set; }

        public int event_status { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        public long? person_creator_id { get; set; }

        public long? dep_creator_id { get; set; }

        public long? owner_department_id { get; set; }

        public long? owner_person_id { get; set; }

        public long? priority_id { get; set; }

        public long? room_id { get; set; }

        public virtual tbl_calendar_event_priority tbl_calendar_event_priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event_attachment> tbl_calendar_event_attachment { get; set; }

        public virtual tbl_person tbl_person { get; set; }

        public virtual tbl_person tbl_person1 { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event_car> tbl_calendar_event_car { get; set; }

        public virtual tbl_department tbl_department1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event_attendee> tbl_calendar_event_attendee { get; set; }

        public virtual tbl_room tbl_room { get; set; }
    }
}

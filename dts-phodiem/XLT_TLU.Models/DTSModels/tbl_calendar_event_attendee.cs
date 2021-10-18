namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_calendar_event_attendee
    {
        public long id { get; set; }

        public int? attendee_type { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime create_date { get; set; }

        [Required]
        [StringLength(100)]
        public string created_by { get; set; }

        [StringLength(255)]
        public string display_name { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public bool? is_chair_person { get; set; }

        public bool? optional { get; set; }

        [StringLength(100)]
        public string modified_by { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? modify_date { get; set; }

        public int? visibility { get; set; }

        public long? department_id { get; set; }

        public long event_id { get; set; }

        public long? staff_id { get; set; }

        public virtual tbl_calendar_event tbl_calendar_event { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }

        public virtual tbl_department tbl_department { get; set; }
    }
}

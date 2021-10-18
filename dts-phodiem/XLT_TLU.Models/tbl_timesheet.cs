namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_timesheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_timesheet()
        {
            tbl_timesheet_detail = new HashSet<tbl_timesheet_detail>();
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

        public int? approve_status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_time { get; set; }

        public double? total_hours { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? working_date { get; set; }

        public long? employee_id { get; set; }

        public long? shift_work_id { get; set; }

        public long? working_status_id { get; set; }

        public virtual tbl_shift_work tbl_shift_work { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_timesheet_detail> tbl_timesheet_detail { get; set; }

        public virtual tbl_working_status tbl_working_status { get; set; }
    }
}

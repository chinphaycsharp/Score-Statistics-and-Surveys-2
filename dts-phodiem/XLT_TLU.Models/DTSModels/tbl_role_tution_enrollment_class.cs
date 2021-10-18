namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_role_tution_enrollment_class
    {
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

        public bool? is_calculate { get; set; }

        public bool? is_delete { get; set; }

        public bool? is_edit { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        public bool? is_input { get; set; }

        public bool? is_search { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        public bool? is_withdraw { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? staff_id { get; set; }

        public long? user_id { get; set; }

        public bool? lock_coefficient { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_user tbl_user { get; set; }

        public virtual tbl_staff tbl_staff { get; set; }
    }
}

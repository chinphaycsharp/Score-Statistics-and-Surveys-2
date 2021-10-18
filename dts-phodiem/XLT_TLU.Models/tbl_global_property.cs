namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_global_property
    {
        [Key]
        [StringLength(255)]
        public string property { get; set; }

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
        public string data_type_name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string property_name { get; set; }

        [StringLength(255)]
        public string property_value { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date_value { get; set; }

        public double? numberic_value { get; set; }

        public bool? boolean_value { get; set; }
    }
}

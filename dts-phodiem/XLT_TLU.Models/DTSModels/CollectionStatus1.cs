namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CollectionStatus1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        public string StudentCode { get; set; }

        public int? DocumentId { get; set; }

        public bool? Status { get; set; }

        public int? DisplayOrder { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(100)]
        public string CreatedUser { get; set; }

        [StringLength(100)]
        public string ModifiedUser { get; set; }

        public bool? IsDeleted { get; set; }
    }
}

namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_admission_infomation
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

        [Column(TypeName = "datetime2")]
        public DateTime? birthDate { get; set; }

        [StringLength(255)]
        public string blockSubjectCode { get; set; }

        public int? candidateArea { get; set; }

        [StringLength(255)]
        public string candidateCodeType { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        public double? coefficient1 { get; set; }

        public double? coefficient2 { get; set; }

        public double? coefficient3 { get; set; }

        public double? coefficient4 { get; set; }

        [StringLength(255)]
        public string fullName { get; set; }

        public double? mark1 { get; set; }

        public double? mark2 { get; set; }

        public double? mark3 { get; set; }

        public double? mark4 { get; set; }

        [StringLength(255)]
        public string subjectName1 { get; set; }

        [StringLength(255)]
        public string subjectName2 { get; set; }

        [StringLength(255)]
        public string subjectName3 { get; set; }

        [StringLength(255)]
        public string subjectName4 { get; set; }
    }
}

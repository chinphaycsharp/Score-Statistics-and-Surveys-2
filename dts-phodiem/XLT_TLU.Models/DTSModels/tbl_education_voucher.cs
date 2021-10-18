namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_education_voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_education_voucher()
        {
            tbl_voucher_recieve_pay_able = new HashSet<tbl_voucher_recieve_pay_able>();
            tbl_education_voucher_detail = new HashSet<tbl_education_voucher_detail>();
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
        public string code { get; set; }

        public int? is_receive { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public int? payment_method { get; set; }

        public int? status { get; set; }

        public double? total_amount { get; set; }

        public double? total_recived_amount { get; set; }

        public int? type { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? voucher_date { get; set; }

        public long? period_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        public long? training_base_id { get; set; }

        [StringLength(255)]
        public string number_book { get; set; }

        public bool? view_able { get; set; }

        [StringLength(255)]
        public string bank_import_code { get; set; }

        public long? course_year_id { get; set; }

        public long? department_id { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? speciality_id { get; set; }

        public int? isReceive { get; set; }

        public int? paymentMethod { get; set; }

        public double? totalAmount { get; set; }

        public double? totalReceivedAmount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? voucherDate { get; set; }

        public long? education_program_id { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        public virtual tbl_education_program tbl_education_program { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_recieve_pay_able> tbl_voucher_recieve_pay_able { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher_detail> tbl_education_voucher_detail { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

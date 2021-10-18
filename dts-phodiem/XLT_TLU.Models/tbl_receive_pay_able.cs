namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_receive_pay_able
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_receive_pay_able()
        {
            tbl_education_voucher_detail = new HashSet<tbl_education_voucher_detail>();
            tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
            tbl_student_tuition_fee_calculate = new HashSet<tbl_student_tuition_fee_calculate>();
            tbl_student_scholarship_history = new HashSet<tbl_student_scholarship_history>();
            tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
            tbl_receive_pay_able1 = new HashSet<tbl_receive_pay_able>();
            tbl_student_course_subject_cancel_fee = new HashSet<tbl_student_course_subject_cancel_fee>();
            tbl_voucher_recieve_pay_able = new HashSet<tbl_voucher_recieve_pay_able>();
            tbl_student_fee_calculate = new HashSet<tbl_student_fee_calculate>();
            tbl_voucher_detail_recieve_pay_able_link = new HashSet<tbl_voucher_detail_recieve_pay_able_link>();
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

        public double? amount { get; set; }

        public double? amount_after_balance { get; set; }

        public double? amount_done { get; set; }

        public double? amount_received { get; set; }

        public bool? is_complete { get; set; }

        public int? is_receive { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? receivable_date { get; set; }

        public int? status { get; set; }

        public double? transfer_value { get; set; }

        public int? type { get; set; }

        public double? withdrawal_value { get; set; }

        public long? adjusted_receive_pay_able_id { get; set; }

        public long? register_period_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? last_pay_date { get; set; }

        public long? course_year_id { get; set; }

        public long? department_id { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? speciality_id { get; set; }

        public long? training_base_id { get; set; }

        public int? isReceive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? receivPayAbleDate { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher_detail> tbl_education_voucher_detail { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_history> tbl_student_scholarship_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able1 { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able2 { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_recieve_pay_able> tbl_voucher_recieve_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_fee_calculate> tbl_student_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_detail_recieve_pay_able_link> tbl_voucher_detail_recieve_pay_able_link { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }

        public virtual tbl_student tbl_student { get; set; }
    }
}

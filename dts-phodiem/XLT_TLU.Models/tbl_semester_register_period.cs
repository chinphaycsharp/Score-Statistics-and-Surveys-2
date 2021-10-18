namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_semester_register_period
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_semester_register_period()
        {
            tbl_education_fee_config = new HashSet<tbl_education_fee_config>();
            tbl_education_program_tuition_fee = new HashSet<tbl_education_program_tuition_fee>();
            tbl_education_voucher = new HashSet<tbl_education_voucher>();
            tbl_exam_register_period = new HashSet<tbl_exam_register_period>();
            tbl_expectation_register = new HashSet<tbl_expectation_register>();
            tbl_inventory_item = new HashSet<tbl_inventory_item>();
            tbl_receive_pay_able = new HashSet<tbl_receive_pay_able>();
            tbl_register_period_time_config = new HashSet<tbl_register_period_time_config>();
            tbl_semester_exam_period = new HashSet<tbl_semester_exam_period>();
            tbl_student_fee_calculate = new HashSet<tbl_student_fee_calculate>();
            tbl_semester_subject = new HashSet<tbl_semester_subject>();
            tbl_student_tuition_fee_calculate = new HashSet<tbl_student_tuition_fee_calculate>();
            tbl_student_course_subject_edited = new HashSet<tbl_student_course_subject_edited>();
            tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
            tbl_student_register_change = new HashSet<tbl_student_register_change>();
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

        public int? display_order { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_register_time { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_unregister_time { get; set; }

        public bool? is_lock_register { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_register_time { get; set; }

        public long? semeter_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_fee_config> tbl_education_fee_config { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher> tbl_education_voucher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_exam_register_period> tbl_exam_register_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_expectation_register> tbl_expectation_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_register_period_time_config> tbl_register_period_time_config { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_exam_period> tbl_semester_exam_period { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_fee_calculate> tbl_student_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject> tbl_semester_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_edited> tbl_student_course_subject_edited { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_register_change> tbl_student_register_change { get; set; }
    }
}

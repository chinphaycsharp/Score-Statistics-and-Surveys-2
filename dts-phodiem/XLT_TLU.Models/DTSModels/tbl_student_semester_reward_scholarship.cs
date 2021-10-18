namespace XLT_TLU.Models.DTSModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_semester_reward_scholarship
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_semester_reward_scholarship()
        {
            tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
            tbl_student_scholarship_history = new HashSet<tbl_student_scholarship_history>();
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

        public double? behavior_mark { get; set; }

        [StringLength(255)]
        public string behavior_mark_char { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date_forward { get; set; }

        public double? first_amount { get; set; }

        public bool? is_forward { get; set; }

        public bool? is_lock { get; set; }

        public double? last_amount { get; set; }

        public int? level { get; set; }

        public double? mark { get; set; }

        public double? mark4 { get; set; }

        public double? mark4_advanced { get; set; }

        public double? mark_advanced { get; set; }

        public int? number_of_credit { get; set; }

        public int? status { get; set; }

        public double? tuition_balance { get; set; }

        public int? type { get; set; }

        public long? receive_pay_able_id { get; set; }

        public long? scholarship_condition_id { get; set; }

        public long? scholarship_fund_id { get; set; }

        public long? semester_id { get; set; }

        public long? student_id { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date_lock { get; set; }

        public long? course_year_id { get; set; }

        public long? department_id { get; set; }

        public long? enrollment_class_id { get; set; }

        public long? speciality_id { get; set; }

        public long? training_base_id { get; set; }

        public double? done_amount { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_department tbl_department { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }

        public virtual tbl_scholarship_condition tbl_scholarship_condition { get; set; }

        public virtual tbl_scholarship_fund tbl_scholarship_fund { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        public virtual tbl_student tbl_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_history> tbl_student_scholarship_history { get; set; }

        public virtual tbl_training_base tbl_training_base { get; set; }
    }
}

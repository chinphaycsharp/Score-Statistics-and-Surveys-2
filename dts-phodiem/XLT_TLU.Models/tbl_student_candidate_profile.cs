namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_student_candidate_profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_candidate_profile()
        {
            tbl_student = new HashSet<tbl_student>();
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
        public string admission { get; set; }

        [StringLength(255)]
        public string admission_combination { get; set; }

        [StringLength(255)]
        public string admissions_committee { get; set; }

        public int? admissions_year { get; set; }

        [StringLength(255)]
        public string area { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? birth_date { get; set; }

        [StringLength(255)]
        public string candidate_code { get; set; }

        public bool? check_admission_fee { get; set; }

        [StringLength(255)]
        public string contact_address { get; set; }

        [StringLength(255)]
        public string district_code { get; set; }

        public double? dtc0 { get; set; }

        [StringLength(255)]
        public string exam_room { get; set; }

        [StringLength(255)]
        public string first_group { get; set; }

        [StringLength(255)]
        public string first_name { get; set; }

        [StringLength(255)]
        public string first_school { get; set; }

        [StringLength(255)]
        public string first_speciality_code { get; set; }

        [StringLength(255)]
        public string first_speciality_detail_code { get; set; }

        public double? first_subject_name { get; set; }

        public double? first_subject_score { get; set; }

        [StringLength(255)]
        public string gender { get; set; }

        [StringLength(255)]
        public string grade_eleven { get; set; }

        [StringLength(255)]
        public string grade_ten { get; set; }

        [StringLength(255)]
        public string grade_twelve { get; set; }

        [StringLength(255)]
        public string high_school_conduct { get; set; }

        [StringLength(255)]
        public string high_school_grade { get; set; }

        [StringLength(255)]
        public string high_school_graduation { get; set; }

        [StringLength(255)]
        public string high_school_graduation_place { get; set; }

        public int? high_school_graduation_year { get; set; }

        [StringLength(255)]
        public string id_number { get; set; }

        public bool? confirm_admission { get; set; }

        public bool? recruited_directly { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [StringLength(255)]
        public string phone_number { get; set; }

        [StringLength(255)]
        public string priority_group { get; set; }

        [StringLength(255)]
        public string province_code { get; set; }

        [StringLength(255)]
        public string reason { get; set; }

        [StringLength(255)]
        public string second_group { get; set; }

        [StringLength(255)]
        public string second_school { get; set; }

        [StringLength(255)]
        public string second_speciality_code { get; set; }

        public double? second_subject_name { get; set; }

        public double? second_subject_score { get; set; }

        [StringLength(255)]
        public string stage { get; set; }

        [StringLength(255)]
        public string student_code { get; set; }

        [StringLength(255)]
        public string student_object_code { get; set; }

        public double? third_subject_name { get; set; }

        public double? third_subject_score { get; set; }

        public double? total_score { get; set; }

        public long? training_base_id { get; set; }

        [StringLength(255)]
        public string training_units { get; set; }

        public long? address_unit_id { get; set; }

        public long? course_year_id { get; set; }

        public long? education_type_id { get; set; }

        public long? enrollment_class_id { get; set; }

        [StringLength(255)]
        public string current_whereabouts { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string ethnic { get; set; }

        [StringLength(255)]
        public string father_name { get; set; }

        [StringLength(255)]
        public string father_phone_number { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? id_number_date_of_issue { get; set; }

        [StringLength(255)]
        public string id_number_place_of_issue { get; set; }

        [StringLength(255)]
        public string mother_name { get; set; }

        [StringLength(255)]
        public string mother_phone_number { get; set; }

        [StringLength(255)]
        public string native_village { get; set; }

        [StringLength(255)]
        public string place_of_birth { get; set; }

        [StringLength(255)]
        public string place_of_permanent_residence_registration { get; set; }

        [StringLength(255)]
        public string religion { get; set; }

        public long? student_id { get; set; }

        [StringLength(255)]
        public string address_little_brother2 { get; set; }

        [StringLength(255)]
        public string address_old_brother1 { get; set; }

        [StringLength(255)]
        public string address_old_brother2 { get; set; }

        [StringLength(255)]
        public string address_old_brother3 { get; set; }

        [StringLength(255)]
        public string address_old_sister1 { get; set; }

        [StringLength(255)]
        public string address_old_sister2 { get; set; }

        [StringLength(255)]
        public string address_old_sister3 { get; set; }

        [StringLength(255)]
        public string address_little_brother1 { get; set; }

        [StringLength(255)]
        public string address_little_brother3 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? communist_adminssion_date { get; set; }

        [StringLength(255)]
        public string communist_adminssion_place { get; set; }

        [StringLength(255)]
        public string country_code { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? father_date_of_birth { get; set; }

        [StringLength(255)]
        public string father_job { get; set; }

        public int? father_year_of_birth { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? group_admission_date { get; set; }

        [StringLength(255)]
        public string group_admission_place { get; set; }

        public bool? is_confirm { get; set; }

        [StringLength(255)]
        public string link_fb { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? mother_date_of_birth { get; set; }

        [StringLength(255)]
        public string mother_job { get; set; }

        public int? mother_year_of_birth { get; set; }

        [StringLength(255)]
        public string name_little_brother1 { get; set; }

        [StringLength(255)]
        public string name_little_brother2 { get; set; }

        [StringLength(255)]
        public string name_little_brother3 { get; set; }

        [StringLength(255)]
        public string name_old_brother1 { get; set; }

        [StringLength(255)]
        public string name_old_brother2 { get; set; }

        [StringLength(255)]
        public string name_old_brother3 { get; set; }

        [StringLength(255)]
        public string name_old_sister1 { get; set; }

        [StringLength(255)]
        public string name_old_sister2 { get; set; }

        [StringLength(255)]
        public string name_old_sister3 { get; set; }

        [StringLength(255)]
        public string ward_code { get; set; }

        [StringLength(255)]
        public string ward_name { get; set; }

        [StringLength(255)]
        public string wishToEnroll1 { get; set; }

        [StringLength(255)]
        public string wishToEnroll2 { get; set; }

        [StringLength(255)]
        public string wishToEnroll3 { get; set; }

        [StringLength(255)]
        public string wishToEnroll4 { get; set; }

        public int? year_little_Brother1 { get; set; }

        public int? year_little_Brother2 { get; set; }

        public int? year_little_Brother3 { get; set; }

        public int? year_old_brother1 { get; set; }

        public int? year_old_brother2 { get; set; }

        public int? year_old_brother3 { get; set; }

        public int? year_old_sister1 { get; set; }

        public int? year_old_sister2 { get; set; }

        public int? year_old_sister3 { get; set; }

        public long? country_id { get; set; }

        public long? district_id { get; set; }

        public long? ethnics_id { get; set; }

        public long? province_id { get; set; }

        public long? religion_id { get; set; }

        public long? student_object_id { get; set; }

        public long? user_id { get; set; }

        public long? ward_id { get; set; }

        [StringLength(255)]
        public string insurance_card_code { get; set; }

        [StringLength(255)]
        public string district_name { get; set; }

        [StringLength(255)]
        public string province_name { get; set; }

        [StringLength(255)]
        public string father_address { get; set; }

        [StringLength(255)]
        public string mother_address { get; set; }

        [StringLength(255)]
        public string first_name_subject { get; set; }

        [StringLength(255)]
        public string second_name_subject { get; set; }

        [StringLength(255)]
        public string third_name_subject { get; set; }

        [StringLength(255)]
        public string military_service_reg_code { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? military_service_reg_date { get; set; }

        [StringLength(255)]
        public string public_address { get; set; }

        public virtual tbl_administrative_unit tbl_administrative_unit { get; set; }

        public virtual tbl_administrative_unit tbl_administrative_unit1 { get; set; }

        public virtual tbl_administrative_unit tbl_administrative_unit2 { get; set; }

        public virtual tbl_administrative_unit tbl_administrative_unit3 { get; set; }

        public virtual tbl_country tbl_country { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_education_type tbl_education_type { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_ethnics tbl_ethnics { get; set; }

        public virtual tbl_religion tbl_religion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student> tbl_student { get; set; }

        public virtual tbl_student tbl_student1 { get; set; }

        public virtual tbl_user tbl_user { get; set; }

        public virtual tbl_student_object tbl_student_object { get; set; }
    }
}

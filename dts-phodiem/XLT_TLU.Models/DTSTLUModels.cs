using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace XLT_TLU.Models
{
    public partial class DTSTLUModels : DbContext
    {
        public DTSTLUModels()
            : base("name=DTSTLUModels")
        {
        }

        public virtual DbSet<CollectionStatus> CollectionStatus { get; set; }
        public virtual DbSet<oauth_access_token> oauth_access_token { get; set; }
        public virtual DbSet<oauth_client_details> oauth_client_details { get; set; }
        public virtual DbSet<student_admission_infomation> student_admission_infomation { get; set; }
        public virtual DbSet<StudentDocument> StudentDocument { get; set; }
        public virtual DbSet<StudentDocument2019> StudentDocument2019 { get; set; }
        public virtual DbSet<tbl__student_student_group> tbl__student_student_group { get; set; }
        public virtual DbSet<tbl_academic_title> tbl_academic_title { get; set; }
        public virtual DbSet<tbl_activity_log> tbl_activity_log { get; set; }
        public virtual DbSet<tbl_administrative_unit> tbl_administrative_unit { get; set; }
        public virtual DbSet<tbl_behavior_mark_classification_standard> tbl_behavior_mark_classification_standard { get; set; }
        public virtual DbSet<tbl_behavior_mark_criteria> tbl_behavior_mark_criteria { get; set; }
        public virtual DbSet<tbl_budget_distribution> tbl_budget_distribution { get; set; }
        public virtual DbSet<tbl_building> tbl_building { get; set; }
        public virtual DbSet<tbl_calendar_event> tbl_calendar_event { get; set; }
        public virtual DbSet<tbl_calendar_event_attachment> tbl_calendar_event_attachment { get; set; }
        public virtual DbSet<tbl_calendar_event_attendee> tbl_calendar_event_attendee { get; set; }
        public virtual DbSet<tbl_calendar_event_car> tbl_calendar_event_car { get; set; }
        public virtual DbSet<tbl_calendar_event_priority> tbl_calendar_event_priority { get; set; }
        public virtual DbSet<tbl_certificate> tbl_certificate { get; set; }
        public virtual DbSet<tbl_civil_servant_category> tbl_civil_servant_category { get; set; }
        public virtual DbSet<tbl_civil_servant_category_grade> tbl_civil_servant_category_grade { get; set; }
        public virtual DbSet<tbl_civil_servant_grade> tbl_civil_servant_grade { get; set; }
        public virtual DbSet<tbl_classification> tbl_classification { get; set; }
        public virtual DbSet<tbl_country> tbl_country { get; set; }
        public virtual DbSet<tbl_course_hour> tbl_course_hour { get; set; }
        public virtual DbSet<tbl_course_subject> tbl_course_subject { get; set; }
        public virtual DbSet<tbl_course_subject_config> tbl_course_subject_config { get; set; }
        public virtual DbSet<tbl_course_subject_subject_exam_formula> tbl_course_subject_subject_exam_formula { get; set; }
        public virtual DbSet<tbl_course_subject_timetable> tbl_course_subject_timetable { get; set; }
        public virtual DbSet<tbl_course_year> tbl_course_year { get; set; }
        public virtual DbSet<tbl_criteria_search_student> tbl_criteria_search_student { get; set; }
        public virtual DbSet<tbl_criteria_search_student_except_subject> tbl_criteria_search_student_except_subject { get; set; }
        public virtual DbSet<tbl_decision> tbl_decision { get; set; }
        public virtual DbSet<tbl_degree_student> tbl_degree_student { get; set; }
        public virtual DbSet<tbl_department> tbl_department { get; set; }
        public virtual DbSet<tbl_discipline> tbl_discipline { get; set; }
        public virtual DbSet<tbl_discount_tuition_fee> tbl_discount_tuition_fee { get; set; }
        public virtual DbSet<tbl_discount_tuition_fee_item> tbl_discount_tuition_fee_item { get; set; }
        public virtual DbSet<tbl_education_degree> tbl_education_degree { get; set; }
        public virtual DbSet<tbl_education_fee_config> tbl_education_fee_config { get; set; }
        public virtual DbSet<tbl_education_level> tbl_education_level { get; set; }
        public virtual DbSet<tbl_education_program> tbl_education_program { get; set; }
        public virtual DbSet<tbl_education_program_number_of_credit> tbl_education_program_number_of_credit { get; set; }
        public virtual DbSet<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }
        public virtual DbSet<tbl_education_type> tbl_education_type { get; set; }
        public virtual DbSet<tbl_education_voucher> tbl_education_voucher { get; set; }
        public virtual DbSet<tbl_education_voucher_detail> tbl_education_voucher_detail { get; set; }
        public virtual DbSet<tbl_enrollment_class> tbl_enrollment_class { get; set; }
        public virtual DbSet<tbl_enrollment_class_history> tbl_enrollment_class_history { get; set; }
        public virtual DbSet<tbl_enrollment_class_reward> tbl_enrollment_class_reward { get; set; }
        public virtual DbSet<tbl_enrollment_class_reward_condition> tbl_enrollment_class_reward_condition { get; set; }
        public virtual DbSet<tbl_enrollment_class_staff> tbl_enrollment_class_staff { get; set; }
        public virtual DbSet<tbl_equivalent_subject> tbl_equivalent_subject { get; set; }
        public virtual DbSet<tbl_ethnics> tbl_ethnics { get; set; }
        public virtual DbSet<tbl_exam> tbl_exam { get; set; }
        public virtual DbSet<tbl_exam_date> tbl_exam_date { get; set; }
        public virtual DbSet<tbl_exam_hour> tbl_exam_hour { get; set; }
        public virtual DbSet<tbl_exam_register_period> tbl_exam_register_period { get; set; }
        public virtual DbSet<tbl_exam_room_period> tbl_exam_room_period { get; set; }
        public virtual DbSet<tbl_exam_skill> tbl_exam_skill { get; set; }
        public virtual DbSet<tbl_exam_status> tbl_exam_status { get; set; }
        public virtual DbSet<tbl_exam_type> tbl_exam_type { get; set; }
        public virtual DbSet<tbl_expectation_register> tbl_expectation_register { get; set; }
        public virtual DbSet<tbl_fee_config_item> tbl_fee_config_item { get; set; }
        public virtual DbSet<tbl_fee_item> tbl_fee_item { get; set; }
        public virtual DbSet<tbl_fee_item_detail> tbl_fee_item_detail { get; set; }
        public virtual DbSet<tbl_file_description> tbl_file_description { get; set; }
        public virtual DbSet<tbl_global_property> tbl_global_property { get; set; }
        public virtual DbSet<tbl_graduation_period> tbl_graduation_period { get; set; }
        public virtual DbSet<tbl_group_subject_program> tbl_group_subject_program { get; set; }
        public virtual DbSet<tbl_inventory_item> tbl_inventory_item { get; set; }
        public virtual DbSet<tbl_knowledge_block> tbl_knowledge_block { get; set; }
        public virtual DbSet<tbl_knowledge_program> tbl_knowledge_program { get; set; }
        public virtual DbSet<tbl_labour_agreement_type> tbl_labour_agreement_type { get; set; }
        public virtual DbSet<tbl_learning_skill> tbl_learning_skill { get; set; }
        public virtual DbSet<tbl_location> tbl_location { get; set; }
        public virtual DbSet<tbl_mark_type> tbl_mark_type { get; set; }
        public virtual DbSet<tbl_organization> tbl_organization { get; set; }
        public virtual DbSet<tbl_organization_user> tbl_organization_user { get; set; }
        public virtual DbSet<tbl_overtime_type> tbl_overtime_type { get; set; }
        public virtual DbSet<tbl_payroll_period> tbl_payroll_period { get; set; }
        public virtual DbSet<tbl_person> tbl_person { get; set; }
        public virtual DbSet<tbl_person_address> tbl_person_address { get; set; }
        public virtual DbSet<tbl_position> tbl_position { get; set; }
        public virtual DbSet<tbl_position_staff> tbl_position_staff { get; set; }
        public virtual DbSet<tbl_position_title> tbl_position_title { get; set; }
        public virtual DbSet<tbl_prerequisite_subject> tbl_prerequisite_subject { get; set; }
        public virtual DbSet<tbl_profession> tbl_profession { get; set; }
        public virtual DbSet<tbl_program_subject> tbl_program_subject { get; set; }
        public virtual DbSet<tbl_program_subject_semester> tbl_program_subject_semester { get; set; }
        public virtual DbSet<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }
        public virtual DbSet<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }
        public virtual DbSet<tbl_reg_student_course_subject> tbl_reg_student_course_subject { get; set; }
        public virtual DbSet<tbl_reg_student_subject> tbl_reg_student_subject { get; set; }
        public virtual DbSet<tbl_register_period_time_config> tbl_register_period_time_config { get; set; }
        public virtual DbSet<tbl_religion> tbl_religion { get; set; }
        public virtual DbSet<tbl_reward> tbl_reward { get; set; }
        public virtual DbSet<tbl_reward_decree> tbl_reward_decree { get; set; }
        public virtual DbSet<tbl_role> tbl_role { get; set; }
        public virtual DbSet<tbl_role_tution_enrollment_class> tbl_role_tution_enrollment_class { get; set; }
        public virtual DbSet<tbl_room> tbl_room { get; set; }
        public virtual DbSet<tbl_salary_config> tbl_salary_config { get; set; }
        public virtual DbSet<tbl_salary_config_item> tbl_salary_config_item { get; set; }
        public virtual DbSet<tbl_salary_increment_type> tbl_salary_increment_type { get; set; }
        public virtual DbSet<tbl_salary_item> tbl_salary_item { get; set; }
        public virtual DbSet<tbl_scholarship_condition> tbl_scholarship_condition { get; set; }
        public virtual DbSet<tbl_scholarship_fund> tbl_scholarship_fund { get; set; }
        public virtual DbSet<tbl_scholarship_fund_type> tbl_scholarship_fund_type { get; set; }
        public virtual DbSet<tbl_school_fee_config> tbl_school_fee_config { get; set; }
        public virtual DbSet<tbl_semester> tbl_semester { get; set; }
        public virtual DbSet<tbl_semester_exam_period> tbl_semester_exam_period { get; set; }
        public virtual DbSet<tbl_semester_register_period> tbl_semester_register_period { get; set; }
        public virtual DbSet<tbl_semester_subject> tbl_semester_subject { get; set; }
        public virtual DbSet<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }
        public virtual DbSet<tbl_semester_subject_exam_course_subject> tbl_semester_subject_exam_course_subject { get; set; }
        public virtual DbSet<tbl_semester_subject_exam_date> tbl_semester_subject_exam_date { get; set; }
        public virtual DbSet<tbl_semester_subject_exam_hour> tbl_semester_subject_exam_hour { get; set; }
        public virtual DbSet<tbl_semester_subject_exam_hour_room> tbl_semester_subject_exam_hour_room { get; set; }
        public virtual DbSet<tbl_semester_subject_exam_room> tbl_semester_subject_exam_room { get; set; }
        public virtual DbSet<tbl_semester_subject_learning_skill> tbl_semester_subject_learning_skill { get; set; }
        public virtual DbSet<tbl_shift_work> tbl_shift_work { get; set; }
        public virtual DbSet<tbl_shift_work_time_period> tbl_shift_work_time_period { get; set; }
        public virtual DbSet<tbl_shool_year> tbl_shool_year { get; set; }
        public virtual DbSet<tbl_social_class> tbl_social_class { get; set; }
        public virtual DbSet<tbl_social_priority> tbl_social_priority { get; set; }
        public virtual DbSet<tbl_special_point> tbl_special_point { get; set; }
        public virtual DbSet<tbl_speciality> tbl_speciality { get; set; }
        public virtual DbSet<tbl_speciality_program> tbl_speciality_program { get; set; }
        public virtual DbSet<tbl_specialty_admissions_map> tbl_specialty_admissions_map { get; set; }
        public virtual DbSet<tbl_staff> tbl_staff { get; set; }
        public virtual DbSet<tbl_staff_allowance_history> tbl_staff_allowance_history { get; set; }
        public virtual DbSet<tbl_staff_civil_servant_grade> tbl_staff_civil_servant_grade { get; set; }
        public virtual DbSet<tbl_staff_disciplinary_history> tbl_staff_disciplinary_history { get; set; }
        public virtual DbSet<tbl_staff_education_history> tbl_staff_education_history { get; set; }
        public virtual DbSet<tbl_staff_family_relationship> tbl_staff_family_relationship { get; set; }
        public virtual DbSet<tbl_staff_labour_agreement> tbl_staff_labour_agreement { get; set; }
        public virtual DbSet<tbl_staff_labour_agreement_attachment> tbl_staff_labour_agreement_attachment { get; set; }
        public virtual DbSet<tbl_staff_reward_history> tbl_staff_reward_history { get; set; }
        public virtual DbSet<tbl_staff_salary_history> tbl_staff_salary_history { get; set; }
        public virtual DbSet<tbl_staff_salary_property> tbl_staff_salary_property { get; set; }
        public virtual DbSet<tbl_staff_travelling_history> tbl_staff_travelling_history { get; set; }
        public virtual DbSet<tbl_staff_work_schedule> tbl_staff_work_schedule { get; set; }
        public virtual DbSet<tbl_status> tbl_status { get; set; }
        public virtual DbSet<tbl_student> tbl_student { get; set; }
        public virtual DbSet<tbl_student_behavior_criteria_mark> tbl_student_behavior_criteria_mark { get; set; }
        public virtual DbSet<tbl_student_call_roll> tbl_student_call_roll { get; set; }
        public virtual DbSet<tbl_student_candidate_profile> tbl_student_candidate_profile { get; set; }
        public virtual DbSet<tbl_student_certificate> tbl_student_certificate { get; set; }
        public virtual DbSet<tbl_student_code_key> tbl_student_code_key { get; set; }
        public virtual DbSet<tbl_student_course_subject> tbl_student_course_subject { get; set; }
        public virtual DbSet<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }
        public virtual DbSet<tbl_student_course_subject_edited> tbl_student_course_subject_edited { get; set; }
        public virtual DbSet<tbl_student_course_subject_history> tbl_student_course_subject_history { get; set; }
        public virtual DbSet<tbl_student_decision> tbl_student_decision { get; set; }
        public virtual DbSet<tbl_student_decision_type> tbl_student_decision_type { get; set; }
        public virtual DbSet<tbl_student_discipline> tbl_student_discipline { get; set; }
        public virtual DbSet<tbl_student_education_program> tbl_student_education_program { get; set; }
        public virtual DbSet<tbl_student_exam_group> tbl_student_exam_group { get; set; }
        public virtual DbSet<tbl_student_expectation_register> tbl_student_expectation_register { get; set; }
        public virtual DbSet<tbl_student_fee_calculate> tbl_student_fee_calculate { get; set; }
        public virtual DbSet<tbl_student_graduate> tbl_student_graduate { get; set; }
        public virtual DbSet<tbl_student_graduate_conditional> tbl_student_graduate_conditional { get; set; }
        public virtual DbSet<tbl_student_group> tbl_student_group { get; set; }
        public virtual DbSet<tbl_student_mark> tbl_student_mark { get; set; }
        public virtual DbSet<tbl_student_not_complete_fee_semester> tbl_student_not_complete_fee_semester { get; set; }
        public virtual DbSet<tbl_student_object> tbl_student_object { get; set; }
        public virtual DbSet<tbl_student_object_policy> tbl_student_object_policy { get; set; }
        public virtual DbSet<tbl_student_object_student> tbl_student_object_student { get; set; }
        public virtual DbSet<tbl_student_object_student_semester> tbl_student_object_student_semester { get; set; }
        public virtual DbSet<tbl_student_object_subsidize> tbl_student_object_subsidize { get; set; }
        public virtual DbSet<tbl_student_object_subsidize_semester> tbl_student_object_subsidize_semester { get; set; }
        public virtual DbSet<tbl_student_other_fee> tbl_student_other_fee { get; set; }
        public virtual DbSet<tbl_student_private_document> tbl_student_private_document { get; set; }
        public virtual DbSet<tbl_student_process_assessment_point> tbl_student_process_assessment_point { get; set; }
        public virtual DbSet<tbl_student_register_change> tbl_student_register_change { get; set; }
        public virtual DbSet<tbl_student_research> tbl_student_research { get; set; }
        public virtual DbSet<tbl_student_reward> tbl_student_reward { get; set; }
        public virtual DbSet<tbl_student_reward_condition> tbl_student_reward_condition { get; set; }
        public virtual DbSet<tbl_student_scholarship_history> tbl_student_scholarship_history { get; set; }
        public virtual DbSet<tbl_student_scholarship_stock> tbl_student_scholarship_stock { get; set; }
        public virtual DbSet<tbl_student_scholarship_stock_detail> tbl_student_scholarship_stock_detail { get; set; }
        public virtual DbSet<tbl_student_school_year_summary_mark> tbl_student_school_year_summary_mark { get; set; }
        public virtual DbSet<tbl_student_semester_behavior_mark> tbl_student_semester_behavior_mark { get; set; }
        public virtual DbSet<tbl_student_semester_behavior_mark_history> tbl_student_semester_behavior_mark_history { get; set; }
        public virtual DbSet<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }
        public virtual DbSet<tbl_student_semester_subject_exam> tbl_student_semester_subject_exam { get; set; }
        public virtual DbSet<tbl_student_semester_subject_exam_room> tbl_student_semester_subject_exam_room { get; set; }
        public virtual DbSet<tbl_student_semester_summary> tbl_student_semester_summary { get; set; }
        public virtual DbSet<tbl_student_semester_summary_mark> tbl_student_semester_summary_mark { get; set; }
        public virtual DbSet<tbl_student_status_student_semester> tbl_student_status_student_semester { get; set; }
        public virtual DbSet<tbl_student_student_private_document> tbl_student_student_private_document { get; set; }
        public virtual DbSet<tbl_student_study_alert_level> tbl_student_study_alert_level { get; set; }
        public virtual DbSet<tbl_student_study_alert_level_lower> tbl_student_study_alert_level_lower { get; set; }
        public virtual DbSet<tbl_student_subject_mark> tbl_student_subject_mark { get; set; }
        public virtual DbSet<tbl_student_summary_mark> tbl_student_summary_mark { get; set; }
        public virtual DbSet<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }
        public virtual DbSet<tbl_student_tuition_fee_calculate_detail> tbl_student_tuition_fee_calculate_detail { get; set; }
        public virtual DbSet<tbl_study_alert_condition> tbl_study_alert_condition { get; set; }
        public virtual DbSet<tbl_study_alert_condition_certificate> tbl_study_alert_condition_certificate { get; set; }
        public virtual DbSet<tbl_study_alert_condition_level> tbl_study_alert_condition_level { get; set; }
        public virtual DbSet<tbl_study_alert_condition_student_object> tbl_study_alert_condition_student_object { get; set; }
        public virtual DbSet<tbl_study_alert_level> tbl_study_alert_level { get; set; }
        public virtual DbSet<tbl_study_alert_running> tbl_study_alert_running { get; set; }
        public virtual DbSet<tbl_subject> tbl_subject { get; set; }
        public virtual DbSet<tbl_subject_education_level_type> tbl_subject_education_level_type { get; set; }
        public virtual DbSet<tbl_subject_exam> tbl_subject_exam { get; set; }
        public virtual DbSet<tbl_subject_exam_type> tbl_subject_exam_type { get; set; }
        public virtual DbSet<tbl_subject_learning_skill> tbl_subject_learning_skill { get; set; }
        public virtual DbSet<tbl_test_bag> tbl_test_bag { get; set; }
        public virtual DbSet<tbl_testBag_create_time> tbl_testBag_create_time { get; set; }
        public virtual DbSet<tbl_timesheet> tbl_timesheet { get; set; }
        public virtual DbSet<tbl_timesheet_detail> tbl_timesheet_detail { get; set; }
        public virtual DbSet<tbl_timetable_detail> tbl_timetable_detail { get; set; }
        public virtual DbSet<tbl_training_base> tbl_training_base { get; set; }
        public virtual DbSet<tbl_training_base_semester_subject> tbl_training_base_semester_subject { get; set; }
        public virtual DbSet<tbl_training_base_semester_subject_exam> tbl_training_base_semester_subject_exam { get; set; }
        public virtual DbSet<tbl_transfer_schedule_history> tbl_transfer_schedule_history { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }
        public virtual DbSet<tbl_user_group> tbl_user_group { get; set; }
        public virtual DbSet<tbl_user_trainning_base> tbl_user_trainning_base { get; set; }
        public virtual DbSet<tbl_voucher_detail_recieve_pay_able_link> tbl_voucher_detail_recieve_pay_able_link { get; set; }
        public virtual DbSet<tbl_voucher_detail_to_voucher_detail_link> tbl_voucher_detail_to_voucher_detail_link { get; set; }
        public virtual DbSet<tbl_voucher_recieve_pay_able> tbl_voucher_recieve_pay_able { get; set; }
        public virtual DbSet<tbl_working_status> tbl_working_status { get; set; }
        public virtual DbSet<CollectionStatus1> CollectionStatus1 { get; set; }
        // public virtual DbSet<tbl_course_subject_tbl_course_subject_timetable> tbl_course_subject_tbl_course_subject_timetable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<oauth_access_token>()
                .Property(e => e.token_id)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_access_token>()
                .Property(e => e.authentication_id)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_access_token>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_access_token>()
                .Property(e => e.client_id)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_access_token>()
                .Property(e => e.refresh_token)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.client_id)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.resource_ids)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.client_secret)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.scope)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.authorized_grant_types)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.web_server_redirect_uri)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.authorities)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.additional_information)
                .IsUnicode(false);

            modelBuilder.Entity<oauth_client_details>()
                .Property(e => e.autoapprove)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_administrative_unit>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_administrative_unit)
                .HasForeignKey(e => e.province_id);

            modelBuilder.Entity<tbl_administrative_unit>()
                .HasMany(e => e.tbl_student_candidate_profile1)
                .WithOptional(e => e.tbl_administrative_unit1)
                .HasForeignKey(e => e.district_id);

            modelBuilder.Entity<tbl_administrative_unit>()
                .HasMany(e => e.tbl_student_candidate_profile2)
                .WithOptional(e => e.tbl_administrative_unit2)
                .HasForeignKey(e => e.address_unit_id);

            modelBuilder.Entity<tbl_administrative_unit>()
                .HasMany(e => e.tbl_administrative_unit1)
                .WithOptional(e => e.tbl_administrative_unit2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_administrative_unit>()
                .HasMany(e => e.tbl_student_candidate_profile3)
                .WithOptional(e => e.tbl_administrative_unit3)
                .HasForeignKey(e => e.ward_id);

            modelBuilder.Entity<tbl_administrative_unit>()
                .HasMany(e => e.tbl_person)
                .WithOptional(e => e.tbl_administrative_unit)
                .HasForeignKey(e => e.native_village);

            modelBuilder.Entity<tbl_behavior_mark_classification_standard>()
                .HasMany(e => e.tbl_student_semester_behavior_mark)
                .WithOptional(e => e.tbl_behavior_mark_classification_standard)
                .HasForeignKey(e => e.classification_id);

            modelBuilder.Entity<tbl_behavior_mark_criteria>()
                .HasMany(e => e.tbl_behavior_mark_criteria1)
                .WithOptional(e => e.tbl_behavior_mark_criteria2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_behavior_mark_criteria>()
                .HasMany(e => e.tbl_student_behavior_criteria_mark)
                .WithOptional(e => e.tbl_behavior_mark_criteria)
                .HasForeignKey(e => e.behavior_mark_criteria);

            modelBuilder.Entity<tbl_behavior_mark_criteria>()
                .HasMany(e => e.tbl_student_behavior_criteria_mark1)
                .WithOptional(e => e.tbl_behavior_mark_criteria1)
                .HasForeignKey(e => e.behavior_mark_criteria_id);

            modelBuilder.Entity<tbl_building>()
                .HasMany(e => e.tbl_room)
                .WithOptional(e => e.tbl_building)
                .HasForeignKey(e => e.building_id);

            modelBuilder.Entity<tbl_calendar_event>()
                .HasMany(e => e.tbl_calendar_event_attachment)
                .WithRequired(e => e.tbl_calendar_event)
                .HasForeignKey(e => e.event_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_calendar_event>()
                .HasMany(e => e.tbl_calendar_event_car)
                .WithRequired(e => e.tbl_calendar_event)
                .HasForeignKey(e => e.event_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_calendar_event>()
                .HasMany(e => e.tbl_calendar_event_attendee)
                .WithRequired(e => e.tbl_calendar_event)
                .HasForeignKey(e => e.event_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_calendar_event_priority>()
                .HasMany(e => e.tbl_calendar_event)
                .WithOptional(e => e.tbl_calendar_event_priority)
                .HasForeignKey(e => e.priority_id);

            modelBuilder.Entity<tbl_certificate>()
                .HasMany(e => e.tbl_study_alert_condition_certificate)
                .WithOptional(e => e.tbl_certificate)
                .HasForeignKey(e => e.certificate_id);

            modelBuilder.Entity<tbl_certificate>()
                .HasMany(e => e.tbl_student_certificate)
                .WithOptional(e => e.tbl_certificate)
                .HasForeignKey(e => e.certificate_id);

            modelBuilder.Entity<tbl_civil_servant_category>()
                .HasMany(e => e.tbl_civil_servant_category_grade)
                .WithOptional(e => e.tbl_civil_servant_category)
                .HasForeignKey(e => e.civil_servant_category_id);

            modelBuilder.Entity<tbl_civil_servant_category_grade>()
                .HasMany(e => e.tbl_staff_civil_servant_grade)
                .WithOptional(e => e.tbl_civil_servant_category_grade)
                .HasForeignKey(e => e.civil_servant_category_grade_id);

            modelBuilder.Entity<tbl_civil_servant_grade>()
                .HasMany(e => e.tbl_civil_servant_category_grade)
                .WithOptional(e => e.tbl_civil_servant_grade)
                .HasForeignKey(e => e.civil_servant_grade_id);

            modelBuilder.Entity<tbl_classification>()
                .HasMany(e => e.tbl_student_certificate)
                .WithOptional(e => e.tbl_classification)
                .HasForeignKey(e => e.classification_id);

            modelBuilder.Entity<tbl_country>()
                .HasMany(e => e.tbl_person)
                .WithOptional(e => e.tbl_country)
                .HasForeignKey(e => e.country_id);

            modelBuilder.Entity<tbl_country>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_country)
                .HasForeignKey(e => e.country_id);

            modelBuilder.Entity<tbl_course_hour>()
                .HasMany(e => e.tbl_semester_subject_exam_room)
                .WithOptional(e => e.tbl_course_hour)
                .HasForeignKey(e => e.start_hour_id);

            modelBuilder.Entity<tbl_course_hour>()
                .HasMany(e => e.tbl_course_subject_timetable)
                .WithOptional(e => e.tbl_course_hour)
                .HasForeignKey(e => e.end_hour_id);

            modelBuilder.Entity<tbl_course_hour>()
                .HasMany(e => e.tbl_semester_subject_exam_room1)
                .WithOptional(e => e.tbl_course_hour1)
                .HasForeignKey(e => e.end_hour_id);

            modelBuilder.Entity<tbl_course_hour>()
                .HasMany(e => e.tbl_course_subject_timetable1)
                .WithOptional(e => e.tbl_course_hour1)
                .HasForeignKey(e => e.start_hour_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_student_course_subject_cancel_fee)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_semester_subject_exam_course_subject)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_course_subject1)
                .WithOptional(e => e.tbl_course_subject2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate_detail)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_course_subject_config)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_student_course_subject)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_subject_exam)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_timetable_detail)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_transfer_schedule_history)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            //modelBuilder.Entity<tbl_course_subject>()
            //    .HasMany(e => e.tbl_course_subject_tbl_course_subject_timetable)
            //    .WithRequired(e => e.tbl_course_subject)
            //    .HasForeignKey(e => e.CourseSubject_id)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_course_subject_subject_exam_formula)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_student_course_subject_history)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject>()
                .HasMany(e => e.tbl_course_subject_timetable)
                .WithOptional(e => e.tbl_course_subject)
                .HasForeignKey(e => e.course_subject_id);

            modelBuilder.Entity<tbl_course_subject_timetable>()
                .HasMany(e => e.tbl_timetable_detail)
                .WithOptional(e => e.tbl_course_subject_timetable)
                .HasForeignKey(e => e.timetable_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_behavior_mark_classification_standard)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_behavior_mark_criteria)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_budget_distribution)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_course_subject_config)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_education_program_number_of_credit)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_study_alert_condition)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_criteria_search_student)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_specialty_admissions_map)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_enrollment_class)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_semester_subject_exam)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_education_program)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_semester_subject)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_school_fee_config)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_student_object_subsidize)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_education_fee_config)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_discount_tuition_fee)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_student_reward_condition)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_expectation_register)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_course_year>()
                .HasMany(e => e.tbl_enrollment_class_reward_condition)
                .WithOptional(e => e.tbl_course_year)
                .HasForeignKey(e => e.course_year_id);

            modelBuilder.Entity<tbl_criteria_search_student>()
                .HasMany(e => e.tbl_student_graduate_conditional)
                .WithOptional(e => e.tbl_criteria_search_student)
                .HasForeignKey(e => e.criteria_id);

            modelBuilder.Entity<tbl_criteria_search_student>()
                .HasMany(e => e.tbl_criteria_search_student_except_subject)
                .WithOptional(e => e.tbl_criteria_search_student)
                .HasForeignKey(e => e.criteria_id);

            modelBuilder.Entity<tbl_decision>()
                .HasMany(e => e.tbl_student_status_student_semester)
                .WithOptional(e => e.tbl_decision)
                .HasForeignKey(e => e.decision_id);

            modelBuilder.Entity<tbl_decision>()
                .HasMany(e => e.tbl_student_decision)
                .WithOptional(e => e.tbl_decision)
                .HasForeignKey(e => e.decision_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_budget_distribution)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_calendar_event)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.owner_department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_calendar_event1)
                .WithOptional(e => e.tbl_department1)
                .HasForeignKey(e => e.dep_creator_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_calendar_event_attendee)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_course_subject_config)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.deparment_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_education_fee_config)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_department1)
                .WithOptional(e => e.tbl_department2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_position_staff)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_study_alert_condition)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_position)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_enrollment_class)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_speciality)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_subject)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_school_fee_config)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_salary_config)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_department>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<tbl_discipline>()
                .HasMany(e => e.tbl_behavior_mark_classification_standard)
                .WithOptional(e => e.tbl_discipline)
                .HasForeignKey(e => e.highest_discipline_id);

            modelBuilder.Entity<tbl_discipline>()
                .HasMany(e => e.tbl_criteria_search_student)
                .WithOptional(e => e.tbl_discipline)
                .HasForeignKey(e => e.discipline_id);

            modelBuilder.Entity<tbl_discipline>()
                .HasMany(e => e.tbl_study_alert_condition)
                .WithOptional(e => e.tbl_discipline)
                .HasForeignKey(e => e.discipline_id);

            modelBuilder.Entity<tbl_discipline>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_discipline)
                .HasForeignKey(e => e.discipline_id);

            modelBuilder.Entity<tbl_discipline>()
                .HasMany(e => e.tbl_student_discipline)
                .WithOptional(e => e.tbl_discipline)
                .HasForeignKey(e => e.discipline_id);

            modelBuilder.Entity<tbl_discount_tuition_fee>()
                .HasMany(e => e.tbl_discount_tuition_fee_item)
                .WithOptional(e => e.tbl_discount_tuition_fee)
                .HasForeignKey(e => e.discount_tuition_fee_id);

            modelBuilder.Entity<tbl_discount_tuition_fee>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate)
                .WithOptional(e => e.tbl_discount_tuition_fee)
                .HasForeignKey(e => e.discount_tuition_fee_id);

            modelBuilder.Entity<tbl_education_fee_config>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithOptional(e => e.tbl_education_fee_config)
                .HasForeignKey(e => e.education_fee_config_id);

            modelBuilder.Entity<tbl_education_level>()
                .HasMany(e => e.tbl_course_year)
                .WithOptional(e => e.tbl_education_level)
                .HasForeignKey(e => e.education_level_id);

            modelBuilder.Entity<tbl_education_level>()
                .HasMany(e => e.tbl_subject_education_level_type)
                .WithOptional(e => e.tbl_education_level)
                .HasForeignKey(e => e.education_level_id);

            modelBuilder.Entity<tbl_education_level>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_education_level)
                .HasForeignKey(e => e.education_level_id);

            modelBuilder.Entity<tbl_education_level>()
                .HasMany(e => e.tbl_enrollment_class)
                .WithOptional(e => e.tbl_education_level)
                .HasForeignKey(e => e.education_id);

            modelBuilder.Entity<tbl_education_level>()
                .HasMany(e => e.tbl_education_program)
                .WithOptional(e => e.tbl_education_level)
                .HasForeignKey(e => e.education_level_id);

            modelBuilder.Entity<tbl_education_level>()
                .HasMany(e => e.tbl_student_code_key)
                .WithOptional(e => e.tbl_education_level)
                .HasForeignKey(e => e.education_level_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_course_subject_config)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_criteria_search_student)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.education_program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.education_program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_student_education_program)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.education_program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_group_subject_program)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_enrollment_class)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_student_graduate_conditional)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.education_program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_student_graduate)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.education_program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_knowledge_program)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_speciality_program)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.education_program_id);

            modelBuilder.Entity<tbl_education_program>()
                .HasMany(e => e.tbl_program_subject)
                .WithOptional(e => e.tbl_education_program)
                .HasForeignKey(e => e.program_id);

            modelBuilder.Entity<tbl_education_type>()
                .HasMany(e => e.tbl_course_year)
                .WithOptional(e => e.tbl_education_type)
                .HasForeignKey(e => e.education_type_id);

            modelBuilder.Entity<tbl_education_type>()
                .HasMany(e => e.tbl_education_program)
                .WithOptional(e => e.tbl_education_type)
                .HasForeignKey(e => e.education_type_id);

            modelBuilder.Entity<tbl_education_type>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_education_type)
                .HasForeignKey(e => e.education_type_id);

            modelBuilder.Entity<tbl_education_type>()
                .HasMany(e => e.tbl_subject_education_level_type)
                .WithOptional(e => e.tbl_education_type)
                .HasForeignKey(e => e.education_type_id);

            modelBuilder.Entity<tbl_education_type>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_education_type)
                .HasForeignKey(e => e.education_type_id);

            modelBuilder.Entity<tbl_education_voucher>()
                .HasMany(e => e.tbl_voucher_recieve_pay_able)
                .WithOptional(e => e.tbl_education_voucher)
                .HasForeignKey(e => e.educationVoucher_id);

            modelBuilder.Entity<tbl_education_voucher>()
                .HasMany(e => e.tbl_education_voucher_detail)
                .WithOptional(e => e.tbl_education_voucher)
                .HasForeignKey(e => e.education_voucher_id);

            modelBuilder.Entity<tbl_education_voucher_detail>()
                .HasMany(e => e.tbl_voucher_detail_to_voucher_detail_link)
                .WithOptional(e => e.tbl_education_voucher_detail)
                .HasForeignKey(e => e.from_id);

            modelBuilder.Entity<tbl_education_voucher_detail>()
                .HasMany(e => e.tbl_voucher_detail_to_voucher_detail_link1)
                .WithOptional(e => e.tbl_education_voucher_detail1)
                .HasForeignKey(e => e.to_id);

            modelBuilder.Entity<tbl_education_voucher_detail>()
                .HasMany(e => e.tbl_voucher_detail_recieve_pay_able_link)
                .WithOptional(e => e.tbl_education_voucher_detail)
                .HasForeignKey(e => e.education_voucher_detail_id);

            modelBuilder.Entity<tbl_education_voucher_detail>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_education_voucher_detail)
                .HasForeignKey(e => e.education_voucher_detail_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_budget_distribution)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_course_subject)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_course_subject_config)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_education_program_number_of_credit)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_enrollment_class_history)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_old_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_register_period_time_config)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_enrollment_class_reward)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_student)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_enrollment_class_history1)
                .WithOptional(e => e.tbl_enrollment_class1)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_role_tution_enrollment_class)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_enrollment_class_staff)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.enrollment_class_id);

            modelBuilder.Entity<tbl_enrollment_class>()
                .HasMany(e => e.tbl_study_alert_condition)
                .WithOptional(e => e.tbl_enrollment_class)
                .HasForeignKey(e => e.class_id);

            modelBuilder.Entity<tbl_enrollment_class_reward_condition>()
                .HasMany(e => e.tbl_enrollment_class_reward)
                .WithOptional(e => e.tbl_enrollment_class_reward_condition)
                .HasForeignKey(e => e.enrollment_class_reward_condition);

            modelBuilder.Entity<tbl_ethnics>()
                .HasMany(e => e.tbl_person)
                .WithOptional(e => e.tbl_ethnics)
                .HasForeignKey(e => e.ethnics_id);

            modelBuilder.Entity<tbl_ethnics>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_ethnics)
                .HasForeignKey(e => e.ethnics_id);

            modelBuilder.Entity<tbl_exam_hour>()
                .HasMany(e => e.tbl_semester_subject_exam_hour)
                .WithOptional(e => e.tbl_exam_hour)
                .HasForeignKey(e => e.exam_hour_id);

            modelBuilder.Entity<tbl_exam_hour>()
                .HasMany(e => e.tbl_semester_subject_exam_room)
                .WithOptional(e => e.tbl_exam_hour)
                .HasForeignKey(e => e.exam_hour_id);

            modelBuilder.Entity<tbl_exam_register_period>()
                .HasMany(e => e.tbl_exam_room_period)
                .WithOptional(e => e.tbl_exam_register_period)
                .HasForeignKey(e => e.exam_period_id);

            modelBuilder.Entity<tbl_exam_register_period>()
                .HasMany(e => e.tbl_semester_subject_exam)
                .WithOptional(e => e.tbl_exam_register_period)
                .HasForeignKey(e => e.exam_register_period_id);

            modelBuilder.Entity<tbl_exam_register_period>()
                .HasMany(e => e.tbl_student_exam_group)
                .WithOptional(e => e.tbl_exam_register_period)
                .HasForeignKey(e => e.exam_period_id);

            modelBuilder.Entity<tbl_exam_skill>()
                .HasMany(e => e.tbl_subject)
                .WithOptional(e => e.tbl_exam_skill)
                .HasForeignKey(e => e.exam_skill_id);

            modelBuilder.Entity<tbl_exam_skill>()
                .HasMany(e => e.tbl_semester_subject_exam_room)
                .WithOptional(e => e.tbl_exam_skill)
                .HasForeignKey(e => e.exam_skill_id);

            modelBuilder.Entity<tbl_exam_status>()
                .HasMany(e => e.tbl_student_semester_subject_exam_room)
                .WithOptional(e => e.tbl_exam_status)
                .HasForeignKey(e => e.exam_status_id);

            modelBuilder.Entity<tbl_exam_type>()
                .HasMany(e => e.tbl_exam_hour)
                .WithOptional(e => e.tbl_exam_type)
                .HasForeignKey(e => e.exam_type);

            modelBuilder.Entity<tbl_exam_type>()
                .HasMany(e => e.tbl_semester_subject_exam)
                .WithOptional(e => e.tbl_exam_type)
                .HasForeignKey(e => e.exam_type_id);

            modelBuilder.Entity<tbl_expectation_register>()
                .HasMany(e => e.tbl_student_expectation_register)
                .WithOptional(e => e.tbl_expectation_register)
                .HasForeignKey(e => e.expectation_register_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_discount_tuition_fee_item)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.fee_item_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_education_voucher_detail)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.fee_item_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_fee_config_item)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.fee_item_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_fee_item_detail)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.fee_item_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.fee_item_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate_detail)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.feeItem_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.fee_item_id);

            modelBuilder.Entity<tbl_fee_item>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithOptional(e => e.tbl_fee_item)
                .HasForeignKey(e => e.feeItem_id);

            modelBuilder.Entity<tbl_fee_item_detail>()
                .HasMany(e => e.tbl_education_voucher_detail)
                .WithOptional(e => e.tbl_fee_item_detail)
                .HasForeignKey(e => e.fee_item_detai_id);

            modelBuilder.Entity<tbl_fee_item_detail>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_fee_item_detail)
                .HasForeignKey(e => e.fee_item_detail_id);

            modelBuilder.Entity<tbl_fee_item_detail>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_fee_item_detail)
                .HasForeignKey(e => e.fee_item_detail_id);

            modelBuilder.Entity<tbl_file_description>()
                .HasMany(e => e.tbl_calendar_event_attachment)
                .WithOptional(e => e.tbl_file_description)
                .HasForeignKey(e => e.file_id);

            modelBuilder.Entity<tbl_file_description>()
                .HasMany(e => e.tbl_staff_labour_agreement_attachment)
                .WithOptional(e => e.tbl_file_description)
                .HasForeignKey(e => e.file_id);

            modelBuilder.Entity<tbl_graduation_period>()
                .HasMany(e => e.tbl_student_graduate)
                .WithOptional(e => e.tbl_graduation_period)
                .HasForeignKey(e => e.graduation_period_id);

            modelBuilder.Entity<tbl_group_subject_program>()
                .HasMany(e => e.tbl_group_subject_program1)
                .WithOptional(e => e.tbl_group_subject_program2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_group_subject_program>()
                .HasMany(e => e.tbl_program_subject)
                .WithOptional(e => e.tbl_group_subject_program)
                .HasForeignKey(e => e.group_id);

            modelBuilder.Entity<tbl_inventory_item>()
                .HasMany(e => e.tbl_inventory_item1)
                .WithOptional(e => e.tbl_inventory_item2)
                .HasForeignKey(e => e.inventory_item_id);

            modelBuilder.Entity<tbl_knowledge_block>()
                .HasMany(e => e.tbl_knowledge_program)
                .WithOptional(e => e.tbl_knowledge_block)
                .HasForeignKey(e => e.knowledge_block_id);

            modelBuilder.Entity<tbl_knowledge_program>()
                .HasMany(e => e.tbl_program_subject)
                .WithOptional(e => e.tbl_knowledge_program)
                .HasForeignKey(e => e.knowledge_program_id);

            modelBuilder.Entity<tbl_knowledge_program>()
                .HasMany(e => e.tbl_knowledge_program1)
                .WithOptional(e => e.tbl_knowledge_program2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_labour_agreement_type>()
                .HasMany(e => e.tbl_staff_labour_agreement)
                .WithOptional(e => e.tbl_labour_agreement_type)
                .HasForeignKey(e => e.labour_agreement_type_id);

            modelBuilder.Entity<tbl_learning_skill>()
                .HasMany(e => e.tbl_course_subject)
                .WithOptional(e => e.tbl_learning_skill)
                .HasForeignKey(e => e.learning_skill_id);

            modelBuilder.Entity<tbl_learning_skill>()
                .HasMany(e => e.tbl_subject_learning_skill)
                .WithOptional(e => e.tbl_learning_skill)
                .HasForeignKey(e => e.learning_skill_id);

            modelBuilder.Entity<tbl_learning_skill>()
                .HasMany(e => e.tbl_semester_subject)
                .WithOptional(e => e.tbl_learning_skill)
                .HasForeignKey(e => e.main_learning_skill_id);

            modelBuilder.Entity<tbl_learning_skill>()
                .HasMany(e => e.tbl_semester_subject_learning_skill)
                .WithOptional(e => e.tbl_learning_skill)
                .HasForeignKey(e => e.learning_skill_id);

            modelBuilder.Entity<tbl_mark_type>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_mark_type)
                .HasForeignKey(e => e.mark_type_id);

            modelBuilder.Entity<tbl_organization>()
                .HasMany(e => e.tbl_building)
                .WithOptional(e => e.tbl_organization)
                .HasForeignKey(e => e.organization_id);

            modelBuilder.Entity<tbl_organization>()
                .HasMany(e => e.tbl_organization_user)
                .WithOptional(e => e.tbl_organization)
                .HasForeignKey(e => e.organization_id);

            modelBuilder.Entity<tbl_organization>()
                .HasMany(e => e.tbl_organization1)
                .WithOptional(e => e.tbl_organization2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_person>()
                .HasOptional(e => e.tbl_budget_distribution)
                .WithRequired(e => e.tbl_person);

            modelBuilder.Entity<tbl_person>()
                .HasMany(e => e.tbl_calendar_event)
                .WithOptional(e => e.tbl_person)
                .HasForeignKey(e => e.person_creator_id);

            modelBuilder.Entity<tbl_person>()
                .HasMany(e => e.tbl_calendar_event1)
                .WithOptional(e => e.tbl_person1)
                .HasForeignKey(e => e.owner_person_id);

            modelBuilder.Entity<tbl_person>()
                .HasMany(e => e.tbl_person_address)
                .WithOptional(e => e.tbl_person)
                .HasForeignKey(e => e.person_id);

            modelBuilder.Entity<tbl_position_title>()
                .HasMany(e => e.tbl_position)
                .WithOptional(e => e.tbl_position_title)
                .HasForeignKey(e => e.title_id);

            modelBuilder.Entity<tbl_position_title>()
                .HasMany(e => e.tbl_position_staff)
                .WithOptional(e => e.tbl_position_title)
                .HasForeignKey(e => e.position_id);

            modelBuilder.Entity<tbl_profession>()
                .HasMany(e => e.tbl_student)
                .WithOptional(e => e.tbl_profession)
                .HasForeignKey(e => e.father_profession_id);

            modelBuilder.Entity<tbl_profession>()
                .HasMany(e => e.tbl_student1)
                .WithOptional(e => e.tbl_profession1)
                .HasForeignKey(e => e.mother_profession_id);

            modelBuilder.Entity<tbl_program_subject>()
                .HasMany(e => e.tbl_equivalent_subject)
                .WithOptional(e => e.tbl_program_subject)
                .HasForeignKey(e => e.program_subject_id);

            modelBuilder.Entity<tbl_program_subject>()
                .HasMany(e => e.tbl_prerequisite_subject)
                .WithRequired(e => e.tbl_program_subject)
                .HasForeignKey(e => e.program_subject_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_program_subject>()
                .HasMany(e => e.tbl_subject_exam)
                .WithOptional(e => e.tbl_program_subject)
                .HasForeignKey(e => e.program_subject_id);

            modelBuilder.Entity<tbl_program_subject>()
                .HasMany(e => e.tbl_program_subject_semester)
                .WithOptional(e => e.tbl_program_subject)
                .HasForeignKey(e => e.program_subject_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_education_voucher_detail)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_pay_able_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_pay_able_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_payable_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_student_scholarship_history)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_pay_able_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_pay_able_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_receive_pay_able1)
                .WithOptional(e => e.tbl_receive_pay_able2)
                .HasForeignKey(e => e.adjusted_receive_pay_able_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_student_course_subject_cancel_fee)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_pay_able_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_voucher_recieve_pay_able)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receivePayAble_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_payable_id);

            modelBuilder.Entity<tbl_receive_pay_able>()
                .HasMany(e => e.tbl_voucher_detail_recieve_pay_able_link)
                .WithOptional(e => e.tbl_receive_pay_able)
                .HasForeignKey(e => e.receive_pay_able_id);

            modelBuilder.Entity<tbl_receive_pay_able_detail>()
                .HasMany(e => e.tbl_education_voucher_detail)
                .WithOptional(e => e.tbl_receive_pay_able_detail)
                .HasForeignKey(e => e.receive_pay_able_detail_id);

            modelBuilder.Entity<tbl_receive_pay_able_detail>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_receive_pay_able_detail)
                .HasForeignKey(e => e.receive_pay_able_detail_id);

            modelBuilder.Entity<tbl_receive_pay_able_detail>()
                .HasMany(e => e.tbl_student_course_subject_cancel_fee)
                .WithOptional(e => e.tbl_receive_pay_able_detail)
                .HasForeignKey(e => e.receive_pay_able_detail_id);

            modelBuilder.Entity<tbl_receive_pay_able_detail>()
                .HasMany(e => e.tbl_receive_pay_able_detail1)
                .WithOptional(e => e.tbl_receive_pay_able_detail2)
                .HasForeignKey(e => e.receive_pay_able_detail_id);

            modelBuilder.Entity<tbl_religion>()
                .HasMany(e => e.tbl_person)
                .WithOptional(e => e.tbl_religion)
                .HasForeignKey(e => e.religion_id);

            modelBuilder.Entity<tbl_religion>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_religion)
                .HasForeignKey(e => e.religion_id);

            modelBuilder.Entity<tbl_reward>()
                .HasMany(e => e.tbl_enrollment_class_reward)
                .WithOptional(e => e.tbl_reward)
                .HasForeignKey(e => e.reward_id);

            modelBuilder.Entity<tbl_reward>()
                .HasMany(e => e.tbl_student_reward)
                .WithOptional(e => e.tbl_reward)
                .HasForeignKey(e => e.reward_id);

            modelBuilder.Entity<tbl_reward_decree>()
                .HasMany(e => e.tbl_enrollment_class_reward)
                .WithOptional(e => e.tbl_reward_decree)
                .HasForeignKey(e => e.reward_decree_id);

            modelBuilder.Entity<tbl_reward_decree>()
                .HasMany(e => e.tbl_student_reward)
                .WithOptional(e => e.tbl_reward_decree)
                .HasForeignKey(e => e.reward_decree_id);

            modelBuilder.Entity<tbl_reward_decree>()
                .HasMany(e => e.tbl_student_object_subsidize_semester)
                .WithOptional(e => e.tbl_reward_decree)
                .HasForeignKey(e => e.reward_decree_id);

            modelBuilder.Entity<tbl_role>()
                .HasMany(e => e.tbl_user)
                .WithMany(e => e.tbl_role)
                .Map(m => m.ToTable("tbl_user_role").MapLeftKey("role_id").MapRightKey("user_id"));

            modelBuilder.Entity<tbl_room>()
                .HasMany(e => e.tbl_calendar_event)
                .WithOptional(e => e.tbl_room)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<tbl_room>()
                .HasMany(e => e.tbl_course_subject_timetable)
                .WithOptional(e => e.tbl_room)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<tbl_room>()
                .HasMany(e => e.tbl_exam_room_period)
                .WithOptional(e => e.tbl_room)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<tbl_room>()
                .HasMany(e => e.tbl_semester_subject_exam_date)
                .WithOptional(e => e.tbl_room)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<tbl_room>()
                .HasMany(e => e.tbl_semester_subject_exam_hour_room)
                .WithOptional(e => e.tbl_room)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<tbl_room>()
                .HasMany(e => e.tbl_semester_subject_exam_room)
                .WithOptional(e => e.tbl_room)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<tbl_salary_config>()
                .HasMany(e => e.tbl_salary_config_item)
                .WithOptional(e => e.tbl_salary_config)
                .HasForeignKey(e => e.salary_config_id);

            modelBuilder.Entity<tbl_salary_item>()
                .HasMany(e => e.tbl_salary_config_item)
                .WithOptional(e => e.tbl_salary_item)
                .HasForeignKey(e => e.salary_item_id);

            modelBuilder.Entity<tbl_salary_item>()
                .HasMany(e => e.tbl_staff_salary_property)
                .WithOptional(e => e.tbl_salary_item)
                .HasForeignKey(e => e.salary_item_id);

            modelBuilder.Entity<tbl_scholarship_condition>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_scholarship_condition)
                .HasForeignKey(e => e.scholarship_condition_id);

            modelBuilder.Entity<tbl_scholarship_fund>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_scholarship_fund)
                .HasForeignKey(e => e.scholarship_fund_id);

            modelBuilder.Entity<tbl_scholarship_fund>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_scholarship_fund)
                .HasForeignKey(e => e.scholarship_fund_id);

            modelBuilder.Entity<tbl_scholarship_fund>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_scholarship_fund)
                .HasForeignKey(e => e.scholarship_fund_id);

            modelBuilder.Entity<tbl_scholarship_fund>()
                .HasMany(e => e.tbl_student_scholarship_stock_detail)
                .WithOptional(e => e.tbl_scholarship_fund)
                .HasForeignKey(e => e.scholarship_fund_id);

            modelBuilder.Entity<tbl_scholarship_fund>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_scholarship_fund)
                .HasForeignKey(e => e.scholarship_fund_id);

            modelBuilder.Entity<tbl_scholarship_fund_type>()
                .HasMany(e => e.tbl_scholarship_fund)
                .WithOptional(e => e.tbl_scholarship_fund_type)
                .HasForeignKey(e => e.scholarship_fund_type_id);

            modelBuilder.Entity<tbl_school_fee_config>()
                .HasMany(e => e.tbl_fee_config_item)
                .WithOptional(e => e.tbl_school_fee_config)
                .HasForeignKey(e => e.school_fee_config_id);

            modelBuilder.Entity<tbl_semester>()
                 .HasMany(e => e.tbl_behavior_mark_classification_standard)
                 .WithOptional(e => e.tbl_semester)
                 .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_behavior_mark_criteria)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_budget_distribution)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_decision)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_discount_tuition_fee)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_education_fee_config)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_education_program_number_of_credit)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_enrollment_class_reward)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_exam_register_period)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semeter_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_expectation_register)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.sub_semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_expectation_register1)
                .WithOptional(e => e.tbl_semester1)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_program_subject_semester)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_discipline)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_certificate)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_research)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithRequired(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_not_complete_fee_semester)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_decision)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.decision_type_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_discipline1)
                .WithOptional(e => e.tbl_semester1)
                .HasForeignKey(e => e.end_semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_object_student_semester)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_object_subsidize)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_reward)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_semester_subject)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.sub_semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_course_subject_edited)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_semester_summary_mark)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_semester_behavior_mark)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_semester_subject_exam)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_decision1)
                .WithOptional(e => e.tbl_semester1)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_scholarship_stock)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_status_student_semester)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_semester1)
                .WithOptional(e => e.tbl_semester2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_semester_register_period)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semeter_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_study_alert_condition)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_semester_summary)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_subject_mark)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_process_assessment_point)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_study_alert_level)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_semester11)
                .WithOptional(e => e.tbl_semester3)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_study_alert_level_lower)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_student_register_change)
                .WithOptional(e => e.tbl_semester)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester>()
                .HasMany(e => e.tbl_semester_subject1)
                .WithOptional(e => e.tbl_semester1)
                .HasForeignKey(e => e.semester_id);

            modelBuilder.Entity<tbl_semester_exam_period>()
                .HasMany(e => e.tbl_course_subject)
                .WithOptional(e => e.tbl_semester_exam_period)
                .HasForeignKey(e => e.semester_exam_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_education_fee_config)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_exam_register_period)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.semester_register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_expectation_register)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_register_period_time_config)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_semester_exam_period)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.semester_register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_semester_subject)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_periods_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_student_course_subject_edited)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_semester_subject_exam)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_register_period>()
                .HasMany(e => e.tbl_student_register_change)
                .WithOptional(e => e.tbl_semester_register_period)
                .HasForeignKey(e => e.register_period_id);

            modelBuilder.Entity<tbl_semester_subject>()
                .HasMany(e => e.tbl_course_subject)
                .WithOptional(e => e.tbl_semester_subject)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject>()
                .HasMany(e => e.tbl_course_subject_subject_exam_formula)
                .WithOptional(e => e.tbl_semester_subject)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject>()
                .HasMany(e => e.tbl_semester_subject_learning_skill)
                .WithOptional(e => e.tbl_semester_subject)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject>()
                .HasMany(e => e.tbl_semester_subject_exam)
                .WithOptional(e => e.tbl_semester_subject)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject>()
                .HasMany(e => e.tbl_training_base_semester_subject)
                .WithOptional(e => e.tbl_semester_subject)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject>()
                .HasMany(e => e.tbl_subject_exam)
                .WithOptional(e => e.tbl_semester_subject)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_semester_subject)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_semester_subject_exam_room)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_exam_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_exam_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_training_base_semester_subject_exam)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_exam_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_semester_subject_exam_date)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_exam_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_testBag_create_time)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_exam_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_test_bag)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_exam_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_semester_subject_exam_course_subject)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_id);

            modelBuilder.Entity<tbl_semester_subject_exam>()
                .HasMany(e => e.tbl_student_semester_subject_exam)
                .WithOptional(e => e.tbl_semester_subject_exam)
                .HasForeignKey(e => e.semester_subject_exam_id);

            modelBuilder.Entity<tbl_semester_subject_exam_date>()
                .HasMany(e => e.tbl_semester_subject_exam_hour)
                .WithOptional(e => e.tbl_semester_subject_exam_date)
                .HasForeignKey(e => e.exam_date_id);

            modelBuilder.Entity<tbl_semester_subject_exam_hour>()
                .HasMany(e => e.tbl_semester_subject_exam_room)
                .WithOptional(e => e.tbl_semester_subject_exam_hour)
                .HasForeignKey(e => e.subject_exam_hour_id);

            modelBuilder.Entity<tbl_semester_subject_exam_hour>()
                .HasMany(e => e.tbl_semester_subject_exam_hour_room)
                .WithOptional(e => e.tbl_semester_subject_exam_hour)
                .HasForeignKey(e => e.exam_hour_id);

            modelBuilder.Entity<tbl_semester_subject_exam_room>()
                .HasMany(e => e.tbl_student_semester_subject_exam_room)
                .WithOptional(e => e.tbl_semester_subject_exam_room)
                .HasForeignKey(e => e.semester_subject_exam_room_id);

            modelBuilder.Entity<tbl_shift_work>()
                .HasMany(e => e.tbl_staff_work_schedule)
                .WithOptional(e => e.tbl_shift_work)
                .HasForeignKey(e => e.shif_work_id);

            modelBuilder.Entity<tbl_shift_work>()
                .HasMany(e => e.tbl_timesheet)
                .WithOptional(e => e.tbl_shift_work)
                .HasForeignKey(e => e.shift_work_id);

            modelBuilder.Entity<tbl_shift_work>()
                .HasMany(e => e.tbl_shift_work_time_period)
                .WithRequired(e => e.tbl_shift_work)
                .HasForeignKey(e => e.shift_work_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_behavior_mark_classification_standard)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_enrollment_class_reward)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_enrollment_class_reward_condition)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_semester)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_student_semester_behavior_mark)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_student_reward)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_student_school_year_summary_mark)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_shool_year>()
                .HasMany(e => e.tbl_student_reward_condition)
                .WithOptional(e => e.tbl_shool_year)
                .HasForeignKey(e => e.school_year_id);

            modelBuilder.Entity<tbl_social_class>()
                .HasMany(e => e.tbl_person)
                .WithOptional(e => e.tbl_social_class)
                .HasForeignKey(e => e.family_social_class_id);

            modelBuilder.Entity<tbl_social_priority>()
                .HasMany(e => e.tbl_person)
                .WithOptional(e => e.tbl_social_priority)
                .HasForeignKey(e => e.personal_social_priority_id);

            modelBuilder.Entity<tbl_social_priority>()
                .HasMany(e => e.tbl_person1)
                .WithOptional(e => e.tbl_social_priority1)
                .HasForeignKey(e => e.family_social_priority_id);

            modelBuilder.Entity<tbl_special_point>()
                .HasMany(e => e.tbl_student_semester_subject_exam_room)
                .WithOptional(e => e.tbl_special_point)
                .HasForeignKey(e => e.special_point_id);

            modelBuilder.Entity<tbl_special_point>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_special_point)
                .HasForeignKey(e => e.special_point);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_budget_distribution)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_course_subject_config)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_education_fee_config)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.sepeciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_education_program)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_education_program_number_of_credit)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_education_program_tuition_fee1)
                .WithOptional(e => e.tbl_speciality1)
                .HasForeignKey(e => e.sepeciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_enrollment_class)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_knowledge_program)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.sub_speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_school_fee_config)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.sepeciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_speciality1)
                .WithOptional(e => e.tbl_speciality2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_specialty_admissions_map)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_speciality_program)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.sepeciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_student_code_key)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_speciality>()
                .HasMany(e => e.tbl_study_alert_condition)
                .WithOptional(e => e.tbl_speciality)
                .HasForeignKey(e => e.speciality_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_calendar_event_attendee)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_course_subject)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.teacher_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_course_subject_timetable)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.assistant_teacher_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_course_subject_timetable1)
                .WithOptional(e => e.tbl_staff1)
                .HasForeignKey(e => e.teacher_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_enrollment_class)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_enrollment_class_staff)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_position_staff)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_role_tution_enrollment_class)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_timesheet)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.employee_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_disciplinary_history)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_work_schedule)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_allowance_history)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_salary_history)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_reward_history)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_travelling_history)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_salary_property)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_education_history)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_civil_servant_grade)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_labour_agreement)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff>()
                .HasMany(e => e.tbl_staff_family_relationship)
                .WithOptional(e => e.tbl_staff)
                .HasForeignKey(e => e.staff_id);

            modelBuilder.Entity<tbl_staff_labour_agreement>()
                .HasMany(e => e.tbl_staff_labour_agreement_attachment)
                .WithOptional(e => e.tbl_staff_labour_agreement)
                .HasForeignKey(e => e.agreement_id);

            modelBuilder.Entity<tbl_status>()
                .HasMany(e => e.tbl_student_status_student_semester)
                .WithOptional(e => e.tbl_status)
                .HasForeignKey(e => e.status_id);

            modelBuilder.Entity<tbl_status>()
                .HasMany(e => e.tbl_student)
                .WithOptional(e => e.tbl_status)
                .HasForeignKey(e => e.status_id);

            modelBuilder.Entity<tbl_status>()
                .HasMany(e => e.tbl_student_decision_type)
                .WithOptional(e => e.tbl_status)
                .HasForeignKey(e => e.status_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl__student_student_group)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_enrollment_class_history)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithRequired(e => e.tbl_student)
                .HasForeignKey(e => e.student_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_school_year_summary_mark)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_subject_mark)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_expectation_register)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_study_alert_level_lower)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_graduate_conditional)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_not_complete_fee_semester)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_course_subject_edited)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_study_alert_level)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_course_subject_history)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_discipline)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_research)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_scholarship_stock)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_object_student)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_object_subsidize_semester)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_semester_summary)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_status_student_semester)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_semester_behavior_mark)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_decision)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_reward)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_semester_subject_exam_room)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_graduate)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_summary_mark)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_semester_subject_exam)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_student_private_document)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_call_roll)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_education_program)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_register_change)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_candidate_profile1)
                .WithOptional(e => e.tbl_student1)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_course_subject)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_semester_summary_mark)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_process_assessment_point)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_object_student_semester)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_certificate)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student>()
                .HasMany(e => e.tbl_student_course_subject_cancel_fee)
                .WithOptional(e => e.tbl_student)
                .HasForeignKey(e => e.student_id);

            modelBuilder.Entity<tbl_student_candidate_profile>()
                .HasMany(e => e.tbl_student)
                .WithOptional(e => e.tbl_student_candidate_profile)
                .HasForeignKey(e => e.candidate_profile_id);

            modelBuilder.Entity<tbl_student_course_subject>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_student_course_subject)
                .HasForeignKey(e => e.student_course_subject_id);

            modelBuilder.Entity<tbl_student_course_subject>()
                .HasMany(e => e.tbl_student_semester_subject_exam_room)
                .WithOptional(e => e.tbl_student_course_subject)
                .HasForeignKey(e => e.student_course_subject_id);

            modelBuilder.Entity<tbl_student_course_subject>()
                .HasMany(e => e.tbl_student_semester_subject_exam)
                .WithOptional(e => e.tbl_student_course_subject)
                .HasForeignKey(e => e.student_course_subject_id);

            modelBuilder.Entity<tbl_student_course_subject>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate_detail)
                .WithOptional(e => e.tbl_student_course_subject)
                .HasForeignKey(e => e.student_course_subject_id);

            modelBuilder.Entity<tbl_student_decision_type>()
                .HasMany(e => e.tbl_decision)
                .WithOptional(e => e.tbl_student_decision_type)
                .HasForeignKey(e => e.decision_type_id);

            modelBuilder.Entity<tbl_student_decision_type>()
                .HasMany(e => e.tbl_student_decision)
                .WithOptional(e => e.tbl_student_decision_type)
                .HasForeignKey(e => e.decision_type_id);

            modelBuilder.Entity<tbl_student_expectation_register>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_student_expectation_register)
                .HasForeignKey(e => e.student_expectation_register_id);

            modelBuilder.Entity<tbl_student_expectation_register>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_student_expectation_register)
                .HasForeignKey(e => e.student_expectation_register_id);

            modelBuilder.Entity<tbl_student_group>()
                .HasMany(e => e.tbl__student_student_group)
                .WithOptional(e => e.tbl_student_group)
                .HasForeignKey(e => e.group_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_discount_tuition_fee)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_scholarship_condition)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_scholarship_condition1)
                .WithOptional(e => e.tbl_student_object1)
                .HasForeignKey(e => e.student_object_semester_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_school_fee_config)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_student_object_subsidize)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_study_alert_condition_student_object)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_student_object_policy)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_student_object_student_semester)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object>()
                .HasMany(e => e.tbl_student_object_student)
                .WithOptional(e => e.tbl_student_object)
                .HasForeignKey(e => e.student_object_id);

            modelBuilder.Entity<tbl_student_object_subsidize>()
                .HasMany(e => e.tbl_student_object_subsidize_semester)
                .WithOptional(e => e.tbl_student_object_subsidize)
                .HasForeignKey(e => e.student_object_subsidize_id);

            modelBuilder.Entity<tbl_student_private_document>()
                .HasMany(e => e.tbl_student_private_document1)
                .WithOptional(e => e.tbl_student_private_document2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_student_private_document>()
                .HasMany(e => e.tbl_student_student_private_document)
                .WithOptional(e => e.tbl_student_private_document)
                .HasForeignKey(e => e.student_private_document_id);

            modelBuilder.Entity<tbl_student_register_change>()
                .HasMany(e => e.tbl_student_course_subject_cancel_fee)
                .WithOptional(e => e.tbl_student_register_change)
                .HasForeignKey(e => e.student_register_change_id);

            modelBuilder.Entity<tbl_student_reward_condition>()
                .HasMany(e => e.tbl_student_reward)
                .WithOptional(e => e.tbl_student_reward_condition)
                .HasForeignKey(e => e.student_reward_condition);

            modelBuilder.Entity<tbl_student_scholarship_history>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_student_scholarship_history)
                .HasForeignKey(e => e.student_scholarship_history_id);

            modelBuilder.Entity<tbl_student_scholarship_history>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_student_scholarship_history)
                .HasForeignKey(e => e.student_scholarship_history_id);

            modelBuilder.Entity<tbl_student_scholarship_stock>()
                .HasMany(e => e.tbl_student_scholarship_stock_detail)
                .WithOptional(e => e.tbl_student_scholarship_stock)
                .HasForeignKey(e => e.scholarship_stock_id);

            modelBuilder.Entity<tbl_student_school_year_summary_mark>()
                .HasMany(e => e.tbl_student_semester_summary_mark)
                .WithOptional(e => e.tbl_student_school_year_summary_mark)
                .HasForeignKey(e => e.school_year_mark_id);

            modelBuilder.Entity<tbl_student_semester_behavior_mark>()
                .HasMany(e => e.tbl_student_behavior_criteria_mark)
                .WithOptional(e => e.tbl_student_semester_behavior_mark)
                .HasForeignKey(e => e.student_semester_behavior_mark_id);

            modelBuilder.Entity<tbl_student_semester_behavior_mark>()
                .HasMany(e => e.tbl_student_scholarship_history)
                .WithOptional(e => e.tbl_student_semester_behavior_mark)
                .HasForeignKey(e => e.student_semester_behavior_id);

            modelBuilder.Entity<tbl_student_semester_behavior_mark>()
                .HasMany(e => e.tbl_student_semester_behavior_mark_history)
                .WithOptional(e => e.tbl_student_semester_behavior_mark)
                .HasForeignKey(e => e.student_semester_behavior_id);

            modelBuilder.Entity<tbl_student_semester_reward_scholarship>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_student_semester_reward_scholarship)
                .HasForeignKey(e => e.student_semester_scholarship_id);

            modelBuilder.Entity<tbl_student_semester_reward_scholarship>()
                .HasMany(e => e.tbl_student_scholarship_history)
                .WithOptional(e => e.tbl_student_semester_reward_scholarship)
                .HasForeignKey(e => e.student_semester_scholarship_id);

            modelBuilder.Entity<tbl_student_semester_subject_exam_room>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_student_semester_subject_exam_room)
                .HasForeignKey(e => e.student_exam_room_id);

            modelBuilder.Entity<tbl_student_study_alert_level>()
                .HasMany(e => e.tbl_student_study_alert_level_lower)
                .WithOptional(e => e.tbl_student_study_alert_level)
                .HasForeignKey(e => e.student_study_alert_level_id);

            modelBuilder.Entity<tbl_student_subject_mark>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_student_subject_mark)
                .HasForeignKey(e => e.student_subject_mark_id);

            modelBuilder.Entity<tbl_student_summary_mark>()
                .HasMany(e => e.tbl_student_school_year_summary_mark)
                .WithOptional(e => e.tbl_student_summary_mark)
                .HasForeignKey(e => e.student_summary_mark_id);

            modelBuilder.Entity<tbl_student_summary_mark>()
                .HasMany(e => e.tbl_student_semester_summary_mark)
                .WithOptional(e => e.tbl_student_summary_mark)
                .HasForeignKey(e => e.summary_mark_id);

            modelBuilder.Entity<tbl_student_tuition_fee_calculate>()
                .HasMany(e => e.tbl_inventory_item)
                .WithOptional(e => e.tbl_student_tuition_fee_calculate)
                .HasForeignKey(e => e.student_tuition_fee_calculate_id);

            modelBuilder.Entity<tbl_student_tuition_fee_calculate>()
                .HasMany(e => e.tbl_receive_pay_able_detail)
                .WithOptional(e => e.tbl_student_tuition_fee_calculate)
                .HasForeignKey(e => e.student_tuition_fee_calculate_id);

            modelBuilder.Entity<tbl_student_tuition_fee_calculate>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate_detail)
                .WithOptional(e => e.tbl_student_tuition_fee_calculate)
                .HasForeignKey(e => e.student_tuition_fee_calculate_id);

            modelBuilder.Entity<tbl_study_alert_condition>()
                .HasMany(e => e.tbl_student_study_alert_level)
                .WithOptional(e => e.tbl_study_alert_condition)
                .HasForeignKey(e => e.study_alert_condition_id);

            modelBuilder.Entity<tbl_study_alert_condition>()
                .HasMany(e => e.tbl_study_alert_condition_student_object)
                .WithOptional(e => e.tbl_study_alert_condition)
                .HasForeignKey(e => e.study_alert_condition_id);

            modelBuilder.Entity<tbl_study_alert_condition>()
                .HasMany(e => e.tbl_study_alert_condition_certificate)
                .WithOptional(e => e.tbl_study_alert_condition)
                .HasForeignKey(e => e.study_alert_condition_id);

            modelBuilder.Entity<tbl_study_alert_condition>()
                .HasMany(e => e.tbl_study_alert_running)
                .WithOptional(e => e.tbl_study_alert_condition)
                .HasForeignKey(e => e.study_alert_condition_id);

            modelBuilder.Entity<tbl_study_alert_condition>()
                .HasMany(e => e.tbl_study_alert_condition_level)
                .WithOptional(e => e.tbl_study_alert_condition)
                .HasForeignKey(e => e.study_alert_condition);

            modelBuilder.Entity<tbl_study_alert_level>()
                .HasMany(e => e.tbl_student_study_alert_level)
                .WithOptional(e => e.tbl_study_alert_level)
                .HasForeignKey(e => e.study_alert_level_id);

            modelBuilder.Entity<tbl_study_alert_level>()
                .HasMany(e => e.tbl_study_alert_condition)
                .WithOptional(e => e.tbl_study_alert_level)
                .HasForeignKey(e => e.study_alert_level_id);

            modelBuilder.Entity<tbl_study_alert_level>()
                .HasMany(e => e.tbl_study_alert_condition_level)
                .WithOptional(e => e.tbl_study_alert_level)
                .HasForeignKey(e => e.study_alert_level);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_criteria_search_student_except_subject)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_equivalent_subject)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_expectation_register)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_prerequisite_subject)
                .WithRequired(e => e.tbl_subject)
                .HasForeignKey(e => e.prerequite_subject_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_program_subject)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_semester_subject)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_semester_subject_exam)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_student_subject_mark)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_subject_education_level_type)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_subject_exam)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject>()
                .HasMany(e => e.tbl_subject_learning_skill)
                .WithOptional(e => e.tbl_subject)
                .HasForeignKey(e => e.subject_id);

            modelBuilder.Entity<tbl_subject_exam>()
                .HasMany(e => e.tbl_course_subject_subject_exam_formula)
                .WithOptional(e => e.tbl_subject_exam)
                .HasForeignKey(e => e.subject_exam_id);

            modelBuilder.Entity<tbl_subject_exam>()
                .HasMany(e => e.tbl_student_mark)
                .WithOptional(e => e.tbl_subject_exam)
                .HasForeignKey(e => e.subject_exam_id);

            modelBuilder.Entity<tbl_subject_exam>()
                .HasMany(e => e.tbl_subject_exam1)
                .WithOptional(e => e.tbl_subject_exam2)
                .HasForeignKey(e => e.parent_id);

            modelBuilder.Entity<tbl_subject_exam_type>()
                .HasMany(e => e.tbl_subject_exam)
                .WithOptional(e => e.tbl_subject_exam_type)
                .HasForeignKey(e => e.subject_exam_type_id);

            modelBuilder.Entity<tbl_test_bag>()
                .HasMany(e => e.tbl_student_semester_subject_exam_room)
                .WithOptional(e => e.tbl_test_bag)
                .HasForeignKey(e => e.test_bag_id);

            modelBuilder.Entity<tbl_testBag_create_time>()
                .HasMany(e => e.tbl_test_bag)
                .WithOptional(e => e.tbl_testBag_create_time)
                .HasForeignKey(e => e.test_bag_create_time_id);

            modelBuilder.Entity<tbl_timesheet>()
                .HasMany(e => e.tbl_timesheet_detail)
                .WithOptional(e => e.tbl_timesheet)
                .HasForeignKey(e => e.timesheet_id);

            modelBuilder.Entity<tbl_timetable_detail>()
                .HasMany(e => e.tbl_student_call_roll)
                .WithOptional(e => e.tbl_timetable_detail)
                .HasForeignKey(e => e.timetable_detail_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_building)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_course_subject)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_education_fee_config)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_education_program_number_of_credit)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_education_program_tuition_fee)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_education_voucher)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_enrollment_class)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_receive_pay_able)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_school_fee_config)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_semester_subject_exam_room)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_student_fee_calculate)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_student_semester_reward_scholarship)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_student_tuition_fee_calculate)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_training_base_semester_subject)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_user_trainning_base)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_training_base>()
                .HasMany(e => e.tbl_training_base_semester_subject_exam)
                .WithOptional(e => e.tbl_training_base)
                .HasForeignKey(e => e.training_base_id);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_organization_user)
                .WithOptional(e => e.tbl_user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_person)
                .WithOptional(e => e.tbl_user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_role_tution_enrollment_class)
                .WithOptional(e => e.tbl_user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_student_candidate_profile)
                .WithOptional(e => e.tbl_user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_user_trainning_base)
                .WithOptional(e => e.tbl_user)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_user_group)
                .WithMany(e => e.tbl_user)
                .Map(m => m.ToTable("tbl_user_usergroup").MapLeftKey("user_id").MapRightKey("group_id"));

            modelBuilder.Entity<tbl_working_status>()
                .HasMany(e => e.tbl_timesheet)
                .WithOptional(e => e.tbl_working_status)
                .HasForeignKey(e => e.working_status_id);
        }
    }
}

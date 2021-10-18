namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_staff()
        {
            tbl_calendar_event_attendee = new HashSet<tbl_calendar_event_attendee>();
            tbl_course_subject = new HashSet<tbl_course_subject>();
            tbl_course_subject_timetable = new HashSet<tbl_course_subject_timetable>();
            tbl_course_subject_timetable1 = new HashSet<tbl_course_subject_timetable>();
            tbl_enrollment_class = new HashSet<tbl_enrollment_class>();
            tbl_enrollment_class_staff = new HashSet<tbl_enrollment_class_staff>();
            tbl_position_staff = new HashSet<tbl_position_staff>();
            tbl_role_tution_enrollment_class = new HashSet<tbl_role_tution_enrollment_class>();
            tbl_timesheet = new HashSet<tbl_timesheet>();
            tbl_staff_disciplinary_history = new HashSet<tbl_staff_disciplinary_history>();
            tbl_staff_work_schedule = new HashSet<tbl_staff_work_schedule>();
            tbl_staff_allowance_history = new HashSet<tbl_staff_allowance_history>();
            tbl_staff_salary_history = new HashSet<tbl_staff_salary_history>();
            tbl_staff_reward_history = new HashSet<tbl_staff_reward_history>();
            tbl_staff_travelling_history = new HashSet<tbl_staff_travelling_history>();
            tbl_staff_salary_property = new HashSet<tbl_staff_salary_property>();
            tbl_staff_education_history = new HashSet<tbl_staff_education_history>();
            tbl_staff_civil_servant_grade = new HashSet<tbl_staff_civil_servant_grade>();
            tbl_staff_labour_agreement = new HashSet<tbl_staff_labour_agreement>();
            tbl_staff_family_relationship = new HashSet<tbl_staff_family_relationship>();
        }

        public int? current_working_status { get; set; }

        [StringLength(255)]
        public string social_insurance_number { get; set; }

        [StringLength(255)]
        public string staff_code { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_calendar_event_attendee> tbl_calendar_event_attendee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject> tbl_course_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_timetable> tbl_course_subject_timetable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_timetable> tbl_course_subject_timetable1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class> tbl_enrollment_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_enrollment_class_staff> tbl_enrollment_class_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_position_staff> tbl_position_staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_role_tution_enrollment_class> tbl_role_tution_enrollment_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_timesheet> tbl_timesheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_disciplinary_history> tbl_staff_disciplinary_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_work_schedule> tbl_staff_work_schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_allowance_history> tbl_staff_allowance_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_salary_history> tbl_staff_salary_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_reward_history> tbl_staff_reward_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_travelling_history> tbl_staff_travelling_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_salary_property> tbl_staff_salary_property { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_education_history> tbl_staff_education_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_civil_servant_grade> tbl_staff_civil_servant_grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_labour_agreement> tbl_staff_labour_agreement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_staff_family_relationship> tbl_staff_family_relationship { get; set; }
    }
}

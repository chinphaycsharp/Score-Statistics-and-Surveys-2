namespace XLT_TLU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_budget_distribution
    {
        public double? actually_fund { get; set; }

        public double? multilevel { get; set; }

        public int? number_student { get; set; }

        public double? residual { get; set; }

        public double? total_funds { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? course_year_id { get; set; }

        public long? department_id { get; set; }

        public long? class_id { get; set; }

        public long? semester_id { get; set; }

        public long? speciality_id { get; set; }

        public virtual tbl_semester tbl_semester { get; set; }

        public virtual tbl_speciality tbl_speciality { get; set; }

        public virtual tbl_person tbl_person { get; set; }

        public virtual tbl_course_year tbl_course_year { get; set; }

        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }

        public virtual tbl_department tbl_department { get; set; }
    }
}

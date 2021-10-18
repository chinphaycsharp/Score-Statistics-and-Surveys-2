using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class Mark
    {
        public string semesterName { get; set; }
        public long couresSubjectID { get; set; }
        public string courseSubjectName { get; set; }
        public string teacherName { get; set; }
        public double? student_Mark { get; set; }
        public double? student_Subject_Mark { get; set; }

        public string subjectName { get; set; }

        public long? numberOfCredit { get; set; }
        public Mark()
        {

        }

        public Mark(string semesterName, long couresSubjectID, string courseSubjectName, string teacherName, double? student_Mark, double? student_Subject_Mark, string subjectName, long? numberOfCredit)
        {
            this.semesterName = semesterName;
            this.couresSubjectID = couresSubjectID;
            this.courseSubjectName = courseSubjectName;
            this.teacherName = teacherName;
            this.student_Mark = student_Mark;
            this.student_Subject_Mark = student_Subject_Mark;
            this.subjectName = subjectName;
            this.numberOfCredit = numberOfCredit;
        }
    }
}
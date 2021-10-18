using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class MarkBySemester
    {
        public MarkBySemester()
        {

        }
        public MarkBySemester(long _id, String _student_code, String _student_name, double _mark, double _mark_exam, double _mark_final, char _gpa, double _mark_gpa, String _note)
        {
            this.id = _id;
            this.student_code = _student_code;
            this.student_name = _student_name;
            this.mark = _mark;
            this.mark_exam = _mark_exam;
            this.mark_final = _mark_final;
            this.gpa = _gpa;
            this.mark_gpa = _mark_gpa;
            this.note = _note;
        }

        public long id { get; set; }
        public String student_code { get; set; }
        public String student_name { get; set; }
        public double? mark { get; set; }
        public double? mark_exam { get; set; }
        public double? mark_final { get; set; }
        public char gpa { get; set; }
        public double? mark_gpa { get; set; }
        public String note { get; set; }


    }
}

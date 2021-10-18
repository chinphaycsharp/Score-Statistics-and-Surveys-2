using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class MyData
    {
        public long id { get; set; }
        //tên khóa học
        public String courseSubjectName { get; set; }
        //tên giảng viên
        public String teacherName { get; set; }
        //tổng số lượng bản ghi
        public long? summary { get; set; }

        public long? mark4_a { get; set; } //tổng A
        public double? rate_mark4_a { get; set; } //tỉ lệ A
        public long? mark4_b { get; set; } //
        public double? rate_mark4_b { get; set; }
        public long? mark4_c { get; set; }
        public double? rate_mark4_c { get; set; }
        public long? mark4_d { get; set; }
        public double? rate_mark4_d { get; set; }
        public long? mark4_f { get; set; }
        public double? rate_mark4_f { get; set; }
        public String note { get; set; }

        public MyData()
        {

        }

        public MyData(long _id, String course_subject_name, String teacher_name, long _sum, long _sum_A, double _rate_A,
            long _sum_B, double _rate_B, long _sum_C, double _rate_C, long _sum_D, double _rate_D, long _sum_F, double _rate_F)
        {
            this.id = _id;
            this.courseSubjectName = course_subject_name;
            this.teacherName = teacher_name;
            this.summary = _sum;
            this.mark4_a = _sum_A;
            this.mark4_b = _sum_B;
            this.mark4_c = _sum_C;
            this.mark4_d = _sum_D;
            this.mark4_f = _sum_F;
            this.rate_mark4_a = _rate_A;
            this.rate_mark4_b = _rate_B;
            this.rate_mark4_c = _rate_C;
            this.rate_mark4_d = _rate_D;
            this.rate_mark4_f = _rate_F;
        }
    }
}
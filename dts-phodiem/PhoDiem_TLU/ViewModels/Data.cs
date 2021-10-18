using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class Data
    {
        public Data(long stt, string semesterName, string courseSubjectName, string teacherName, long sum, long a, double rateA, long b, double rateB, long c, double rateC, long d, double rateD, long f, double rateF, string subjectName, long? numberOfCredit)
        {
            this.stt = stt;
            this.semesterName = semesterName;
            this.courseSubjectName = courseSubjectName;
            this.teacherName = teacherName;
            this.sum = sum;
            A = a;
            this.rateA = rateA;
            B = b;
            this.rateB = rateB;
            C = c;
            this.rateC = rateC;
            D = d;
            this.rateD = rateD;
            F = f;
            this.rateF = rateF;
            this.subjectName = subjectName;
            this.numberOfCredit = numberOfCredit;
        }

        public long stt { set; get; }
        public string semesterName { set; get; }
        public string courseSubjectName { set; get; }
        public string teacherName { set; get; }
        public long sum { set; get; }
        public long A { set; get; }
        public double rateA { set; get; }
        public long B { set; get; }
        public double rateB { set; get; }
        public long C { set; get; }
        public double rateC { set; get; }
        public long D { set; get; }
        public double rateD { set; get; }
        public long F { set; get; }
        public double rateF { set; get; }
        public string subjectName { get; set; }

        public long? numberOfCredit { get; set; }

        
    }
}
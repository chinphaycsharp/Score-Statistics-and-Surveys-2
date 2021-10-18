using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoDiem_TLU.ViewModels
{
    public class MarksByEnrollmentClass
    {
        public MarksByEnrollmentClass(long stt, string subjectName, string enrollmentClassName, long sumMark, long a, double rateA, long b, double rateB, long c, double rateC, long d, double rateD, long f, double rateF)
        {
            this.stt = stt;
            this.subjectName = subjectName;
            this.enrollmentClassName = enrollmentClassName;
            this.sumMark = sumMark;
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
        }

        public long stt { get; set; }
        public string subjectName { get; set; }
        public string enrollmentClassName { get; set; }
        public long sumMark { get; set; }

        public long A { get; set; }
        public double rateA { get; set; }
        public long B { get; set; }
        public double rateB { get; set; }
        public long C { get; set; }
        public double rateC { get; set; }
        public long D { get; set; }
        public double rateD { get; set; }
        public long F { get; set; }
        public double rateF { get; set; }





    }
}
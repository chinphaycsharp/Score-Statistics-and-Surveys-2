using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XLT_TLU.Models;

namespace PhoDiem_TLU.DatabaseIO
{
    
    public class DBIO
    {
        DTSTLUModels models = new DTSTLUModels();

        //Lấy thông tin danh sách sinh viên của một môn học trong nhiều năm
        public List<Mark> getMarks(long? subject_id, long? school_year_id_start, long? school_year_id_end)
        {

            var list = (
                // lay hoc ki
                from school in models.tbl_shool_year
                join semester in models.tbl_semester
                on school.id equals semester.school_year_id

                //Lay hoc ki mon hoc
                join semesterSubject in models.tbl_semester_subject
                on semester.id equals semesterSubject.semester_id
                join subject in models.tbl_subject
                on semesterSubject.subject_id equals subject.id

                //tim nhom lop
                join couresSubject in models.tbl_course_subject
                on semesterSubject.id equals couresSubject.semester_subject_id

                // tim nhom lop sinh vien
                join studentCourseSubject in models.tbl_student_course_subject
                on couresSubject.id equals studentCourseSubject.course_subject_id

                //Tim ten giao vien
                join person in models.tbl_person
                on couresSubject.teacher_id equals person.id
                //tim diem tong ket
                from studentSubjectMark in models.tbl_student_subject_mark


                    //Tim nhom diem qua trinh
                from studentMark in models.tbl_student_mark


                    //
                where school.id >= school_year_id_start && school.id <= school_year_id_end && subject.id == subject_id


                //Tim diem
                && studentSubjectMark.semester_id == semester.id
                && studentSubjectMark.subject_id == subject.id
                && studentMark.student_course_subject_id == studentCourseSubject.id
                && studentMark.student_subject_mark_id == studentSubjectMark.id
                select new
                    {
                        semester = semester.id,
                        semesterName = semester.semester_name,
                        subjectName = subject.subject_name,
                        numberOfCredit= subject.number_of_credit,
                        couresSubjectID = couresSubject.id,
                        courseSubjectName = couresSubject.display_name,
                        teacherName = person.display_name,
                        student_Mark = studentMark.mark,
                        student_Subject_Mark = studentSubjectMark.mark4
                    }).ToList().Select(s=> new Mark(s.semesterName, s.couresSubjectID, s.courseSubjectName,
                s.teacherName, s.student_Mark, s.student_Subject_Mark,s.subjectName,s.numberOfCredit));


            return list.ToList();
        }
        public List<StudentCourseSubject> getMarks_2(long? subject_id, long? school_year_id_start, long? school_year_id_end)
        {

            var list = (
                // lay hoc ki
                from school in models.tbl_shool_year
                join semester in models.tbl_semester
                on school.id equals semester.school_year_id

                //Lay hoc ki mon hoc
                join semesterSubject in models.tbl_semester_subject
                on semester.id equals semesterSubject.semester_id
                join subject in models.tbl_subject
                on semesterSubject.subject_id equals subject.id

                //tim nhom lop
                join couresSubject in models.tbl_course_subject
                on semesterSubject.id equals couresSubject.semester_subject_id

                // tim nhom lop sinh vien
                join studentCourseSubject in models.tbl_student_course_subject
                on couresSubject.id equals studentCourseSubject.course_subject_id

                //Tim ten giao vien
                join person in models.tbl_person
                on couresSubject.teacher_id equals person.id
                
                //Tim nhom diem qua trinh
                from studentMark in models.tbl_student_mark     //
                where school.id >= school_year_id_start && school.id <= school_year_id_end && subject.id == subject_id
                && studentMark.student_id == studentCourseSubject.student_id
                && studentMark.subject_id == subject_id
                
                select new
                {
                    studentId = studentMark.student_id,
                    mark = studentMark.mark,
                    subjectId = subject.id,
                    couresSubjectID = couresSubject.id,
                    courseSubjectName = couresSubject.display_name,
                    teacherName = person.display_name,
                    subjectName = subject.subject_name,
                    numberOfCredit = subject.number_of_credit,
                    semesterID = semester.id,
                    semesterName = semester.semester_name,
                    subjectExamID = studentMark.subject_exam_id,
                    studentSubjectMarkID = studentMark.student_subject_mark_id

                }
                ).ToList().Select(x => new StudentCourseSubject(x.studentId,x.mark, x.subjectId,x.couresSubjectID,
                x.courseSubjectName,x.teacherName,x.subjectName,x.numberOfCredit,x.semesterID, x.semesterName, x.subjectExamID,x.studentSubjectMarkID));


            return list.ToList();
        }
        public List<MarksByEnrollmentClass> getMarksEnrollmentClass(long? subject_id, long? school_year_id_start, long? school_year_id_end, long subject_exam_type_id)
        {
            var listStudent = (from schoolYear in models.tbl_shool_year
                          join enrollmentClass in models.tbl_enrollment_class
                          on schoolYear.year equals enrollmentClass.schoolYear

                          join student in models.tbl_student
                          on enrollmentClass.id equals student.class_id

                          join studentMark in models.tbl_student_mark
                          on student.id equals studentMark.student_id

                          join subject in models.tbl_subject
                          on studentMark.subject_id equals subject.id

                          join subjectExam in models.tbl_subject_exam
                          on studentMark.subject_exam_id equals subjectExam.id

                          where schoolYear.id >= school_year_id_start && schoolYear.id <= school_year_id_end
                          && subject.id == subject_id
                          && subjectExam.subject_exam_type_id == subject_exam_type_id

                          select new
                          {
                                enrollmentClassID = enrollmentClass.id,
                                enrollmentClassName = enrollmentClass.className,
                                subjectName = subject.subject_name,
                                mark = studentMark.mark
                          }).ToList();
            var result = (from list in listStudent
                          group list by list.enrollmentClassID into listGroup
                          from sublist in listStudent
                          where listGroup.Key == sublist.enrollmentClassID
                          select new
                          {
                              enrollmentClassID = listGroup.Key,
                              enrollmentClassName = sublist.enrollmentClassName,
                              subjectName = sublist.subjectName,
                              Tong = listGroup.Count(),
                              A = listGroup.Count(x => x.mark >= 8.45 && x.mark <= 10),
                              B = listGroup.Count(x => x.mark >= 6.95 && x.mark < 8.45),
                              C = listGroup.Count(x => x.mark >= 5.45 && x.mark < 6.95),
                              D = listGroup.Count(x => x.mark >= 3.95 && x.mark < 5.45),
                              F = listGroup.Count(x => x.mark >= 0 && x.mark < 3.95)

                          }
                          ).Distinct().ToList().Select(x => new MarksByEnrollmentClass(0,x.subjectName,x.enrollmentClassName,x.Tong,
                              x.A,
                              Math.Round((double)x.A * 100 / x.Tong, 2),
                              x.B, 
                              Math.Round((double)x.B * 100 / x.Tong, 2),
                              x.C, 
                              Math.Round((double)x.C * 100 / x.Tong, 2),
                              x.D, 
                              Math.Round((double)x.D * 100 / x.Tong, 2),
                              x.F,
                              Math.Round((double)x.F * 100 / x.Tong, 2)

                          )).ToList();

            int i = 1;
            foreach (MarksByEnrollmentClass item in result)
            {
                item.stt = i++;
            }
            return result;
        }
        public List<MarksByEnrollmentClass> getMarksEnrollmentClass(long? subject_id, long? school_year_id_start, long? school_year_id_end)
        {
            var listStudent = (from schoolYear in models.tbl_shool_year
                               join enrollmentClass in models.tbl_enrollment_class
                               on schoolYear.year equals enrollmentClass.schoolYear

                               join student in models.tbl_student
                               on enrollmentClass.id equals student.class_id

                               join studentSubjectMark in models.tbl_student_subject_mark
                               on student.id equals studentSubjectMark.student_id

                               join subject in models.tbl_subject
                               on studentSubjectMark.subject_id equals subject.id

                              

                               where schoolYear.id >= school_year_id_start && schoolYear.id <= school_year_id_end
                               && subject.id == subject_id
                               select new
                               {
                                   enrollmentClassID = enrollmentClass.id,
                                   enrollmentClassName = enrollmentClass.className,
                                   subjectName = subject.subject_name,
                                   mark = studentSubjectMark.mark
                               }).ToList();
            var result = (from list in listStudent
                          group list by list.enrollmentClassID into listGroup
                          from sublist in listStudent
                          where listGroup.Key == sublist.enrollmentClassID
                          select new
                          {
                              enrollmentClassID = listGroup.Key,
                              enrollmentClassName = sublist.enrollmentClassName,
                              subjectName = sublist.subjectName,
                              Tong = listGroup.Count(),
                              A = listGroup.Count(x => x.mark >= 8.45 && x.mark <= 10),
                              B = listGroup.Count(x => x.mark >= 6.95 && x.mark < 8.45),
                              C = listGroup.Count(x => x.mark >= 5.45 && x.mark < 6.95),
                              D = listGroup.Count(x => x.mark >= 3.95 && x.mark < 5.45),
                              F = listGroup.Count(x => x.mark >= 0 && x.mark < 3.95)

                          }
                          ).Distinct().ToList().Select(x => new MarksByEnrollmentClass(0, x.subjectName, x.enrollmentClassName, x.Tong,
                              x.A,
                              Math.Round((double)x.A * 100 / x.Tong, 2),
                              x.B,
                              Math.Round((double)x.B * 100 / x.Tong, 2),
                              x.C,
                              Math.Round((double)x.C * 100 / x.Tong, 2),
                              x.D,
                              Math.Round((double)x.D * 100 / x.Tong, 2),
                              x.F,
                              Math.Round((double)x.F * 100 / x.Tong, 2)

                          )).ToList();
            int i = 1;
            foreach (MarksByEnrollmentClass item in result)
            {
                item.stt = i++;
            }
            return result;
        }

        public List<MarksByEnrollmentClass> getMarksEnrollmentClass(long? hocKy, long? khoaHoc, long? dotHoc, long? monHoc, long subject_exam_type_id)
        {
            var listStudent =(from student in models.tbl_student
                              join enrollmentClass in models.tbl_enrollment_class
                              on student.class_id equals enrollmentClass.id

                              join studentMark in models.tbl_student_mark
                              on student.id equals studentMark.student_id

                              join subject in models.tbl_subject
                              on studentMark.subject_id equals subject.id

                              join subjectExam in models.tbl_subject_exam
                              on studentMark.subject_exam_id equals subjectExam.id

                              join semesterSubject in models.tbl_semester_subject
                              on studentMark.semester_subject_id equals semesterSubject.id
                              join semester in models.tbl_semester
                              on semesterSubject.semester_id equals semester.id

                              join srp in models.tbl_semester_register_period
                              on semesterSubject.semester_id equals srp.semeter_id                                                      

                              where
                              semester.id ==hocKy
                              && semesterSubject.course_year_id == khoaHoc
                              && srp.id == dotHoc
                              && studentMark.subject_id ==monHoc
                              && subjectExam.subject_exam_type_id == subject_exam_type_id

                              select new
                              {
                                  enrollmentClassID = enrollmentClass.id,
                                  enrollmentClassName = enrollmentClass.className,
                                  subjectName = subject.subject_name,
                                  mark = studentMark.mark
                              }).ToList();

            var result = (from list in listStudent
                          group list by list.enrollmentClassID into listGroup
                          from sublist in listStudent
                          where listGroup.Key == sublist.enrollmentClassID
                          select new
                          {
                              enrollmentClassID = listGroup.Key,
                              enrollmentClassName = sublist.enrollmentClassName,
                              subjectName = sublist.subjectName,
                              Tong = listGroup.Count(),
                              A = listGroup.Count(x => x.mark >= 8.45 && x.mark <= 10),
                              B = listGroup.Count(x => x.mark >= 6.95 && x.mark < 8.45),
                              C = listGroup.Count(x => x.mark >= 5.45 && x.mark < 6.95),
                              D = listGroup.Count(x => x.mark >= 3.95 && x.mark < 5.45),
                              F = listGroup.Count(x => x.mark >= 0 && x.mark < 3.95)

                          }
                              ).Distinct().ToList().Select(x => new MarksByEnrollmentClass(0, x.subjectName, x.enrollmentClassName, x.Tong,
                                  x.A,
                                  Math.Round((double)x.A * 100 / x.Tong, 2),
                                  x.B,
                                  Math.Round((double)x.B * 100 / x.Tong, 2),
                                  x.C,
                                  Math.Round((double)x.C * 100 / x.Tong, 2),
                                  x.D,
                                  Math.Round((double)x.D * 100 / x.Tong, 2),
                                  x.F,
                                  Math.Round((double)x.F * 100 / x.Tong, 2)

                              )).ToList();

            int i = 1;
            foreach (MarksByEnrollmentClass item in result)
            {
                item.stt = i++;
            }
            return result;


        }
        public List<MarksByEnrollmentClass> getMarksEnrollmentClass(long? hocKy, long? khoaHoc, long? dotHoc, long? monHoc)
        {
            var listStudent = (from student in models.tbl_student
                               join enrollmentClass in models.tbl_enrollment_class
                               on student.class_id equals enrollmentClass.id

                               join studentMark in models.tbl_student_mark
                               on student.id equals studentMark.student_id

                               join subject in models.tbl_subject
                               on studentMark.subject_id equals subject.id

                               join subjectExam in models.tbl_subject_exam
                               on studentMark.subject_exam_id equals subjectExam.id

                               join semesterSubject in models.tbl_semester_subject
                               on studentMark.semester_subject_id equals semesterSubject.id
                               join semester in models.tbl_semester
                               on semesterSubject.semester_id equals semester.id

                               join srp in models.tbl_semester_register_period
                               on semesterSubject.semester_id equals srp.semeter_id

                               where
                               semester.id == hocKy
                               && semesterSubject.course_year_id == khoaHoc
                               && srp.id == dotHoc
                               && studentMark.subject_id == monHoc

                               select new
                               {
                                   enrollmentClassID = enrollmentClass.id,
                                   enrollmentClassName = enrollmentClass.className,
                                   subjectName = subject.subject_name,
                                   mark = studentMark.mark
                               }).ToList();

            var result = (from list in listStudent
                          group list by list.enrollmentClassID into listGroup
                          from sublist in listStudent
                          where listGroup.Key == sublist.enrollmentClassID
                          select new
                          {
                              enrollmentClassID = listGroup.Key,
                              enrollmentClassName = sublist.enrollmentClassName,
                              subjectName = sublist.subjectName,
                              Tong = listGroup.Count(),
                              A = listGroup.Count(x => x.mark >= 8.45 && x.mark <= 10),
                              B = listGroup.Count(x => x.mark >= 6.95 && x.mark < 8.45),
                              C = listGroup.Count(x => x.mark >= 5.45 && x.mark < 6.95),
                              D = listGroup.Count(x => x.mark >= 3.95 && x.mark < 5.45),
                              F = listGroup.Count(x => x.mark >= 0 && x.mark < 3.95)

                          }
                              ).Distinct().ToList().Select(x => new MarksByEnrollmentClass(0, x.subjectName, x.enrollmentClassName, x.Tong,
                                  x.A,
                                  Math.Round((double)x.A * 100 / x.Tong, 2),
                                  x.B,
                                  Math.Round((double)x.B * 100 / x.Tong, 2),
                                  x.C,
                                  Math.Round((double)x.C * 100 / x.Tong, 2),
                                  x.D,
                                  Math.Round((double)x.D * 100 / x.Tong, 2),
                                  x.F,
                                  Math.Round((double)x.F * 100 / x.Tong, 2)

                              )).ToList();

            int i = 1;
            foreach (MarksByEnrollmentClass item in result)
            {
                item.stt = i++;
            }
            return result;


        }
        //Lấy tong so diem A,B,C,D trong nhiều năm
        public Object getSumMarks(List<MarkByTeacher> list)
        {
            long[] result = { 0, 0, 0, 0, 0 };
            foreach(var item in list)
            {
                if (item.A > 0) result[0] += item.A;
                if (item.B > 0) result[1] += item.B;
                if (item.C > 0) result[2] += item.C;
                if (item.D > 0) result[3] += item.D;
                if (item.F > 0) result[4] += item.F;
            }
            return result;
        }
        public Object getSumMarks(List<Data> list)
        {
            long[] result = { 0, 0, 0, 0, 0 };
            foreach (var item in list)
            {
                if (item.A > 0) result[0]+=item.A;
                if (item.B > 0) result[1]+=item.B;
                if (item.C > 0) result[2]+=item.C;
                if (item.D > 0) result[3]+=item.D;
                if (item.F > 0) result[4]+=item.F;
            }
            return result;
        }
        public Object getSumMarks(List<MarksByEnrollmentClass> list)
        {
            long[] result = { 0, 0, 0, 0, 0 };
            foreach (var item in list)
            {
                if (item.A > 0) result[0] += item.A;
                if (item.B > 0) result[1] += item.B;
                if (item.C > 0) result[2] += item.C;
                if (item.D > 0) result[3] += item.D;
                if (item.F > 0) result[4] += item.F;
            }
            return result;
        }

        public List<tbl_subject> getSubject()
        {
            var list = (from s in models.tbl_subject
                        select s).ToList();
            return list;
        }
        public string getSubject(long? subjectId)
        {
            var subjectName = models.tbl_subject.Where(x => x.id == subjectId).Select(x => x.subject_name).FirstOrDefault();
            return subjectName;
        }
        public long getNumberOfCredit(long? subjectId)
        {
            var numberOfCredit = (long) models.tbl_subject.Where(x => x.id == subjectId).Select(x => x.number_of_credit).FirstOrDefault();
            return numberOfCredit;
        }
        public List<tbl_shool_year> getYear()
        {
            var list = (from s in models.tbl_shool_year
                        select s).ToList();
            return list;
        }
        public long getYear(long? yearID)
        {
            long year = (long)models.tbl_shool_year.Where(x => x.id == yearID).Select(x => x.year).FirstOrDefault();
            return year;
        }
        public List<Data> getCourseSubjectData(List<Mark> list)
        {
            var result = (from ls in list
                          group ls by ls.courseSubjectName into ls_group
                          from ls_2 in list
                          where ls_2.courseSubjectName == ls_group.Key
                          select new
                          {
                              semesterName = ls_2.semesterName,
                              subjectName = ls_2.subjectName,
                              numberOfCredit = ls_2.numberOfCredit,
                              courseSubjectName = ls_group.Key,
                              teacherName = ls_2.teacherName,
                              Tong = ls_group.Count(),
                              A = ls_group.Count(x => x.student_Subject_Mark == 4),
                              B = ls_group.Count(x => x.student_Subject_Mark == 3),
                              C = ls_group.Count(x => x.student_Subject_Mark == 2),
                              D = ls_group.Count(x => x.student_Subject_Mark == 1),
                              F = ls_group.Count(x => x.student_Subject_Mark == 0),
                          }).Distinct().ToList().Select(x => new Data(0, x.semesterName, x.courseSubjectName, x.teacherName, x.Tong,
                          x.A,
                          Math.Round((double)x.A * 100 / x.Tong, 2),
                          x.B,
                          Math.Round((double)x.B * 100 / x.Tong, 2),
                          x.C,
                          Math.Round((double)x.C * 100 / x.Tong, 2),
                          x.D,
                          Math.Round((double)x.D * 100 / x.Tong, 2),
                          x.F,
                          Math.Round((double)x.F * 100 / x.Tong, 2),
                          x.subjectName, x.numberOfCredit
                          )).ToList();
            int i = 1;
            foreach (Data item in result)
            {
                item.stt = i++;
            }
            return result;
        }

        public string getSemester(long? hocKy)
        {
            var semesterName = models.tbl_semester.Where(x => x.id == hocKy).Select(x => x.semester_name).FirstOrDefault();
            return semesterName;
        }

        public List<Data> getCourseSubjectData(List<StudentCourseSubject> studentCourseSubjects, long subject_exam_type_id )
        {
            var Marks = (from scs in studentCourseSubjects
                          join subjectExam in models.tbl_subject_exam
                          on scs.subjectExamID equals subjectExam.id

                          where subjectExam.subject_exam_type_id == subject_exam_type_id
                         select new
                          {
                              studentId = scs.studentId,
                              mark = scs.mark,
                              subjectId = scs.subjectId,
                              couresSubjectID = scs.couresSubjectID,
                              courseSubjectName = scs.courseSubjectName,
                              teacherName = scs.teacherName,
                              subjectName = scs.subjectName,
                              numberOfCredit = scs.numberOfCredit,
                              semesterName = scs.semesterName,
                              subjectExamID = scs.subjectExamID,
                              
                          }).ToList();
            var result = (from ls in Marks
                          group ls by ls.courseSubjectName into ls_group
                          from ls_2 in Marks
                          where ls_2.courseSubjectName == ls_group.Key
                          select new
                          {
                              semesterName = ls_2.semesterName,
                              subjectName = ls_2.subjectName,
                              numberOfCredit = ls_2.numberOfCredit,
                              courseSubjectName = ls_group.Key,
                              teacherName = ls_2.teacherName,
                              Tong = ls_group.Count(),
                              A = ls_group.Count(x => x.mark >= 8.45 && x.mark <= 10),
                              B = ls_group.Count(x => x.mark >= 6.95 && x.mark < 8.45),
                              C = ls_group.Count(x => x.mark >= 5.45 && x.mark < 6.95),
                              D = ls_group.Count(x => x.mark >= 3.95 && x.mark < 5.45),
                              F = ls_group.Count(x => x.mark >= 0 && x.mark < 3.95),
                          }).Distinct().ToList().Select(x => new Data(0, x.semesterName, x.courseSubjectName, x.teacherName, x.Tong,
                          x.A,
                          Math.Round((double)x.A * 100 / x.Tong, 2),
                          x.B,
                          Math.Round((double)x.B * 100 / x.Tong, 2),
                          x.C,
                          Math.Round((double)x.C * 100 / x.Tong, 2),
                          x.D,
                          Math.Round((double)x.D * 100 / x.Tong, 2),
                          x.F,
                          Math.Round((double)x.F * 100 / x.Tong, 2),
                          x.subjectName, x.numberOfCredit
                          )).ToList();
            int i = 1;
            foreach (Data item in result)
            {
                item.stt = i++;
            }
            return result;
           
        }
        
        //lấy điểm của một môn học do giáo viên đảm nhận trong nhiêu năm
        public List<MarkByTeacher> getMarkByTeacher(List<StudentCourseSubject> studentCourseSubjects, long subject_exam_type_id)
        {
            var Marks = (from scs in studentCourseSubjects
                         join subjectExam in models.tbl_subject_exam
                         on scs.subjectExamID equals subjectExam.id

                         where subjectExam.subject_exam_type_id == subject_exam_type_id
                         select new
                         {
                             studentId = scs.studentId,
                             mark = scs.mark,
                             subjectId = scs.subjectId,
                             couresSubjectID = scs.couresSubjectID,
                             courseSubjectName = scs.courseSubjectName,
                             teacherName = scs.teacherName,
                             subjectName = scs.subjectName,
                             numberOfCredit = scs.numberOfCredit,
                             semesterName = scs.semesterName,
                             subjectExamID = scs.subjectExamID,

                         }).ToList();
            var result = (from ls in Marks
                          group ls by ls.teacherName into ls_group
                          from ls_2 in Marks
                          where ls_group.Key == ls_2.teacherName
                          select new
                          {
                              subjectName = ls_2.subjectName,
                              teacherName = ls_group.Key,
                              Tong = ls_group.Count(),
                              A = ls_group.Count(x => x.mark >= 8.45 && x.mark <= 10),
                              B = ls_group.Count(x => x.mark >= 6.95 && x.mark < 8.45),
                              C = ls_group.Count(x => x.mark >= 5.45 && x.mark < 6.95),
                              D = ls_group.Count(x => x.mark >= 3.95 && x.mark < 5.45),
                              F = ls_group.Count(x => x.mark >= 0 && x.mark < 3.95),
                              numberOfCredit = ls_2.numberOfCredit

                          }).Distinct().ToList().Select(x => new MarkByTeacher(0, x.subjectName, x.teacherName, x.Tong,
                          x.A,
                          Math.Round((double)x.A * 100 / x.Tong, 2),
                          x.B,
                          Math.Round((double)x.B * 100 / x.Tong, 2),
                          x.C,
                          Math.Round((double)x.C * 100 / x.Tong, 2),
                          x.D,
                          Math.Round((double)x.D * 100 / x.Tong, 2),
                          x.F,
                          Math.Round((double)x.F * 100 / x.Tong, 2),
                          x.numberOfCredit
                          )).ToList();
            int i = 1;
            foreach (var item in result)
            {
                item.stt = i++;
            }
            return result;
        }
        public List<MarkByTeacher> getMarkByTeacher(List<Data> sublist)
        {
            var result = (from sl in sublist
                          group sl by sl.teacherName into sl_group
                          from sl_2 in sublist
                          where sl_group.Key == sl_2.teacherName
                          select new
                          {
                              subjectName = sl_2.subjectName,
                              teacherName = sl_group.Key,
                              Tong = sl_group.Sum(x => x.sum),
                              A = sl_group.Sum(x => x.A),
                              B = sl_group.Sum(x => x.B),
                              C = sl_group.Sum(x => x.C),
                              D = sl_group.Sum(x => x.D),
                              F = sl_group.Sum(x => x.F),
                              numberOfCredit = sl_2.numberOfCredit
                          }).Distinct().ToList().Select(x => new MarkByTeacher(0, x.subjectName, x.teacherName, x.Tong,
                          x.A,
                          Math.Round((double)x.A * 100 / x.Tong, 2),
                          x.B,
                          Math.Round((double)x.B * 100 / x.Tong, 2),
                          x.C,
                          Math.Round((double)x.C * 100 / x.Tong, 2),
                          x.D,
                          Math.Round((double)x.D * 100 / x.Tong, 2),
                          x.F,
                          Math.Round((double)x.F * 100 / x.Tong, 2),
                          x.numberOfCredit
                          )).ToList();
            int i = 1;
            foreach (var item in result)
            {
                item.stt = i++;
            }
            return result; 
        }

        public List<MarkBySemester> GetMarkBySemester(long id, long subject_id, long semester_id)
        {
            var list_result = new List<MarkBySemester>();
            var list_student = (from s in models.tbl_student_course_subject
                                where s.course_subject_id == id
                                select s.student_id).ToList();

            var list = (from s in models.tbl_course_subject
                        join s1 in models.tbl_student_course_subject
                        on s.id equals s1.course_subject_id

                        join s2 in models.tbl_student_subject_mark
                        on s1.student_id equals s2.student_id

                        join s3 in models.tbl_person
                        on s1.student_id equals s3.id

                        join s4 in models.tbl_student
                        on s1.student_id equals s4.id

                        join s5 in models.tbl_student_mark
                        on s2.id equals s5.student_subject_mark_id

                        join s6 in models.tbl_subject_exam
                        on s5.subject_exam_id equals s6.id

                        where s.id == id
                        && s2.subject_id == subject_id
                        && s2.semester_id == semester_id
                        select new
                        {
                            id = s4.id,
                            code = s4.student_code,
                            name = s3.display_name,
                            mark = s5.mark,
                            mark_final = s2.mark,
                            mark_gpa = s2.mark4,
                            note = s2.note,
                            type = s6.subject_exam_type_id
                        }).ToList();
            int stt = 0;
            foreach (var s in list_student)
            {
                try
                {
                    var mark = list.Where(ss => ss.id == s && ss.type == 2).FirstOrDefault();
                    var mark_exam = list.Where(ss => ss.id == s && ss.type == 3).FirstOrDefault();
                    var temp = list.Where(ss => ss.id == s).FirstOrDefault();
                    if (mark == null || mark_exam == null || temp == null) continue;
                    char gpa = 'F';
                    if ((int)temp.mark_gpa == 4) gpa = 'A';
                    else if ((int)temp.mark_gpa == 3) gpa = 'B';
                    else if ((int)temp.mark_gpa == 2) gpa = 'C';
                    else if ((int)temp.mark_gpa == 1) gpa = 'D';
                    stt++;
                    list_result.Add(new MarkBySemester(stt, temp.code, temp.name, (double)mark.mark, (double)mark_exam.mark, (double)temp.mark_final, gpa, (double)temp.mark_gpa, temp.note));
                }
                catch (Exception e)
                {
                    continue;
                }
            }
            return list_result;
        }
        public List<MarkBySemester> GetMarkByClass(long id, long subject_id, long semester_id)
        {
            var list_result = new List<MarkBySemester>();
            var list_student = (from s in models.tbl_student
                                where s.class_id == id
                                select s.id).ToList();

            var list = (from enroll in models.tbl_enrollment_class
                        join student in models.tbl_student
                        on enroll.id equals student.class_id

                        join subjectMark in models.tbl_student_subject_mark
                        on student.id equals subjectMark.student_id

                        join person in models.tbl_person
                        on student.id equals person.id

                        join mark in models.tbl_student_mark
                        on subjectMark.id equals mark.student_subject_mark_id

                        join exam in models.tbl_subject_exam
                        on mark.subject_exam_id equals exam.id

                        where enroll.id == id
                        && subjectMark.subject_id == subject_id
                        && subjectMark.semester_id == semester_id
                        select new
                        {
                            id = student.id,
                            code = student.student_code,
                            name = person.display_name,
                            mark = mark.mark,
                            mark_final = subjectMark.mark,
                            mark_gpa = subjectMark.mark4,
                            note = subjectMark.note,
                            type = exam.subject_exam_type_id
                        }).ToList();
            int stt = 0;
            foreach (var s in list_student)
            {
                try
                {
                    var mark = list.Where(ss => ss.id == s && ss.type == 2).FirstOrDefault();
                    var mark_exam = list.Where(ss => ss.id == s && ss.type == 3).FirstOrDefault();
                    var temp = list.Where(ss => ss.id == s).FirstOrDefault();
                    if (mark == null || mark_exam == null || temp == null) continue;
                    char gpa = 'F';
                    if ((int)temp.mark_gpa == 4) gpa = 'A';
                    else if ((int)temp.mark_gpa == 3) gpa = 'B';
                    else if ((int)temp.mark_gpa == 2) gpa = 'C';
                    else if ((int)temp.mark_gpa == 1) gpa = 'D';
                    stt++;
                    list_result.Add(new MarkBySemester(stt, temp.code, temp.name, (double)mark.mark, (double)mark_exam.mark, (double)temp.mark_final, gpa, (double)temp.mark_gpa, temp.note));
                }
                catch (Exception e)
                {
                    continue;
                }
            }
            return list_result;
        }

        //lấy điểm của một môn học theo học phần từng năm
        public List<StudentCourseSubject> getMarks_3(long? hocKy, long? khoaHoc, long? dotHoc, long? monHoc )
        {
            var list2 =( from sm in models.tbl_student_mark
                        join ss in models.tbl_semester_subject on sm.semester_subject_id equals ss.id
                        join s in models.tbl_subject on ss.subject_id equals s.id
                        join semester in models.tbl_semester on ss.semester_id equals semester.id
                        join srp in models.tbl_semester_register_period on ss.semester_id equals srp.semeter_id
                        join cs in models.tbl_course_subject on ss.id equals cs.semester_subject_id
                        join scs in models.tbl_student_course_subject on cs.id equals scs.course_subject_id
                        join p in models.tbl_person on cs.teacher_id equals p.id

                        where sm.subject_id ==monHoc
                        && ss.semester_id==hocKy
                        && srp.id==dotHoc
                        && ss.course_year_id ==khoaHoc
                        && sm.student_id == scs.student_id
                        select new
                        {
                            studentId = sm.student_id,
                            mark = sm.mark,
                            subjectId = s.id,
                            courseSubjectID = cs.id,
                            courseSubjectName = cs.display_name,
                            csName = cs.display_name,
                            teacherName = p.display_name,
                            subjectName = s.subject_name,
                            numberOfCredit = s.number_of_credit,
                            semesterID = semester.id,
                            semesterName  = semester.semester_name,
                            subjectExamId = sm.subject_exam_id,
                            studentSubjectMarkID = sm.student_subject_mark_id
                        }).ToList().Select(x => new StudentCourseSubject(x.studentId, x.mark, x.subjectId, x.courseSubjectID,
                x.courseSubjectName, x.teacherName, x.subjectName, x.numberOfCredit, x.semesterID, x.semesterName, x.subjectExamId, x.studentSubjectMarkID));


            return list2.ToList();
        }

        public List<Mark> getListMark(long? hocKy, long? khoaHoc, long? dotHoc, long? monHoc)
        {
            var list_result = (from cs in models.tbl_course_subject
                               join scs in models.tbl_student_course_subject on cs.id equals scs.course_subject_id
                               join sm in models.tbl_student_mark on scs.id equals sm.student_course_subject_id
                               join sub in models.tbl_subject on sm.subject_id equals sub.id
                               join ssm in models.tbl_student_subject_mark on sm.student_subject_mark_id equals ssm.id
                               join ss in models.tbl_semester_subject on sm.semester_subject_id equals ss.id
                               join s in models.tbl_semester on ss.semester_id equals s.id
                               join srp in models.tbl_semester_register_period on s.id equals srp.semeter_id
                               //loai diem
                               join se in models.tbl_subject_exam on sm.subject_exam_id equals se.id
                               //ten giao vien
                               join p in models.tbl_person on cs.teacher_id equals p.id

                               where (srp.id == dotHoc) && (sub.id == monHoc) && (s.id == hocKy) && (ss.course_year_id == khoaHoc)
                               select new
                               {
                                   idhocphan = cs.id, //id học phần
                                   tenhocphan = cs.display_name,//tên học phần
                                   idgiangvien = cs.teacher_id,//giảng viên
                                   tenhocky = s.semester_name,//tên học kỳ
                                   diemtongket = ssm.mark, //điểm tổng kết                           
                                   ssm.mark4,//điểm hệ 4
                                   se.code, //loai diem
                                   semester = s.id,
                                   semesterName = s.semester_name,
                                   subjectName = sub.subject_name,
                                   numberOfCredit = sub.number_of_credit,
                                   couresSubjectID = cs.id,
                                   courseSubjectName = cs.display_name,
                                   teacherName = p.display_name,
                                   student_Mark = sm.mark,
                                   student_Subject_Mark = ssm.mark4
                               }).ToList().Select(s => new Mark(s.semesterName, s.couresSubjectID, s.courseSubjectName,
            s.teacherName, s.student_Mark, s.student_Subject_Mark, s.subjectName, s.numberOfCredit)); 
            
            return list_result.ToList();
        }
    }
}
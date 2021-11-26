using PhoDiem_TLU.Commons;
using PhoDiem_TLU.Core;
using PhoDiem_TLU.DatabaseIO;
using PhoDiem_TLU.Helpers;
using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using XLT_TLU.Models;

namespace PhoDiem_TLU.Controllers
{
    public class SemesterController : Controller
    {
        private XLT_TLU.Models.DTSTLUModels dbSet = new XLT_TLU.Models.DTSTLUModels();

        private DBIO data = new DBIO();

        // GET: Semester
        public ActionResult Index(List<XLT_TLU.Models.tbl_subject> ss)
        {
            //if (Session[Constants.ROLE_EXAM_MANAGERMENT].ToString() == Constants.ROLE_EXAM_MANAGERMENT)
            //{
                SelectList semester = new SelectList((from s in dbSet.tbl_semester select s), "id", "semester_name");
                SelectList course_year = new SelectList((from c_y in dbSet.tbl_course_year select c_y), "id", "name");
                SelectList subject = new SelectList((from s in dbSet.tbl_subject select s), "id", "subject_name");
                SelectList semester_register_period = new SelectList((from s_r_p in dbSet.tbl_semester_register_period select s_r_p), "id", "name");

                //SelectList cateList = new SelectList(cate, "ID", "THELOAI_NAME");

                ViewBag.semester = semester;
                ViewBag.course_year = course_year;
                ViewBag.subject = subject;
                ViewBag.semester_regitster_period = semester_register_period;
                ViewBag.data = dbSet.tbl_subject.Where(s => s.id < 100).ToList();
                return View();
            //}
            //return RedirectToAction("Error", "Login");
        }

        public JsonResult getSubject(string semesterId, string periodId, string courseId)
        {
            long semester_id = 0;
            long period_id = 0;
            long course_id = 0;
            if (periodId != "") period_id = long.Parse(periodId);
            if (semesterId != "") semester_id = long.Parse(semesterId);
            if (courseId != "") course_id = long.Parse(courseId);

            try
            {
                var list_subject = (from s in dbSet.tbl_subject
                                    join s1 in dbSet.tbl_semester_subject
                                    on s.id equals s1.subject_id
                                    where ((semesterId != "" ? (s1.semester_id == semester_id ? true : false) : true) && (periodId != "" ? (s1.register_period_id == period_id ? true : false) : true) && (courseId != "" ? (s1.course_year_id == course_id ? true : false) : true))
                                    select new { 
                                        s.id,
                                        s.subject_name
                                    }).ToList();

                return Json(new { code = 200, data = list_subject }, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(new { code = 500, data = "Không có dữ liệu!!" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult getGroup(long hocKy, long khoaHoc, long dotHoc, long monHoc)
        {
            try
            {   //danh sách các nhóm môn học
                var subject = dbSet.tbl_semester_subject.Where(s => s.register_period_id == dotHoc
                                     && s.subject_id == monHoc
                                     && s.course_year_id == khoaHoc
                                     && s.semester_id == hocKy).FirstOrDefault();
                var list_subject_gr = (from s in dbSet.tbl_course_subject
                                       where s.semester_subject_id == subject.id
                                       select new
                                       {
                                           s.id,
                                           s.display_name
                                       }).ToList();

                var list_enrollment_class = (from cs in dbSet.tbl_course_subject
                                             join scs in dbSet.tbl_student_course_subject
                                             on cs.id equals scs.course_subject_id
                                             join student in dbSet.tbl_student
                                             on scs.student_id equals student.id
                                             join enroll in dbSet.tbl_enrollment_class
                                             on student.class_id equals enroll.id
                                             where cs.semester_subject_id == subject.id
                                             select new
                                             {
                                                 enroll.id,
                                                 enroll.className
                                             }).Distinct().ToList();

                return Json(new { code = 200, data = list_subject_gr, data1 = list_enrollment_class }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Json(new { code = 500, data = "Không có dữ liệu!!" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult ExportAll(string file)
        {
            try
            {
                var res = file.Split(new string[] { "z" }, StringSplitOptions.None);
                long _id = long.Parse(res[5]);
                var type = res[0];
                var subject_id = long.Parse(res[1]);
                var semester_id = long.Parse(res[2]);
                var course_id = long.Parse(res[3]);
                var period_id = long.Parse(res[4]);

                var semester = dbSet.tbl_semester.Find(semester_id);
                var subject = dbSet.tbl_subject.Find(subject_id);


                ExcelExport export = new ExcelExport();
                var list_gr = new List<tbl_course_subject>();
                var list_class = new List<tbl_enrollment_class>();
                if (type == "gr")
                {
                    //xuat all
                    var semester_subject = dbSet.tbl_semester_subject.Find(dbSet.tbl_course_subject.Find(_id).semester_subject_id).id;
                    list_gr = dbSet.tbl_course_subject.Where(s => s.semester_subject_id == semester_subject).ToList();//tim 1 nhom
                    var result = export.ExportBySemester(list_gr, semester, subject);
                    return File(result, "xlsx/xls", "Phổ điểm" + semester.semester_name + ".xlsx");
                }
                else
                {
                    //tim mon hoc
                    var subject_gr = dbSet.tbl_semester_subject.Where(s => s.register_period_id == period_id
                                     && s.subject_id == subject_id
                                     && s.course_year_id == course_id
                                     && s.semester_id == semester_id).FirstOrDefault();
                    //xuat tat ca bang
                    list_class = (from cs in dbSet.tbl_course_subject
                                  join scs in dbSet.tbl_student_course_subject
                                  on cs.id equals scs.course_subject_id
                                  join student in dbSet.tbl_student
                                  on scs.student_id equals student.id
                                  join enroll in dbSet.tbl_enrollment_class
                                  on student.class_id equals enroll.id
                                  where cs.semester_subject_id == subject_gr.id
                                  select enroll).Distinct().ToList();
                    var result = export.ExportByClass(list_class, semester, subject);
                    return File(result, "xlsx/xls", "Phổ điểm" + semester.semester_name + ".xlsx");
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Export(string file)//xuat 1 bang
        {
            try
            {
                var res = file.Split(new string[] { "z" }, StringSplitOptions.None);
                long _id = long.Parse(res[5]);
                var type = res[0];
                var subject_id = long.Parse(res[1]);
                var semester_id = long.Parse(res[2]);

                var semester = dbSet.tbl_semester.Find(semester_id);
                var subject = dbSet.tbl_subject.Find(subject_id);

                ExcelExport export = new ExcelExport();
                var list_gr = new List<tbl_course_subject>();
                var list_class = new List<tbl_enrollment_class>();
                if (type == "gr")
                {
                    list_gr = dbSet.tbl_course_subject.Where(s => s.id == _id).ToList();//tim 1 nhom
                    var result = export.ExportBySemester(list_gr, semester, subject);
                    return File(result, "xlsx/xls", "Phổ điểm" + semester.semester_name + ".xlsx");
                }
                else
                {
                    list_class = dbSet.tbl_enrollment_class.Where(s => s.id == _id).ToList();
                    var result = export.ExportByClass(list_class, semester, subject);
                    return File(result, "xlsx/xls", "Phổ điểm" + semester.semester_name + ".xlsx");
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }

        public JsonResult GetMark(string id, string type, string subject, string semester)
        {
            try
            {
                int[] list_mark = { 0, 0, 0, 0, 0 };
                int[] list_mark_final = { 0, 0, 0, 0, 0 };
                int[] list_mark_QT = { 0, 0, 0, 0, 0 };

                var list_result = new List<MarkBySemester>();
                if (id != null && id != "")
                {
                    if (type == "gr")
                    {
                        long _id = long.Parse(id);
                        long _subject = long.Parse(subject);
                        long _semester = long.Parse(semester);

                        list_result = data.GetMarkBySemester(_id, _subject, _semester);
                    }
                    else
                    {
                        long _id = long.Parse(id);
                        long _subject = long.Parse(subject);
                        long _semester = long.Parse(semester);

                        list_result = data.GetMarkByClass(_id, _subject, _semester);
                    }
                }

                foreach (var item in list_result)
                {
                    if (getCharMark((double)item.mark_exam) == 0) list_mark[0]++;
                    else if (getCharMark((double)item.mark_exam) == 1) list_mark[1]++;
                    else if (getCharMark((double)item.mark_exam) == 2) list_mark[2]++;
                    else if (getCharMark((double)item.mark_exam) == 3) list_mark[3]++;
                    else list_mark[4]++;

                    if (getCharMark((double)item.mark) == 0) list_mark_QT[0]++;
                    else if (getCharMark((double)item.mark) == 1) list_mark_QT[1]++;
                    else if (getCharMark((double)item.mark) == 2) list_mark_QT[2]++;
                    else if (getCharMark((double)item.mark) == 3) list_mark_QT[3]++;
                    else list_mark_QT[4]++;

                    if (getCharMark((double)item.mark_final) == 0) list_mark_final[0]++;
                    else if (getCharMark((double)item.mark_final) == 1) list_mark_final[1]++;
                    else if (getCharMark((double)item.mark_final) == 2) list_mark_final[2]++;
                    else if (getCharMark((double)item.mark_final) == 3) list_mark_final[3]++;
                    else list_mark_final[4]++;
                }
                return Json(new { code = 200, data = list_result, chart_mark = new { qt = list_mark_QT, exam = list_mark, final = list_mark_final } }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { code = 500, data = "Không có dữ liệu!" }, JsonRequestBehavior.AllowGet);
            }
        }

        public int getCharMark(double mark)
        {
            if (mark <= 10 && mark >= 8.45) return 4;
            if (mark <= 8.44 && mark >= 6.95) return 3;
            if (mark <= 6.94 && mark >= 5.45) return 2;
            if (mark <= 5.44 && mark >= 3.95) return 1;
            return 0;
        }
    }
}
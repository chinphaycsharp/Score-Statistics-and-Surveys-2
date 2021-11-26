using PhoDiem_TLU.Core;
using PhoDiem_TLU.DatabaseIO;
using PhoDiem_TLU.Helpers;
using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PhoDiem_TLU.Controllers
{
    public class StatisticsByCourseSubjectController : Controller
    {
        // GET: StatisticsByCourceSubject
        private XLT_TLU.Models.DTSTLUModels db = new XLT_TLU.Models.DTSTLUModels();

        private DBIO dBIO = new DBIO();
        private ExcelExport ex = new ExcelExport();

        public ActionResult Index()
        {
            setViewbag();
            return View();
        }

        private void setViewbag()
        {
            var subject = dBIO.getSubject();

            List<SelectListItem> provinces = new List<SelectListItem>();
            provinces.Add(new SelectListItem() { Text = "Hiển thị theo nhóm", Value = "HTN" });
            provinces.Add(new SelectListItem() { Text = "Hiển thị theo giáo viên", Value = "HTGV" });
            provinces.Add(new SelectListItem() { Text = "Hiển thị theo lớp quản lý", Value = "HTL" });

            List<SelectListItem> listOption = new List<SelectListItem>();
            listOption.Add(new SelectListItem() { Text = "Điểm quá trình", Value = "Điểm quá trình" });
            listOption.Add(new SelectListItem() { Text = "Điểm thi", Value = "Điểm thi" });
            listOption.Add(new SelectListItem() { Text = "Điểm tổng kết", Value = "Điểm tổng kết" });
            SelectList showOption = new SelectList(provinces, "Value", "Text");
            SelectList markOption = new SelectList(listOption, "Value", "Text");
            SelectList sub = new SelectList(subject, "id", "subject_name");

            SelectList semester = new SelectList((from s in db.tbl_semester select s), "id", "semester_name");
            SelectList course_year = new SelectList((from c_y in db.tbl_course_year select c_y), "id", "name");
            SelectList semester_register_period = new SelectList((from s_r_p in db.tbl_semester_register_period select s_r_p), "id", "name");

            ViewBag.semester = semester;
            ViewBag.course_year = course_year;
            ViewBag.semester_regitster_period = semester_register_period;
            ViewBag.data = db.tbl_subject.Where(s => s.id < 100).ToList();

            ViewBag.subject = sub;
            ViewBag.showOption = showOption;
            ViewBag.markOption = markOption;
        }

        public ActionResult MyView()
        {
            return View();
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
                var list_subject = (from s in db.tbl_subject
                                    join s1 in db.tbl_semester_subject
                                    on s.id equals s1.subject_id
                                    where ((semesterId != "" ? (s1.semester_id == semester_id ? true : false) : true) && (periodId != "" ? (s1.register_period_id == period_id ? true : false) : true) && (courseId != "" ? (s1.course_year_id == course_id ? true : false) : true))
                                    select new
                                    {
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

        public JsonResult MarkResult2(long? hocKy, long? khoaHoc, long? dotHoc, long? monHoc, string showoption, string markOption)
        {
            try
            {
                if (hocKy != null && khoaHoc != null && dotHoc != null && monHoc != null && showoption != null && markOption != null)
                {
                    if (showoption == "HTN")
                    {
                        if (markOption == "Điểm quá trình")
                        {
                            List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_3(hocKy, khoaHoc, dotHoc, monHoc);
                            var data = dBIO.getCourseSubjectData(studentCourseSubjects, 2);
                            var sumMark = dBIO.getSumMarks(data);
                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                        else if (markOption == "Điểm thi")
                        {
                            List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_3(hocKy, khoaHoc, dotHoc, monHoc);

                            var data = dBIO.getCourseSubjectData(studentCourseSubjects, 3);
                            var sumMark = dBIO.getSumMarks(data);

                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                        else //điểm tổng kết
                        {
                            var list = dBIO.getListMark(hocKy, khoaHoc, dotHoc, monHoc);
                            var data = dBIO.getCourseSubjectData(list);
                            var sumMark = dBIO.getSumMarks(data);
                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                    }
                    else if (showoption == "HTGV")
                    {
                        if (markOption == "Điểm quá trình")
                        {
                            List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_3(hocKy, khoaHoc, dotHoc, monHoc);

                            var data = dBIO.getMarkByTeacher(studentCourseSubjects, 2);
                            var sumMark = dBIO.getSumMarks(data);
                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                        else if (markOption == "Điểm thi")
                        {
                            List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_3(hocKy, khoaHoc, dotHoc, monHoc);

                            var data = dBIO.getMarkByTeacher(studentCourseSubjects, 3);
                            var sumMark = dBIO.getSumMarks(data);

                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                        else //điểm tổng kết
                        {
                            List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_3(hocKy, khoaHoc, dotHoc, monHoc);

                            var list = dBIO.getListMark(hocKy, khoaHoc, dotHoc, monHoc);
                            var sublist = dBIO.getCourseSubjectData(list);
                            var data = dBIO.getMarkByTeacher(sublist);
                            var sumMark = dBIO.getSumMarks(data);
                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                    }
                    else //điểm theo lớp quản lý
                    {
                        if (markOption == "Điểm quá trình")
                        {
                            var data = dBIO.getMarksEnrollmentClass(hocKy, khoaHoc, dotHoc, monHoc, 2);
                            var sumMark = dBIO.getSumMarks(data);
                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                        else if (markOption == "Điểm thi")
                        {
                            var data = dBIO.getMarksEnrollmentClass(hocKy, khoaHoc, dotHoc, monHoc, 3);
                            var sumMark = dBIO.getSumMarks(data);

                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                        else //điểm tổng kết
                        {
                            var data = dBIO.getMarksEnrollmentClass(hocKy, khoaHoc, dotHoc, monHoc);
                            var sumMark = dBIO.getSumMarks(data);
                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark
                            }, JsonRequestBehavior.AllowGet);
                        }
                    }
                    return Json(new { code = 404 }, JsonRequestBehavior.AllowGet);
                }
                return Json(new { code = 404 }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Json(new { code = 404, msg = e.Message }, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult Export2(long? hocKy, long? khoaHoc, long? dotHoc, long? monHoc, string showoption, string markOption)
        {
            if (monHoc != null && hocKy != null &&
                khoaHoc != null && dotHoc != null && showoption != null && markOption != null)
            {
                string subjectName = dBIO.getSubject(monHoc);
                string semesterName = dBIO.getSemester(hocKy);
                long numberOfCredit = dBIO.getNumberOfCredit(monHoc);
                if (showoption == "HTN")
                {
                    List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_3(hocKy, khoaHoc, dotHoc, monHoc);
                    List<Data> dataMark;
                    if (markOption == "Điểm thi")
                    {
                        dataMark = dBIO.getCourseSubjectData(studentCourseSubjects, 3);
                    }
                    else if (markOption == "Điểm quá trình")
                    {
                        dataMark = dBIO.getCourseSubjectData(studentCourseSubjects, 2);
                    }
                    else
                    {
                        var list = dBIO.getListMark(hocKy, khoaHoc, dotHoc, monHoc);
                        dataMark = dBIO.getCourseSubjectData(list);
                    }
                    var fileName = $"{markOption}_{subjectName}.xlsx";
                    var data = ex.ExportExcelDataCourseSubject2(markOption, subjectName, numberOfCredit, semesterName, dataMark);
                    return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
                else if (showoption == "HTGV")
                {
                    List<StudentCourseSubject> studentCourseSubjects
                        = dBIO.getMarks_3(hocKy, khoaHoc, dotHoc, monHoc);
                    List<MarkByTeacher> dataMark;
                    if (markOption == "Điểm thi")
                    {
                        dataMark = dBIO.getMarkByTeacher(studentCourseSubjects, 3);
                    }
                    else if (markOption == "Điểm quá trình")
                    {
                        dataMark = dBIO.getMarkByTeacher(studentCourseSubjects, 2);
                    }
                    else
                    {
                        var list = dBIO.getListMark(hocKy, khoaHoc, dotHoc, monHoc);
                        var sublist = dBIO.getCourseSubjectData(list);
                        dataMark = dBIO.getMarkByTeacher(sublist);
                    }
                    var fileName = $"{markOption}_{subjectName}.xlsx";
                    var data = ex.ExportExcelDataTeacher2(markOption, subjectName, numberOfCredit, semesterName, dataMark);
                    return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
                else if (showoption == "HTL")
                {
                    List<MarksByEnrollmentClass> dataMark;
                    if (markOption == "Điểm quá trình")
                    {
                        dataMark = dBIO.getMarksEnrollmentClass(hocKy, khoaHoc, dotHoc, monHoc, 2);
                    }
                    else if (markOption == "Điểm thi")
                    {
                        dataMark = dBIO.getMarksEnrollmentClass(hocKy, khoaHoc, dotHoc, monHoc, 3);
                    }
                    else //điểm tổng kết
                    {
                        dataMark = dBIO.getMarksEnrollmentClass(hocKy, khoaHoc, dotHoc, monHoc);
                    }
                    var fileName = $"{markOption}_{subjectName}.xlsx";
                    var data = ex.ExportExcelDataEnrollmentClass(markOption, subjectName, numberOfCredit, semesterName, dataMark);
                    return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
                else return RedirectToAction("Index");
            }
            else return RedirectToAction("Index");
        }
    }
}
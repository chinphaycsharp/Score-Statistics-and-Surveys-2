using OfficeOpenXml;
using OfficeOpenXml.Style;
using PhoDiem_TLU.Core;
using PhoDiem_TLU.DatabaseIO;
using PhoDiem_TLU.Helpers;
using PhoDiem_TLU.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace PhoDiem_TLU.Controllers
{
    public class MarkController : BaseController
    {
        // GET: Mark
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
            var years = dBIO.getYear();
            List<SelectListItem> provinces = new List<SelectListItem>();
            provinces.Add(new SelectListItem() { Text = "Hiển thị theo nhóm", Value = "HTN" });
            provinces.Add(new SelectListItem() { Text = "Hiển thị theo giáo viên", Value = "HTGV" });
            provinces.Add(new SelectListItem() { Text = "Hiển thị theo lớp quản lý", Value = "HTL" });

            List<SelectListItem> listOption = new List<SelectListItem>();
            listOption.Add(new SelectListItem() { Text = "Điểm quá trình", Value = "Điểm quá trình" });
            listOption.Add(new SelectListItem() { Text = "Điểm thi", Value = "Điểm thi" });
            listOption.Add(new SelectListItem() { Text = "Điểm tổng kết", Value = "Điểm tổng kết" });
            SelectList showOption = new SelectList(provinces,"Value","Text");
            SelectList markOption = new SelectList(listOption, "Value", "Text");
            SelectList s = new SelectList(subject, "id", "subject_name");
            SelectList y = new SelectList(years, "id", "year");
            ViewBag.subject = s;
            ViewBag.years = y;
            ViewBag.showOption = showOption;
            ViewBag.markOption = markOption;
        }
        [HttpPost]
        
        public JsonResult MarkResult(long? subject_id, long? school_year_id_start, long? school_year_id_end,string showoption,string markOption)
        {
            
            try
            {

                if (subject_id != null && school_year_id_start != null && school_year_id_end != null && showoption != null && markOption != null)
                {

                    if (showoption == "HTN")
                    {
                        List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_2(subject_id, school_year_id_start, school_year_id_end);
                        
                        if(markOption == "Điểm quá trình")
                        {
                            var data = dBIO.getCourseSubjectData(studentCourseSubjects, 2);
                            var sumMark = dBIO.getSumMarks(data);
                            //var test = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end);
                            //var test1 = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end,3);
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
                        else
                        {
                            //Diem tong ket
                            var list = dBIO.getMarks(subject_id, school_year_id_start, school_year_id_end);
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
                        List<StudentCourseSubject> studentCourseSubjects = dBIO.getMarks_2(subject_id, school_year_id_start, school_year_id_end);

                        if(markOption == "Điểm quá trình")
                        {

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
                        else
                        {
                            var list = dBIO.getMarks(subject_id, school_year_id_start, school_year_id_end);
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
                    else //Diem theo lop quan ly
                    {
                        if (markOption == "Điểm quá trình")
                        {
                            var data = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end, 2);
                            var sumMark = dBIO.getSumMarks(data);
                            //var test = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end);
                            //var test1 = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end,3);
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
                            var data = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end, 3);
                            var sumMark = dBIO.getSumMarks(data);
                            return Json(new
                            {
                                code = 200,
                                data = data,
                                type = showoption,
                                sumMark = sumMark

                            }, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {
                            //Diem tong ket
                            var data = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end);
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
                }
                return Json(new { code = 404 }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Json(new { code = 404, msg = e.Message }, JsonRequestBehavior.AllowGet);
            }
            
            return Json(new { code = 404 }, JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]
        public ActionResult Export(long? subject_id, long? school_year_id_start, long? school_year_id_end, string showoption, string markOption)
        {
            if (subject_id != null && school_year_id_start != null &&
                school_year_id_end != null && showoption != null && markOption != null)
            {
                long startYear = dBIO.getYear(school_year_id_start);
                long EndYear = dBIO.getYear(school_year_id_end);
                string subjectName = dBIO.getSubject(subject_id);
                long numberOfCredit = dBIO.getNumberOfCredit(subject_id);
                if (showoption == "HTN")
                {
                    List<StudentCourseSubject> studentCourseSubjects
                        = dBIO.getMarks_2(subject_id, school_year_id_start, school_year_id_end);
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
                        var list = dBIO.getMarks(subject_id, school_year_id_start, school_year_id_end);
                        dataMark = dBIO.getCourseSubjectData(list);
                    }
                    var fileName = $"{markOption}_{subjectName}_{startYear}-{EndYear}.xlsx";
                    var data = ex.ExportExcelDataCourseSubject(markOption, subjectName, numberOfCredit, startYear, EndYear, dataMark);
                    return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
                else if (showoption == "HTGV")
                {
                    List<StudentCourseSubject> studentCourseSubjects
                        = dBIO.getMarks_2(subject_id, school_year_id_start, school_year_id_end);
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
                        var list = dBIO.getMarks(subject_id, school_year_id_start, school_year_id_end);
                        var sublist = dBIO.getCourseSubjectData(list);
                        dataMark = dBIO.getMarkByTeacher(sublist);
                    }
                    var fileName = $"{markOption}_{subjectName}_{startYear}-{EndYear}.xlsx";
                    var data = ex.ExportExcelDataTeacher(markOption, subjectName, numberOfCredit, startYear, EndYear, dataMark);
                    return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);

                }
                else
                {
                    List<MarksByEnrollmentClass> dataMark;
                    if (markOption == "Điểm quá trình")
                    {
                        dataMark = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end, 2);
                    }
                    else if (markOption == "Điểm thi")
                    {
                        dataMark = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end, 3);
                    }
                    else
                    {
                        //Diem tong ket
                        dataMark = dBIO.getMarksEnrollmentClass(subject_id, school_year_id_start, school_year_id_end);

                    }
                    var fileName = $"{markOption}_{subjectName}_{startYear}-{EndYear}.xlsx";
                    var data = ex.ExportExcelDataEnrollmentClass(markOption, subjectName, numberOfCredit, startYear, EndYear, dataMark);
                    return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
            }
            else return RedirectToAction("Index");
        }
        
    }
    
}
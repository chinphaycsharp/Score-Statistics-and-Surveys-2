using OfficeOpenXml;
using OfficeOpenXml.Table;
using PhoDiem_TLU.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoDiem_TLU.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        XLT_TLU.Models.DTSTLUModels db = new XLT_TLU.Models.DTSTLUModels();
        public ActionResult Index()
        {
            SelectList semester = new SelectList((from s in db.tbl_semester select s), "id", "semester_name");
            SelectList course_year = new SelectList((from c_y in db.tbl_course_year select c_y), "id", "name");
            SelectList subject = new SelectList((from s in db.tbl_subject select s), "id", "subject_name");
            SelectList semester_register_period = new SelectList((from s_r_p in db.tbl_semester_register_period select s_r_p), "id", "name");

            //SelectList cateList = new SelectList(cate, "ID", "THELOAI_NAME");

            ViewBag.semester = semester;
            ViewBag.course_year = course_year;
            ViewBag.subject = subject;
            ViewBag.semester_regitster_period = semester_register_period;
            ViewBag.data = db.tbl_subject.ToList();
            return View();
        }



        public JsonResult markResult(long hocKy, long khoaHoc, long dotHoc, long monHoc)
        {
            try
            {
                int[] result = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                var subject_group = db.tbl_semester_subject.Where(s => s.register_period_id == dotHoc
                                     && s.subject_id == monHoc
                                     && s.course_year_id == khoaHoc).ToList();

                var list_mark = new List<XLT_TLU.Models.tbl_student_subject_mark>();
                var list_subject_gr = new List<XLT_TLU.Models.tbl_student_mark>();
                foreach (var s in subject_group)
                {
                    var temp = (from s_m in db.tbl_student_mark
                                join s_s_m in db.tbl_student_subject_mark
                                on s_m.student_subject_mark_id equals s_s_m.id
                                where s.id == s_m.semester_subject_id
                                select s_s_m).ToList();
                    if (temp != null)
                    {
                        list_mark.AddRange(temp);
                    }
                }
                ViewBag.data = (from s in db.tbl_subject
                                where s.id < 100
                                select s).ToList();
                foreach (var temp in list_mark)
                {
                    var t = temp.mark;
                    if (t <= 0) result[0]++;
                    else if (t <= 1) result[1]++;
                    else if (t <= 2) result[2]++;
                    else if (t <= 3) result[3]++;
                    else if (t <= 4) result[4]++;
                    else if (t <= 5) result[5]++;
                    else if (t <= 6) result[6]++;
                    else if (t <= 7) result[7]++;
                    else if (t <= 8) result[8]++;
                    else if (t <= 9) result[9]++;
                    else result[10]++;

                }
                return Json(new { data = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Json(new { error = "không thành công" }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult Export()
        {
            //var data = db.tbl_subject.ToList();
            try
            {
                using (var excelPackage = new ExcelPackage(new FileInfo("C:\\Users\\toank\\toan2k1.xlsx")))
                {
                    // Tạo author cho file Excel
                    // Tạo title cho file Excel
                    excelPackage.Workbook.Properties.Title = "EPP test background";
                    if (!excelPackage.File.Exists)
                    {
                        // Add Sheet vào file Excel
                        excelPackage.Workbook.Worksheets.Add("First Sheet");
                    }
                    // Lấy Sheet bạn vừa mới tạo ra để thao tác 
                    ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets.First();
                    workSheet.Cells["A1"].Value = "STT";
                    workSheet.Cells["B1"].Value = "Mã sinh viên";
                    workSheet.Cells["C1"].Value = "Họ và tên";
                    workSheet.Cells["D1"].Value = "DQT";
                    workSheet.Cells["E1"].Value = "THI";
                    workSheet.Cells["F1"].Value = "TKHP";
                    workSheet.Cells["G1"].Value = "Chữ";
                    workSheet.Cells["H1"].Value = "Hệ 4";
                    workSheet.Cells["I1"].Value = "Ghi chú";
                    workSheet.Cells.AutoFitColumns();
                    var k = db.tbl_subject.ToList();
                    for (int i = 0; i < k.Count; i++)
                    {
                        int temp = i + 1;
                        workSheet.Cells[temp, 1].Value = k.ElementAt(i).id;
                        workSheet.Cells[temp, 2].Value = k.ElementAt(i).subject_name;
                        workSheet.Cells[temp, 3].Value = k.ElementAt(i).subject_code;
                        workSheet.Cells[temp, 4].Value = k.ElementAt(i).subject_type;
                        workSheet.Cells[temp, 5].Value = k.ElementAt(i).modified_by;
                        workSheet.Cells[temp, 6].Value = k.ElementAt(i).modify_date;


                    }
                    // Đổ data vào Excel file
                    // BindingFormatForExcel(workSheet, list);
                    //excelPackage.Save();
                    var a = excelPackage.GetAsByteArray();
                    return File(a, "xlsx/xls", "test.xlsx");
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult exportExcel()
        {
            //var data = db.tbl_subject.ToList();
            try
            {
                var result = db.tbl_subject.ToList();

                return Json(new { data = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { error = "không thành công" }, JsonRequestBehavior.AllowGet);
            }

        }


    }
}
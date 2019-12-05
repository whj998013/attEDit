using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
namespace 考勤调整
{
    public static class ExcelBuildHelper
    {
        public static void SaveToExcel(this List<EmpCheckMonth> ecm, string Path)
        {
            XSSFWorkbook wb = new XSSFWorkbook();
            BuildMonthSheets(wb, ecm);
            BuildDaySheets(wb, ecm);
            FileStream file = new FileStream(Path, FileMode.Create);
            wb.Write(file);

        }
        /// <summary>
        /// 生成天考勤数据
        /// </summary>
        private static void BuildDaySheets(XSSFWorkbook wb, List<EmpCheckMonth> ecm)
        {
            var ds = wb.CreateSheet("天考勤数据");
            ds.SetColumnWidth(4, 11 * 256);
            ds.SetColumnWidth(5, 17 * 256);
            ds.SetColumnWidth(6, 17 * 256);
            ds.SetColumnWidth(13, 40 * 256);

            //生成表头
            var rc = ds.CreateRow(0);
            List<string> ClName = new List<string>() { "部门", "姓名", "卡号", "类型", "日期", "首次打卡", "末次打卡", "出勤时间", "当天总工时", "平日上班", "合计加班", "休息日加班", "法定加班", "打卡明细", };
            int ic = 0;
            ClName.ForEach(p =>
            {
                rc.CreateCell(ic++).SetCellValue(p);
            });

            int rid = 1;
            var cellStyle = wb.CreateCellStyle();
            var format = wb.CreateDataFormat();
            cellStyle.DataFormat = format.GetFormat("yyyy-m-d");

            ecm.ForEach(e =>
            {
                e.GetEmpChecks.ForEach(p =>
                {
                    var r = ds.CreateRow(rid++);
                    r.CreateCell(0).SetCellValue(e.DeptName);
                    r.CreateCell(1).SetCellValue(e.EmpName);
                    r.CreateCell(2).SetCellValue(e.EmpId);
                    r.CreateCell(3).SetCellValue(p.DayType.ToString());
                    r.CreateCell(4).SetCellValue(p.CheckDate);
                    r.Cells[4].CellStyle = cellStyle;
                    if (p.Checks != null && e.Checks.Count > 0)
                    {

                        r.CreateCell(5).SetCellValue(p.FirstAmend.ToString());
                        r.CreateCell(6).SetCellValue(p.LastAmend.ToString());
                        r.CreateCell(7).SetCellValue(p.AllTime);
                        r.CreateCell(8).SetCellValue(p.TotalTime);

                        if (p.DayType == DayType.平日)
                        {
                            r.CreateCell(9).SetCellValue(p.WorkTime);
                            r.CreateCell(10).SetCellValue(p.OverTime);
                        }
                        else if (p.DayType == DayType.休息日)
                        {
                            r.CreateCell(11).SetCellValue(p.WorkTime + p.OverTime);
                        }
                        else if (p.DayType == DayType.假日)
                        {
                            r.CreateCell(12).SetCellValue(p.WorkTime + p.OverTime);
                        }
                        r.CreateCell(13).SetCellValue(p.CheckRecord);
                    }

                });

            });
        }

        /// <summary>
        /// 生成考勤总表
        /// </summary>
        /// <param name="wb"></param>
        /// <param name="ecm"></param>
        private static void BuildMonthSheets(XSSFWorkbook wb, List<EmpCheckMonth> ecm)
        {
            var ms = wb.CreateSheet("考勤表");
            //生成表头
            var rc = ms.CreateRow(0);
            List<string> ClName = new List<string>() { "序号", "部门", "姓名", "卡号", "总出勤", "平日上班", "平日加班", "休息日加班", "法定加班", "法定假天数", "年休假天数", "第一天上班", "出勤天数", "第一周", "第二周", "第三周", "第四周", "第五周", "第六周" };
            int ic = 0;
            ClName.ForEach(p =>
            {
                rc.CreateCell(ic++).SetCellValue(p);
            });

            int rid = 1;
            var cellStyle = wb.CreateCellStyle();
            var format = wb.CreateDataFormat();
            cellStyle.DataFormat = format.GetFormat("yyyy-m-d");
            ecm.ForEach(p =>
            {
                var r = ms.CreateRow(rid++);
                r.CreateCell(0).SetCellValue(rid - 1);
                r.CreateCell(1).SetCellValue(p.DeptName);
                r.CreateCell(2).SetCellValue(p.EmpName);
                r.CreateCell(3).SetCellValue(p.EmpId);
                r.CreateCell(4).SetCellValue(p.TotalTime);//总出勤
                r.CreateCell(5).SetCellValue(p.WorkTime);//平日上班
                r.CreateCell(6).SetCellValue(p.OverTime);//平日加班
                r.CreateCell(7).SetCellValue(p.RestdayTime);// 休息日加班、
                r.CreateCell(8).SetCellValue(p.HollydayTime);// 休息日加班
                r.CreateCell(9).SetCellValue(p.HollyDayNum);// 法定假天数
                r.CreateCell(10).SetCellValue(p.AnnualHolidays);// 年休假天数
                r.CreateCell(11).SetCellValue(p.FirstCheckDate);// 第一天上班
                r.Cells[11].CellStyle = cellStyle;
                r.CreateCell(12).SetCellValue(p.CheckNum);// 出勤天数
                int wid = 13;

                var bigweek = p.BigWeekHour;
                ///周工时
                if (p.EmpWeeks != null && p.EmpWeeks.Count > 0)
                {
                    p.EmpWeeks.ForEach(w =>
                            {
                                r.CreateCell(wid++).SetCellValue(w.TotalTime);
                            });
                }

            });

        }



    }

}

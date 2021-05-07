using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckDb;
using EntityFramework.Utilities;
using 考勤调整.Util;
namespace 考勤调整
{

    public delegate DayType GetDayTypeDelgate(DateTime d);
    public delegate string GetDeptNameDelgate(short id);
    public class EmpCheckMonth
    {
        public AttControlClass AttControl { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DeptName { get; set; }
        public GetDayTypeDelgate GetDayType { get; set; }
        public List<Shift> Shifts { get; set; }
        public GetDeptNameDelgate GetDeptName { get; set; }
        /// <summary>
        /// 出勤天数
        /// </summary>
        public int CheckNum
        {
            get
            {
                return GetEmpChecks.Count(p => p.TotalTime > 0);

            }
        }

        public List<EmpCheckDay> GetEmpChecks
        {
            get
            {

                return EmpChecks.Where(p => p.CheckDate <= EndDate).ToList();
            }
        }
        /// <summary>
        /// 日考勤信息
        /// </summary>
        public List<EmpCheckDay> EmpChecks { get; set; } = new List<EmpCheckDay>();
        /// <summary>
        /// 周考勤信息
        /// </summary>
        public List<EmpCheckWeek> EmpWeeks { get; set; }
        /// <summary>
        ///月打卡信息表
        /// </summary>
        public List<CHECKINOUT> Checks { get; set; } = new List<CHECKINOUT>();
        /// <summary>
        /// 员工信息表
        /// </summary>
        public USERINFO Emp { get; set; }

        public EmpNoteInfo EmpNote { get; set; }

        /// <summary>
        /// 第一次出勤时间
        /// </summary>
        public DateTime FirstCheckDate
        {
            get
            {
                return Checks.Min(p => p.CHECKTIME).Date;
            }
        }
        /// <summary>
        /// 最后一次出勤时间
        /// </summary>
        public DateTime LastCheckDate
        {
            get
            {
                return Checks.Max(p => p.CHECKTIME).Date;
            }
        }

        public EmpCheckMonth(USERINFO emp, AttControlClass attControl, GetDeptNameDelgate GetDeptName)
        {
            Emp = emp;
            DeptName = GetDeptName((short)emp.DEFAULTDEPTID);
            AttControl = attControl;
            GetDayType = AttControl.GetDayType;
            EmpNote = AttControl.GetEmpNoteInfoByByte(emp.Notes);

            if (EmpNote == null)
            {
                EmpNote = new EmpNoteInfo();
                EmpNote.EmpPyName = PinyinHelper.PinyinString(emp.Name);
                EmpNote.IsHaveNote = true;
                AttControl.UpDateEmpNoteInfo(emp.USERID, EmpNote);
            }

        }

        /// <summary>
        /// 设置班次
        /// </summary>
        public void SetShifts()
        {
            //设置员工默认班次
            if (EmpNote.Shifts.Count > 0)
            {
                if (EmpNote.AutoShift)
                {
                    AutoChangeShift(EmpNote.Shifts);
                }
                else
                {
                    ChangeShift(EmpNote.Shifts[0]);
                }
            }


            //设置当天已更改的默认班次
            EmpChecks.ForEach(p =>
            {
                if (p.Checks.Count > 0)
                {
                    var mc = p.Checks.OrderBy(o => o.CHECKTIME).First();
                    if (mc.Memoinfo != null)
                    {
                        var cshift = Shifts.SingleOrDefault(s => s.ID == mc.Memoinfo);
                        if (cshift != null) ChangeShift(p, cshift);
                    }
                }

            });


            EmpChecks.ForEach(p =>
            {
                if (p.Checks.Count > 0)
                {
                    if (p.AfterCheckDay != null)
                    {
                        for (int i = p.Checks.Count - 1; i >= 0; i--)
                        {
                            if (p.AfterCheckDay.Checks.Contains(p.Checks[i]))
                            {
                                if (p.IsRestDay) p.Checks.Remove(p.Checks[i]);
                                else p.AfterCheckDay.Checks.Remove(p.Checks[i]);
                            }
                        }
                    }
                }
            });

        }
        public string EmpName
        {
            get
            {
                return Emp.Name.Split('\0')[0];
            }
        }
        public int EmpId
        {
            get
            {
                return Emp.USERID;
            }
        }
        /// <summary>
        /// 设置时间范围
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        public void SetDate(DateTime beginDate, DateTime endDate)
        {
            BeginDate = beginDate;
            EndDate = endDate;
            for (DateTime d = beginDate; d <= endDate.AddDays(1); d = d.AddDays(1))
            {
                var emp = new EmpCheckDay(Emp, d)
                {
                    DeptName = DeptName,
                    DayType = GetDayType(d),
                };
                if (Shifts.Count > 0) emp.EmpShift = Shifts[0];

                EmpChecks.Add(emp);
            }
            //连接上下天
            EmpChecks.ForEach(p =>
            {
                p.PreCheckDay = EmpChecks.SingleOrDefault(d => d.CheckDate == p.CheckDate.AddDays(-1));
                p.AfterCheckDay = EmpChecks.SingleOrDefault(d => d.CheckDate == p.CheckDate.AddDays(1));
            });

        }
        /// <summary>
        /// 年休假天数
        /// </summary>
        public int AnnualHolidays { get; set; } = 0;
        public int HollyDayNum
        {
            get
            {
                return EmpChecks.Where(p => p.DayType == DayType.假日 && p.CheckDate <= EndDate).Count();
            }
        }
        /// <summary>
        /// 更改班次
        /// </summary>
        /// <param name="ecd"></param>
        /// <param name="newShift"></param>
        public void ChangeShift(EmpCheckDay ecd, Shift ns)
        {
            DateTime bd, ed;
            var newShift = ns;
            if (ecd.EmpShift.BeginTime != newShift.BeginTime || ecd.EmpShift.EndTime != newShift.EndTime)
            {
                if (ecd.DayType == DayType.假日) newShift = new Shift();

                if (ecd.AfterCheckDay != null && ecd.AfterCheckDay.DayType == DayType.假日)
                {
                    bd = ecd.CheckDate.Add(newShift.BeginTime);
                    ed = ecd.CheckDate.Add(new TimeSpan(23, 59, 59));
                }
                else
                {
                    bd = ecd.CheckDate.Add(newShift.BeginTime);
                    ed = ecd.CheckDate.Add(newShift.EndTime);
                }

                ecd.RawChecks = Checks.Where(p => p.CHECKTIME >= bd && p.CHECKTIME <= ed).ToList();
                ecd.Checks = ecd.RawChecks;
                RemoveDuplicate(ecd);
            }
            ecd.EmpShift = newShift;
        }

        /// <summary>
        /// 去重
        /// </summary>
        /// <param name="ecd"></param>
        public void RemoveDuplicate(EmpCheckDay ecd)
        {
            if (ecd.PreCheckDay != null && ecd.PreCheckDay.RawChecks.Count > 0)
            {
                ecd.PreCheckDay.RawChecks.ForEach(p =>
                {
                    if (ecd.RawChecks.Contains(p))
                    {
                        ecd.RawChecks.Remove(p);
                    }
                });
            }

        }
        /// <summary>
        /// 更改员工全部的班次
        /// </summary>
        /// <param name="newShift"></param>
        public void ChangeShift(Shift newShift)
        {
            EmpChecks.ForEach(p =>
            {
                ChangeShift(p, newShift);
            });
            ///更新员工默认班次
            EmpNote.Shifts.Clear();
            EmpNote.Shifts.Add(newShift);
            EmpNote.AutoShift = false;
        }

        /// <summary>
        /// 保存员工班次至数据库
        /// </summary>
        public void SaveEmpShift()
        {
            AttControl.UpDateEmpNoteInfo(Emp.USERID, EmpNote);
        }


        public void AutoChangeShift(List<Shift> shifts)
        {

            EmpChecks.ForEach(p =>
            {

                Shift preShift = p.EmpShift;
                ChangeShift(p, shifts[0]);
                var lm = p.ShiftPoint;
                shifts.ForEach(s =>
                {
                    if (p.FirstAmend != null)
                    {
                        var oldShift = p.EmpShift;
                        ChangeShift(p, s);
                        if (p.ShiftPoint < lm) ChangeShift(p, oldShift);
                        else lm = p.ShiftPoint;
                        preShift = p.EmpShift;
                    }
                    else ChangeShift(p, preShift);

                });
            });

            ///修正中间班次不一样问题
            var elist = EmpChecks.OrderBy(p => p.CheckDate).ToList();

            for (int i = 0; i < elist.Count; i++)
            {

                if (i == 0 && elist[i + 1].EmpShift.ShiftName == elist[i + 2].EmpShift.ShiftName && elist[i + 1].EmpShift.ShiftName != elist[i].EmpShift.ShiftName)
                {
                    ChangeShift(elist[i], elist[i + 1].EmpShift);
                }
                else if (i > 0 && i < elist.Count - 1 && elist[i - 1].EmpShift.ShiftName == elist[i + 1].EmpShift.ShiftName && elist[i + 1].EmpShift.ShiftName != elist[i].EmpShift.ShiftName)
                {
                    ChangeShift(elist[i], elist[i + 1].EmpShift);
                }
                else if (i == elist.Count - 1 && elist[i - 1].EmpShift.ShiftName == elist[i - 2].EmpShift.ShiftName && elist[i - 1].EmpShift.ShiftName != elist[i].EmpShift.ShiftName)
                {
                    ChangeShift(elist[i], elist[i - 1].EmpShift);
                }

            }

            EmpNote.Shifts.Clear();
            EmpNote.Shifts.AddRange(shifts);
            EmpNote.AutoShift = true;
        }

        public void SetOneWeekIsSameShift()
        {
            BuildWeekCheck();
            EmpWeeks.ForEach(p =>
            {
                if (p.Checks.Count > 0)
                {
                    var group = p.Checks.GroupBy(c => c.ShiftName).Select(c => new { name = c.Key, clist = c.ToList(), count = c.ToList().Count() }).OrderByDescending(t => t.count).ToList();
                    var shift = group[0].clist[0].EmpShift;
                    p.Checks.ForEach(c =>
                    {
                        ChangeShift(c, shift);
                    });

                }
            });
        }
        public void SetWorkHourTo8(bool v)
        {
            EmpChecks.ForEach(p =>
            {
                p.WorkHourIs8 = v;
            });
        }

        public void SetJSTimeByCheck(bool v)
        {
            EmpChecks.ForEach(p =>
            {
                p.JSTimeByCheck = v;
            });
        }
        public void SetIgnore15MinuteCheck(bool v)
        {
            EmpChecks.ForEach(p =>
            {
                p.Ignore15MinuteCheck = v;
            });
        }

        public void SetShowNewCheckData(bool v)
        {
            EmpChecks.ForEach(p =>
            {
                p.ShowNewCheckData = v;
            });
        }
        /// <summary>
        /// 添加考勤记录
        /// </summary>
        /// <param name="obj"></param>
        public void Add(CHECKINOUT obj)
        {
            Checks.Add(obj);
            var emp = EmpChecks.Where(p => p.CheckDate == obj.CHECKTIME.Date).SingleOrDefault();
            if (emp != null) emp.Add(obj);

        }

        /// <summary>
        /// 假日加班工时
        /// </summary>
        public double HollydayTime
        {
            get
            {
                return Math.Round(EmpChecks.Where(p => p.DayType == DayType.假日 && p.CheckDate <= EndDate).Sum(p => p.TotalTime), 1);
            }
        }

        /// <summary>
        /// 休息日加班工时
        /// </summary>
        public double RestdayTime
        {
            get
            {
                return Math.Round(EmpChecks.Where(p => p.DayType == DayType.休息日 && p.CheckDate <= EndDate).Sum(p => p.TotalTime), 1);

            }
        }

        /// <summary>
        /// 平日正常上班时间
        /// </summary>
        public double WorkTime
        {
            get
            {
                return Math.Round(EmpChecks.Where(p => p.DayType == DayType.平日 && p.CheckDate <= EndDate).Sum(p => p.WorkTime), 1) + AnnualHolidays * 8;
            }
        }
        /// <summary>
        /// 平日加班时间
        /// </summary>
        public double OverTime
        {
            get
            {
                return Math.Round(EmpChecks.Where(p => p.DayType == DayType.平日 && p.CheckDate <= EndDate).Sum(p => p.OverTime), 1);
            }
        }
        /// <summary>
        /// 平日出勤时间
        /// </summary>
        public double TotalTime
        {
            get
            {
                return Math.Round(EmpChecks.Where(p => p.CheckDate <= EndDate).Sum(p => p.TotalTime), 1);
            }
        }

        /// <summary>
        /// 最大周工时
        /// </summary>
        public double BigWeekHour
        {
            get
            {
                if (EmpWeeks == null)
                {

                    BuildWeekCheck();
                }
                if (EmpWeeks.Count == 0) return 0;
                return Math.Round(EmpWeeks.Max(p => p.TotalTime), 1);
            }
        }
        public void BuildWeekCheck()
        {
            if (EmpWeeks == null)
            {
                EmpWeeks = new List<EmpCheckWeek>();

                EmpChecks.ForEach(p =>
                {
                    var wn = p.CheckDate.Year + GetWeekOfYear(p.CheckDate).ToString();//取得周数

                    var week = EmpWeeks.SingleOrDefault(w => w.WeekNum == wn);
                    if (week == null)
                    {
                        week = new EmpCheckWeek(Emp, wn);
                        EmpWeeks.Add(week);
                    }
                    week.Add(p);
                });

            }

        }

        private int GetWeekOfYear(DateTime dt)
        {
            GregorianCalendar gc = new GregorianCalendar();
            return gc.GetWeekOfYear(dt, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
        /// <summary>
        /// 写入数据库
        /// </summary>
        public void WriteToDate(attContent dc, bool IsAllWriteMode)
        {


            EmpChecks.ForEach(p =>
            {
                if (p.NewChecks.Count > 0)
                {
                    dc.CHECKINOUT.RemoveRange(p.Checks);
                    if (p.NewChecks.Count > 0) dc.CHECKINOUT.AddRange(p.NewChecks);
                }
            });
            dc.SaveChanges();
        }

        /// <summary>
        /// 写入数据库
        /// </summary>
        public void FastWriteToDate(attContent dc)
        {

            List<CHECKINOUT> newlist = new List<CHECKINOUT>();
            ///删除考勤 
            if (Checks.Count > 0)
            {

                var df1 = GetEmpChecks.Where(p => p.FirstCheck != null).OrderBy(p => p.CheckDate).FirstOrDefault();
                var dl2 = GetEmpChecks.Where(p => p.FirstCheck != null).OrderBy(p => p.CheckDate).LastOrDefault();
                if (df1 != null & dl2 != null)
                {
                    var d1 = df1.FirstCheck.Value;
                    if (df1.PreCheckDay != null && df1.PreCheckDay.ShiftName != df1.ShiftName)
                    {
                        d1 = (df1.PreCheckDay.CheckDate + df1.PreCheckDay.EmpShift.EndTime).AddMinutes(10);
                    }
                    var d2 = dl2.LastCheck.Value;
                    var cd1 = Checks.OrderBy(p => p.CHECKTIME).First();
                    if (d1 != cd1.CHECKTIME)
                    {
                        if (cd1.Memoinfo == null) d1 = cd1.CHECKTIME;
                    };
                    string delstr = string.Format("delete checkinout where userid={0} and checktime>='{1}' and checktime<='{2}';", Emp.USERID, d1.AddMinutes(-1), d2.AddMinutes(1));
                    if (delstr != "") dc.Database.ExecuteSqlCommand(delstr);

                }


            }

            //添加考勤
            EmpChecks.ForEach(p =>
            {
                if (p.NewChecks.Count > 0)
                {
                    if (p.NewChecks.Count > 0) newlist.AddRange(p.NewChecks);
                }
            });
            //去重
            newlist.ForEach(p =>
            {
                if (newlist.Count(n => n.CHECKTIME == p.CHECKTIME) > 0) p.CHECKTIME.AddSeconds(3);
            });
            var l = new HashSet<CHECKINOUT>(newlist);
            EFBatchOperation.For(dc, dc.CHECKINOUT).InsertAll(l);


        }
    }
}

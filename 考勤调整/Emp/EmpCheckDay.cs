using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckDb;

namespace 考勤调整
{
    public enum DayType
    {
        平日 = 0,
        休息日 = 1,
        假日 = 2
    }

    public class EmpCheckDay
    {
        public USERINFO Emp { get; set; }
        public DayType DayType { get; set; }
        public DateTime CheckDate { get; set; }
        /// <summary>
        /// 一次打卡计4小时
        /// </summary>
        public bool OnlyOneCheckReturn4Hour { get; set; } = true;
        /// <summary>
        /// 忽略15分钟内的打卡加间
        /// </summary>
        public bool Ignore15MinuteCheck { get; set; } = true;
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmpName
        {
            get
            {
                return Emp.Name.Split('\0')[0];
            }
        }
        /// <summary>
        /// 部门名
        /// </summary>
        public string DeptName { get; set; }

       
        /// <summary>
        /// 班次
        /// </summary>
        public Shift EmpShift { get; set; } = new Shift();
        /// <summary>
        /// 原始打卡记录
        /// </summary>
        public List<CHECKINOUT> RawChecks { get; set; } = new List<CHECKINOUT>();


        public List<CHECKINOUT> Checks { get; set; }
        /// <summary>
        /// 调整后的待写入的打卡记录
        /// </summary>
        public List<CHECKINOUT> NewChecks { get; set; } = new List<CHECKINOUT>();

        public bool IsRestDay
        {
            get
            {
                return (int)CheckDate.DayOfWeek == EmpShift.RestDayInt;
            }

        }

        public EmpCheckDay(USERINFO emp, CHECKINOUT obj)
        {
            Emp = emp;
            CheckDate = obj.CHECKTIME.Date;
            RawChecks.Add(obj);
            Checks = RawChecks;
        }

        public EmpCheckDay(USERINFO emp, DateTime checkDate)
        {
            Emp = emp;
            CheckDate = checkDate.Date;
            Checks = RawChecks;

        }


        /// <summary>
        /// 当天所有打卡记录
        /// </summary>
        public string CheckRecord
        {
            get
            {
                string c = "";
                RawChecks.OrderBy(p => p.CHECKTIME).ToList().ForEach(p =>
                  {
                      var span = p.CHECKTIME - CheckDate;
                      c = c == "" ? span.ToString("t") : c + "  " + span.ToString("t");
                  });
                return c;
            }
        }
        /// <summary>
        /// 显示调整后工时数据
        /// </summary>
        public bool ShowNewCheckData
        {
            set
            {
                Checks = value ? NewChecks : RawChecks;
            }
        }

        /// <summary>
        /// 调整后的打卡记录显示
        /// </summary>
        public string NewCheckRecord
        {
            get
            {
                string c = "";
                NewChecks.OrderBy(p => p.CHECKTIME).ToList().ForEach(p =>
                {
                    var span = p.CHECKTIME - CheckDate;
                    c = c == "" ? span.ToString() : c + "  " + span.ToString();
                });
                return c;
            }
        }
        /// <summary>
        /// 班次名
        /// </summary>
        public string ShiftName
        {
            get
            {
                return EmpShift.ShiftName;
            }
        }

        /// <summary>
        /// 首次打卡
        /// </summary>
        public DateTime? FirstCheck
        {
            get
            {
                if (Checks.Count == 0) return null;
                return Checks.Min(p => p.CHECKTIME);
            }
        }
        /// <summary>
        /// 首次打卡
        /// </summary>
        public TimeSpan FTS { get; set; }
        /// <summary>
        /// 末次打卡
        /// </summary>
        public TimeSpan LTS { get; set; }


        public void BuildTS()
        {
            if (FirstCheck != null)
            {
                FTS = FirstCheck.Value - CheckDate;
                LTS = LastCheck.Value - CheckDate;
            }

        }
        /// <summary>
        /// 首次打卡修正
        /// </summary>
        public DateTime? FirstAmend
        {

            get
            {
                if (Checks.Count == 0) return null;
                var first = (DateTime)FirstCheck;
                var fd = first.TimeOfDay;
                if (Ignore15MinuteCheck)
                {
                    if (fd.Minutes > 45) fd = new TimeSpan(fd.Hours + 1, 0, 0);
                    //if ((EmpShift.AmCheckIn - fd).TotalMinutes <= 15 && (EmpShift.AmCheckIn - fd).TotalMinutes > -10) fd = EmpShift.AmCheckIn;
                    //else if ((EmpShift.PmCheckIn - fd).TotalMinutes <= 15 && (EmpShift.PmCheckIn - fd).TotalMinutes > -10) fd = EmpShift.PmCheckIn;
                    //else if ((EmpShift.OTCheckIn - fd).TotalMinutes <= 15 && (EmpShift.OTCheckIn - fd).TotalMinutes > -10) fd = EmpShift.OTCheckIn;
                }
                return first.Date + fd;
            }
        }
        /// <summary>
        /// 末次打卡
        /// </summary>
        public DateTime? LastCheck
        {
            get
            {
                if (Checks.Count == 0) return null;
                else return Checks.Max(p => p.CHECKTIME);
            }
        }
        /// <summary>
        /// 末次打卡修正
        /// </summary>
        public DateTime? LastAmend
        {
            get
            {
                if (Checks.Count == 0) return null;
                var last = (DateTime)LastCheck;
                var ld = last.TimeOfDay;
                if (Ignore15MinuteCheck)
                {
                    if (ld.Minutes < 15) ld = new TimeSpan(ld.Hours, 0, 0);
                    //if ((ld - EmpShift.OTCheckOut).TotalMinutes <= 15 && (ld - EmpShift.OTCheckOut).TotalMinutes > -10) ld = EmpShift.OTCheckOut;
                    //else if ((ld - EmpShift.PmCheckOut).TotalMinutes <= 15 && (ld - EmpShift.PmCheckOut).TotalMinutes > -10) ld = EmpShift.PmCheckOut;
                    //else if ((ld - EmpShift.AmcheckOut).TotalMinutes <= 15 && (ld - EmpShift.AmcheckOut).TotalMinutes > -10) ld = EmpShift.AmcheckOut;
                }
                return last.Date + ld;
            }
        }
        /// <summary>
        /// 添加考情
        /// </summary>
        /// <param name="obj"></param>
        public void Add(CHECKINOUT obj)
        {
            RawChecks.Add(obj);

        }
        /// <summary>
        /// 正常上班时间
        /// </summary>
        public double WorkTime
        {
            get
            {
                if (Checks.Count == 0) return 0;
                double re = TotalTime;
                if (TotalTime > 8) re = 8;
                return Math.Round(re, 1, MidpointRounding.AwayFromZero);
            }
        }
        /// <summary>
        /// 加班时间
        /// </summary>
        public double OverTime
        {
            get
            {
                if (Checks.Count == 0) return 0;
                double re = 0;
                if (TotalTime > 8) re = TotalTime - 8;
                return Math.Round(re, 1, MidpointRounding.AwayFromZero);
            }
        }
        /// <summary>
        ///总出勤时间
        /// </summary>
        public double TotalTime
        {
            get
            {
                if (Checks.Count == 0) return 0;
                double re = AllTime;
                if (AllTime >= 10) re = AllTime - 2;
                else if (AllTime >= 5) re = AllTime - 1;
                return Math.Round(re, 1, MidpointRounding.AwayFromZero);
            }
        }
        /// <summary>
        /// 首尾打卡小时数
        /// </summary>
        public double AllTime
        {
            get
            {
                if (Checks.Count == 0) return 0;
                if (Checks.Count >= 1 && (LastCheck.Value - FirstCheck.Value).TotalMinutes < 15 && OnlyOneCheckReturn4Hour) return 4;
                var ld = LastAmend.Value - CheckDate;
                var fd = FirstAmend.Value - CheckDate;
                var re = Math.Round((ld - fd).TotalHours, 1, MidpointRounding.AwayFromZero);
                return re;

            }
        }


    }
}

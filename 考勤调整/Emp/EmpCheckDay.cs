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

    /// <summary>
    /// 表示单个员工单日的考勤数据和相关计算逻辑。
    /// 包含原始打卡、调整后打卡、班次映射以及工时/加班的计算方法。
    /// </summary>
    public class EmpCheckDay
    {

        /// <summary>
        /// 前一天的日考勤对象（用于跨天打卡或连续班次判断）
        /// </summary>
        public EmpCheckDay PreCheckDay { get; set; }

        /// <summary>
        /// 后一天的日考勤对象（用于跨天打卡或重复打卡清理）
        /// </summary>
        public EmpCheckDay AfterCheckDay { get; set; }

        /// <summary>
        /// 上午上班打卡记录（按班次映射）
        /// </summary>
        public CHECKINOUT AmIn { get; set; }

        /// <summary>
        /// 上午下班打卡记录（按班次映射）
        /// </summary>
        public CHECKINOUT AmOut { get; set; }

        /// <summary>
        /// 下午上班打卡记录（按班次映射）
        /// </summary>
        public CHECKINOUT PmIn { get; set; }

        /// <summary>
        /// 下午下班打卡记录（按班次映射）
        /// </summary>
        public CHECKINOUT PmOut { get; set; }

        /// <summary>
        /// 加班上班打卡记录（按班次映射）
        /// </summary>
        public CHECKINOUT OtIn { get; set; }

        /// <summary>
        /// 加班下班打卡记录（按班次映射）
        /// </summary>
        public CHECKINOUT OtOut { get; set; }

        /// <summary>
        /// 员工信息引用（USERINFO）
        /// </summary>
        public USERINFO Emp { get; set; }

        /// <summary>
        /// 指示该日类型（平日/休息日/假日）
        /// </summary>
        public DayType DayType { get; set; }

        /// <summary>
        /// 当前日考勤对应的日期（仅包含日期部分）
        /// </summary>
        public DateTime CheckDate { get; set; }
        /// <summary>
        /// 班次
        /// </summary>
        public Shift EmpShift { get; set; } = new Shift();

        private CHECKINOUT[] Ciol;
        private bool _JSTimeByCheck { get; set; }
        /// <summary>
        /// 一次打卡计4小时
        /// </summary>
        public bool OnlyOneCheckReturn4Hour { get; set; } = true;
        /// <summary>
        /// 忽略15分钟内的打卡加间
        /// </summary>
        public bool Ignore15MinuteCheck { get; set; } = true;

        public bool JSTimeByCheck
        {
            set
            {
                _JSTimeByCheck = value;
                if (value && Ciol == null) BuildCheckList();

            }
        }
        /// <summary>
        /// 根据班次时间段将当天的多条打卡记录映射到对应的检查点数组（Ciol），
        /// 以便后续按班次的上下班口径计算工作时长和加班。
        /// </summary>
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
        /// 生成删除当前日打卡记录的 SQL 语句片段，用于批量删除操作。
        /// 返回空字符串表示没有可删除的记录。
        /// </summary>
        /// <returns>可用于执行的 DELETE SQL 字符串</returns>
        public string GetDeleteSqlStr()
        {
            Checks = RawChecks;
            if (RawChecks.Count == 0) return "";
            if (RawChecks.Count == 1) return string.Format("delete checkinout where userid={0} and checktime='{1}';", Emp.USERID, FirstCheck);
            return string.Format("delete checkinout where userid={0} and checktime>='{1}' and checktime<='{2}';", Emp.USERID, FirstCheck.Value.AddMinutes(-1), LastCheck.Value.AddMinutes(1));
        }

        /// <summary>
        /// 班次符合度评分
        /// </summary>
        public int ShiftPoint
        {
            get
            {
                int point = 0;
                if (FirstCheck != null)
                {
                    var ft = FirstCheck.Value - CheckDate;
                    var lt = LastCheck.Value - CheckDate;
                    if ((ft - EmpShift.AmCheckIn).TotalSeconds <= 0) point += 2;//不迟到1分
                    if ((lt - EmpShift.PmCheckOut).TotalSeconds >= 0) point += 2; //未早退

                    if (Math.Abs((ft - EmpShift.AmCheckIn).TotalMinutes) <= 10) point += 4;
                    else if (Math.Abs((ft - EmpShift.AmCheckIn).TotalMinutes) < 30) point += 2;
                    else if (Math.Abs((ft - EmpShift.AmCheckIn).TotalMinutes) > 120) point += -3;

                    if (Math.Abs((lt - EmpShift.OTCheckOut).TotalMinutes) < 60) point += 1;
                    if ((lt - EmpShift.OTCheckOut).TotalMinutes > 180) point -= 2;

                    if (PreCheckDay != null && PreCheckDay.EmpShift.ShiftName == EmpShift.ShiftName) point += 1;

                }
                else point += 3;

                return point;
            }
        }
        /// <summary>
        /// 当天从设备读取到的原始打卡列表（未经过调整）。
        /// </summary>
        public List<CHECKINOUT> RawChecks { get; set; } = new List<CHECKINOUT>();

        /// <summary>
        /// 当前正在用于计算的打卡集合（可以是 RawChecks 或 NewChecks，取决于 ShowNewCheckData 标志）。
        /// </summary>
        public List<CHECKINOUT> Checks { get; set; }

        /// <summary>
        /// 调整后的打卡记录集合，准备写回数据库时使用。
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
        /// 构造函数：从单条打卡记录创建日考勤对象。
        /// </summary>
        /// <param name="emp">员工信息</param>
        /// <param name="obj">单条打卡记录</param>


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
        /// 根据 FirstCheck 和 LastCheck 计算出当天的首末打卡相对时间（FTS/LTS）。
        /// </summary>
        /// <summary>
        /// 首次打卡修正
        /// </summary>
        public DateTime? FirstAmend
        {

            get
            {
                if (Checks.Count == 0) return null;
                var first = (DateTime)FirstCheck;
                var fd = first - CheckDate;
                if (Ignore15MinuteCheck)
                {
                    if ((EmpShift.AmCheckIn - fd).TotalMinutes <= 15 && (EmpShift.AmCheckIn - fd).TotalMinutes > -5) fd = EmpShift.AmCheckIn;
                    else if ((EmpShift.PmCheckIn - fd).TotalMinutes <= 15 && (EmpShift.PmCheckIn - fd).TotalMinutes > -5) fd = EmpShift.PmCheckIn;
                    else if ((EmpShift.OTCheckIn - fd).TotalMinutes <= 15 && (EmpShift.OTCheckIn - fd).TotalMinutes > -5) fd = EmpShift.OTCheckIn;
                }
                return CheckDate + fd;
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
                var ld = last - CheckDate;
                if (Ignore15MinuteCheck)
                {
                    if ((ld - EmpShift.OTCheckOut).TotalMinutes <= 15 && (ld - EmpShift.OTCheckOut).TotalMinutes > -5) ld = EmpShift.OTCheckOut;
                    else if ((ld - EmpShift.PmCheckOut).TotalMinutes <= 15 && (ld - EmpShift.PmCheckOut).TotalMinutes > -5) ld = EmpShift.PmCheckOut;
                    else if ((ld - EmpShift.AmcheckOut).TotalMinutes <= 15 && (ld - EmpShift.AmcheckOut).TotalMinutes > -5) ld = EmpShift.AmcheckOut;
                }
                return CheckDate + ld;
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
                var workhour = EmpShift.WorkHour;
                if (_workHourIs8) workhour = 8;
                if (_JSTimeByCheck)
                {
                    if (Ciol == null) BuildCheckList();

                    return 0;
                }
                else
                {
                    double re = TotalTime;
                    if (TotalTime > workhour) re = workhour;
                    return Math.Round(re, 1, MidpointRounding.AwayFromZero);
                }

            }
        }
        /// <summary>
        /// 按班次对号入座时间
        /// </summary>
        private void BuildCheckList()
        {
            if (Ciol == null)
            {

                Ciol = new CHECKINOUT[6];
                Checks.OrderBy(p => p.CHECKTIME).ToList().ForEach(p =>
                  {
                      var ts = p.CHECKTIME - CheckDate;
                      int id = EmpShift.GetCheckId(ts, 0);
                      if (Ciol[id] == null)
                      {
                          Ciol[id] = p;
                      }
                      else
                      {
                          var tmp = Ciol[id];
                          double sp = (p.CHECKTIME - Ciol[id].CHECKTIME).TotalMinutes;
                          if (id == 1 || id == 3 || id == 5)
                          {
                              Ciol[id] = p;
                              int id2 = EmpShift.GetCheckId(ts, 1);
                              if (Ciol[id2] == null && sp > 15) Ciol[id2] = tmp;
                          }
                      }
                  });
            }
        }
        /// <summary>
        /// 加班时间
        /// </summary>
        public double OverTime
        {
            get
            {
                var workhour = EmpShift.WorkHour;
                if (_workHourIs8) workhour = 8;
                if (Checks.Count == 0) return 0;
                double re = 0;
                if (TotalTime > workhour) re = TotalTime - workhour;
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


                //if (AllTime >= 10) re = AllTime - EmpShift.Rest1-EmpShift.Rest2;
                //else if (AllTime >= 5) re = AllTime - EmpShift.Rest1;
                TimeSpan f = FirstCheck.Value - CheckDate;
                TimeSpan l = LastCheck.Value - CheckDate;
                if (EmpShift.AmcheckOut >= f && EmpShift.PmCheckIn <= l) re -= EmpShift.Rest1;
                if (EmpShift.PmCheckOut >= f && EmpShift.OTCheckIn <= l) re -= EmpShift.Rest2;

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
        private bool _workHourIs8 = true;
        public bool WorkHourIs8
        {
            set
            {
                _workHourIs8 = value;
            }
        }
    }
}

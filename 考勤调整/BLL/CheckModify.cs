using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckDb;


namespace 考勤调整
{
    public class CheckModify
    {
        /// <summary>
        /// 随机数
        /// </summary>
        Random rand = new Random();
        public bool Am { get; set; }
        public bool Pm { get; set; }
        public bool Ot { get; set; }
        /// <summary>
        /// 上班前范围
        /// </summary>
        public int InF { get; set; } = 13;
        /// <summary>
        /// 上班后
        /// </summary>
        public int InB { get; set; } = 4;
        /// <summary>
        /// 下班前
        /// </summary>
        public int OutF { get; set; } = 4;
        /// <summary>
        /// 下班后
        /// </summary>
        public int OutB { get; set; } = 13;
        /// <summary>
        /// 七休一
        /// </summary>
        public bool Need7Rest1 { get; set; }
        /// <summary>
        /// 生成全部考勤
        /// </summary>
        public bool BuildAllCheck { get; set; }
        /// <summary>
        /// 随机忘打卡百分比，为0则不启用
        /// </summary>
        public int MissCheckPercent { get; set; }
        /// <summary>
        /// 打卡一次生成全天考勤
        /// </summary>
        public bool OneCheckBuildOneDay { get; set; } 

        /// <summary>
        /// 节假日不上班
        /// </summary>
        public bool IsHollyDayNotWork { get; set; }
        ///// <summary>
        ///// 忽略首尾15分钟内打卡
        ///// </summary>
        //public bool Ignore15MinuteCheck
        //{
        //    get
        //    {
        //        return _Ignore15MinuteCheck;
        //    }
        //    set
        //    {
        //        _Ignore15MinuteCheck = value;

        //    }
        //}
        /// <summary>
        /// 限制最大周工时
        /// </summary>
        public int BigWeekHour { get; set; } = 60;
        /// <summary>
        /// 当天无打卡也生成考勤
        /// </summary>
        public bool NoCheckAlwaysBuild { get; set; }


        public void BuildEmpCheck(List<EmpCheckMonth> empList)
        {
            if (empList.Count > 0)
            {
                empList.ForEach(emp =>
                          {
                              emp.EmpChecks.ForEach(d =>
                              {
                                  d.NewChecks.Clear();
                                  if (!(Need7Rest1 && d.IsRestDay))
                                  {
                                      d.BuildTS();
                                      NoCheckSet(d);
                                      OneCheckSet(d);
                                      BuildAllChecSet(d);
                                      BuildUserCheckInOut(d);
                                      RemoveMillsecond(d);
                                  }
                              });
                          });
            }


        }
        private void RemoveMillsecond(EmpCheckDay ed)
        {
            ed.NewChecks.ForEach(p =>
            {
                var ml = p.CHECKTIME.Millisecond;
                if (ml > 0)
                {
                    p.CHECKTIME = p.CHECKTIME.AddMilliseconds(-ml);
                }

            });
        }

        /// <summary>
        /// 生成全部考勤
        /// </summary>
        /// <param name="ed"></param>
        private void BuildAllChecSet(EmpCheckDay ed)
        {
            if (BuildAllCheck)
            {
                ed.FTS = ed.EmpShift.AmCheckIn;
                ed.LTS = ed.EmpShift.OTCheckOut;
            }

        }
        /// <summary>
        /// 未打卡处理
        /// </summary>
        /// <param name="ed"></param>
        private void NoCheckSet(EmpCheckDay ed)
        {
            if (ed.Checks.Count == 0 && NoCheckAlwaysBuild)
            {
                ed.FTS = ed.EmpShift.AmCheckIn;
                ed.LTS = ed.EmpShift.PmCheckOut;
            }
        }

        /// <summary>
        /// 一次打卡处理,首未打卡区域少于15分钟视为一次打卡
        /// </summary>
        /// <param name="ed"></param>
        private void OneCheckSet(EmpCheckDay ed)
        {

            if (ed.Checks.Count > 0 && (ed.LTS - ed.FTS).TotalMinutes < 15)
            {
                if (OneCheckBuildOneDay)
                {
                    //一次打卡生成全天
                    ed.FTS = ed.FTS < ed.EmpShift.AmCheckIn ? ed.FTS : ed.EmpShift.AmCheckIn;
                    ed.LTS = ed.LTS > ed.EmpShift.PmCheckOut ? ed.LTS : ed.EmpShift.PmCheckOut;
                }
                else
                {
                    //生成0.5天
                    if (ed.FTS <= ed.EmpShift.PmCheckIn)
                    {
                        ed.FTS = ed.FTS < ed.EmpShift.AmCheckIn ? ed.FTS : ed.EmpShift.AmCheckIn;
                        ed.LTS = ed.LTS > ed.EmpShift.AmcheckOut ? ed.LTS : ed.EmpShift.AmcheckOut;
                    }
                    else
                    {
                        ed.FTS = ed.FTS < ed.EmpShift.PmCheckIn ? ed.FTS : ed.EmpShift.PmCheckIn;
                        ed.LTS = ed.LTS > ed.EmpShift.PmCheckOut ? ed.LTS : ed.EmpShift.PmCheckOut;
                    }
                }
            }
        }



        /// <summary>
        /// 生成当天全部考勤
        /// </summary>
        /// <param name="ed"></param>
        private void BuildUserCheckInOut(EmpCheckDay ed)
        {
            if (IsHollyDayNotWork && ed.DayType == DayType.假日) return;
            
            if (ed.Checks.Count > 0 || NoCheckAlwaysBuild)
            {

                var shift = ed.EmpShift;
                //生成全部考勤
                if (Am)
                {
                    bool amIn = false;
                    //amIn
                    if (ed.FTS <= shift.AmCheckIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = GetInTime(ed.CheckDate, ed.FTS, ed.EmpShift.AmCheckIn),
                            Memoinfo=ed.EmpShift.ID
                        });
                        amIn = true;
                    }
                    else if (ed.FTS < shift.AmcheckOut)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = ed.CheckDate.AddSeconds(1) + ed.FTS,
                            Memoinfo = ed.EmpShift.ID
                        });
                        amIn = true;
                    }

                    //inOut
                    if (ed.LTS >= shift.AmcheckOut && amIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = GetOutTime(ed.CheckDate, ed.LTS, ed.EmpShift.AmcheckOut),
                            Memoinfo = ed.EmpShift.ID
                        });
                    }
                    else if (amIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = ed.CheckDate.AddSeconds(1) + ed.LTS,
                            Memoinfo = ed.EmpShift.ID

                        });
                    }
                }
                
                if (Pm)
                {
                    //pmIn
                    bool pmIn = false;
                    if (ed.FTS <= shift.PmCheckIn && ed.LTS >= shift.PmCheckIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = GetInTime(ed.CheckDate, ed.FTS, ed.EmpShift.PmCheckIn),
                            Memoinfo = ed.EmpShift.ID

                        });
                        pmIn = true;
                    }
                    else if (ed.FTS < shift.PmCheckOut && ed.FTS > shift.PmCheckIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = ed.CheckDate.AddSeconds(1) + ed.FTS,
                            Memoinfo = ed.EmpShift.ID

                        });
                        pmIn = true;

                    }

                    //pmOut
                    if (ed.LTS >= shift.PmCheckOut && pmIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = GetOutTime(ed.CheckDate, ed.LTS, ed.EmpShift.PmCheckOut),
                            Memoinfo = ed.EmpShift.ID

                        });
                    }
                    else if (ed.LTS >= shift.PmCheckIn && pmIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = ed.CheckDate.AddSeconds(1) + ed.LTS,
                            Memoinfo = ed.EmpShift.ID

                        });
                    }

                }

                if (Ot)
                {
                    //otIn
                    bool otIn = false;

                    if (ed.FTS <= shift.OTCheckIn && ed.LTS > shift.OTCheckIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = GetInTime(ed.CheckDate, ed.FTS, ed.EmpShift.OTCheckIn),
                            Memoinfo = ed.EmpShift.ID

                        });
                        otIn = true;
                    }
                    else if (ed.FTS < shift.OTCheckOut && ed.FTS > shift.OTCheckIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = ed.CheckDate.AddSeconds(1) + ed.FTS,
                            Memoinfo = ed.EmpShift.ID

                        });
                        otIn = true;

                    }

                    //otOut
                    if (ed.LTS >= shift.OTCheckOut && otIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = GetOutTime(ed.CheckDate, ed.LTS, ed.EmpShift.OTCheckOut),
                            Memoinfo = ed.EmpShift.ID

                        });
                    }
                    else if (ed.LTS > shift.OTCheckIn && otIn)
                    {
                        ed.NewChecks.Add(new CHECKINOUT
                        {
                            USERID = ed.Emp.USERID,
                            CHECKTIME = ed.CheckDate.AddSeconds(1) + ed.LTS,
                            Memoinfo = ed.EmpShift.ID

                        });
                    }
                }

                 
                
            }

        }

        private DateTime GetInTime(DateTime d, TimeSpan inTime, TimeSpan shift)
        {
            if ((shift - inTime).TotalMinutes < InF && inTime != shift) return d.Add(inTime).AddSeconds(1);
            int rn = rand.Next(1, InF + InB);
            var re = d.Add(shift).AddMinutes(rn - InF).AddSeconds(rand.Next(0, 59));
            return re;
        }

        private DateTime GetOutTime(DateTime d, TimeSpan outTime, TimeSpan shift)
        {
            if ((outTime - shift).TotalMinutes < OutB && outTime != shift) return d.Add(outTime).AddSeconds(1);
            int rn = rand.Next(1, OutF + OutB);
            var re = d.Add(shift).AddMinutes(rn - OutF).AddSeconds(rand.Next(0, 59));
            return re;
        }
        /// <summary>
        /// 取随机数
        /// </summary>
        /// <returns></returns>
        private int GetRand()
        {
            return rand.Next(1, 250) * 4;
        }
    }
}

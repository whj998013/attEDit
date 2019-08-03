using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckDb;
namespace 考勤调整
{
    public class CheckAutoDelete
    {
        private List<Shift> shifts;

        public EmpCheckMonth Ecm { get; set; }
        private attContent ac { get; set; }


        public CheckAutoDelete(attContent _ac, List<Shift> shifts)
        {
            ac = _ac;
            this.shifts = shifts;
        }

        /// <summary>
        /// 载入考勤
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        public void LoadCheck(string Name, DateTime BeginDate, DateTime EndDate)
        {
            var user = ac.USERINFO.FirstOrDefault(p => p.Name == Name&&p.DEFAULTDEPTID>=0);
            if (user != null)
            {
                var getday = new AttControlClass(ac);
                Ecm = new EmpCheckMonth(user, getday, new DeptOper(ac).GetDeptName);
                Ecm.Shifts = this.shifts;
                Ecm.SetDate(BeginDate, EndDate);
                EndDate = EndDate.AddDays(2);
                var clist = ac.CHECKINOUT.Where(p => p.USERID == user.USERID && p.CHECKTIME >= BeginDate && p.CHECKTIME < EndDate).ToList();
                clist.ForEach(p =>
                {
                    Ecm.Add(p);
                });

                Ecm.SetShifts();
            }
        }
        /// <summary>
        /// 删除指定小时
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double DeleteHour(double hourNum)
        {
            double delHournum = 0;
            ///删除加班
            if (Ecm.OverTime * 1.5 >= hourNum)
            {
                var olist = Ecm.EmpChecks.Where(p => p.OverTime > 0).OrderBy(f => Guid.NewGuid()).ToList();

                foreach (var p in olist)
                {
                    var yh = p.OverTime;
                    for (int i = p.Checks.Count - 1; i >= 0; i--)
                    {
                        if (p.Checks[i].CHECKTIME.TimeOfDay >= p.EmpShift.PmCheckOut.Add(new TimeSpan(0, 30, 0)))
                        {
                            ac.CHECKINOUT.Remove(p.Checks[i]);
                            p.Checks.Remove(p.Checks[i]);

                        }

                    }
                    delHournum += (yh - p.OverTime) * 1.5;
                    if (delHournum > hourNum) break;
                }
            }
            ///删除上班
            if (delHournum < hourNum)
            {
                var olist = Ecm.EmpChecks.OrderBy(f => Guid.NewGuid()).ToList();

                foreach (var p in olist)
                {
                    var yh = p.TotalTime;
                    for (int i = p.Checks.Count - 1; i >= 0; i--)
                    {
                        
                            ac.CHECKINOUT.Remove(p.Checks[i]);
                            p.Checks.Remove(p.Checks[i]);

                    }

                    delHournum +=(p.IsRestDay? (yh - p.TotalTime) *2: (yh - p.TotalTime));
                    if (delHournum > hourNum) break;
                }


            }

            ac.SaveChanges();
            return delHournum;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckDb;

namespace 考勤调整
{
    public class EmpCheckWeek
    {

        public USERINFO Emp { get; set; }

        public List<EmpCheckDay> Checks { get; set; } = new List<EmpCheckDay>();

        public int WeekNum { get; set; }

        public EmpCheckWeek(USERINFO emp, int weekNum)
        {
            Emp = emp;
            WeekNum = weekNum;
        }
        public void Add(EmpCheckDay ec)
        {
            Checks.Add(ec);
        }

        public double TotalTime
        {
            get
            {
                return Checks.Sum(p => p.TotalTime);
            }
        }

        public int UserId
        {
            get
            {
                return Emp.USERID;
            }
        }
    }
}

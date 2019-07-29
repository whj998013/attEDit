using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckDb;

namespace 考勤调整
{
    public class AttControlClass
    {

        public List<HOLIDAYS> holidays;

        public attContent Con { get; set; }

        public AttControlClass(attContent con)
        {
            holidays = con.HOLIDAYS.ToList();
            Con = con;
        }
        public DayType GetDayType(DateTime d)
        {
            d = d.Date;
            var daytype = DayType.平日;
            if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday) daytype = DayType.休息日;
            var obj = holidays.Where(p => p.STARTTIME == d).SingleOrDefault();
            if (obj != null)
            {
                if (obj.HOLIDAYNAME == "法定") daytype = DayType.假日;
                else if (obj.HOLIDAYNAME == "休息日") daytype = DayType.休息日;
            }
            return daytype;
        }
    }
}

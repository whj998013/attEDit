using CheckDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 考勤调整
{
    public class Shift
    {
        public Shift(string id, string v)
        {
            ID = id;
            var l = v.Split(',');
            ShiftName = l[0];
            AmCheckIn = TimeSpan.Parse(l[1]);
            AmcheckOut = TimeSpan.Parse(l[2]);
            PmCheckIn = TimeSpan.Parse(l[3]);
            PmCheckOut = TimeSpan.Parse(l[4]);
            OTCheckIn = TimeSpan.Parse(l[5]);
            OTCheckOut = TimeSpan.Parse(l[6]);
            BeginTime = TimeSpan.Parse(l[7]);
            EndTime = TimeSpan.Parse(l[8]);
            RestDayInt = int.Parse(l[9]);


        }
        public Shift()
        {
            SetShiftId();
        }

        public string ID { get; set; } = "";
        public string ShiftName { get; set; } = "默认班";
        public TimeSpan AmCheckIn { get; set; } = TimeSpan.Parse("08:00");
        public TimeSpan AmcheckOut { get; set; } = TimeSpan.Parse("11:30");
        public TimeSpan PmCheckIn { get; set; } = TimeSpan.Parse("12:30");
        public TimeSpan PmCheckOut { get; set; } = TimeSpan.Parse("17:00");
        public TimeSpan OTCheckIn { get; set; } = TimeSpan.Parse("18:00");
        public TimeSpan OTCheckOut { get; set; } = TimeSpan.Parse("20:00");
        public TimeSpan BeginTime { get; set; } = TimeSpan.Parse("00:00:00");
        public TimeSpan EndTime { get; set; } = TimeSpan.Parse("23:59:59");
        public double Rest1
        {
            get
            {
                return (PmCheckIn - AmcheckOut).TotalHours;
            }
        }

        public double Rest2
        {
            get
            {
                return (OTCheckIn - PmCheckOut).TotalHours;

            }
        }

        public double WorkHour
        {
            get
            {
                return ((AmcheckOut - AmCheckIn) + (PmCheckOut - PmCheckIn)).TotalHours;
            }
        }

        /// <summary>
        /// 是否跨日
        /// </summary>
        public bool AcrossDay { get; set; } = false;
        /// <summary>
        /// 休息日
        /// </summary>
        public string RestDay { get; set; } = "周日";

        public int GetCheckId(TimeSpan ts, int id)
        {

            Dictionary<int, double> tds = new Dictionary<int, double>();
            tds.Add(0, Math.Abs((AmCheckIn - ts).TotalSeconds));
            tds.Add(1, Math.Abs((AmcheckOut - ts).TotalSeconds));
            tds.Add(2, Math.Abs((PmCheckIn - ts).TotalSeconds));
            tds.Add(3, Math.Abs((PmCheckOut - ts).TotalSeconds));
            tds.Add(4, Math.Abs((OTCheckIn - ts).TotalSeconds));
            tds.Add(5, Math.Abs((OTCheckOut - ts).TotalSeconds));
            var tdslit = tds.OrderBy(p => p.Value).ToList();
            return tdslit[id].Key;
        }

        public int RestDayInt
        {
            get
            {
                if (RestDay == "周日") return 0;
                else if (RestDay == "周一") return 1;
                else if (RestDay == "周二") return 2;
                else if (RestDay == "周三") return 3;
                else if (RestDay == "周四") return 4;
                else if (RestDay == "周五") return 5;
                else if (RestDay == "周六") return 6;
                else return 0;
            }
            set
            {
                if (value == 0)
                {
                    RestDay = "周日";

                }
                else if (value == 1)
                {
                    RestDay = "周一";
                }
                else if (value == 2)
                {
                    RestDay = "周二";
                }
                else if (value == 3)
                {
                    RestDay = "周三";

                }
                else if (value == 4)
                {
                    RestDay = "周四";

                }
                else if (value == 5)
                {
                    RestDay = "周五";

                }
                else if (value == 6)
                {
                    RestDay = "周六";

                }
            }
        }

        private void SetShiftId()
        {
            ID = GenerateRandomCode(10);
        }

        private static string GenerateRandomCode(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return result.ToString();
        }
        public string ToShiftString()
        {
            int length = ShiftName.Length;
            if (length > 6) length = 6;
            string str = "";
            str += ShiftName;
            str += "," + AmCheckIn;
            str += "," + AmcheckOut;
            str += "," + PmCheckIn;
            str += "," + PmCheckOut;
            str += "," + OTCheckIn;
            str += "," + OTCheckOut;
            str += "," + BeginTime;
            str += "," + EndTime;
            str += "," + RestDayInt;
            return str;
        }


    }


}

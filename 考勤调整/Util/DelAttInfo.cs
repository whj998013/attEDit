using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考勤调整
{
    public class DelAttInfo
    {
        private double _money, _hour;
        public string Name { get; set; }

        public double LowGz { get; set; }
        public double Money
        {
            get
            {
                return _money;
            } 
            set
            {
                _money = value;
                _hour = Math.Round(value / (LowGz / 21.75 / 8), 2);
            }
        }
        public double Hours
        {
            get
            {
                return _hour;
            }
            set
            {
                _hour = value;
                _money = Math.Round(value * (LowGz / 21.75 / 8), 2);
            }
        }

        public double ReHours { get; set; }
    }
}

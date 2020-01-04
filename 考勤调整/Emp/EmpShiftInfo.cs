using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 考勤调整.Util;
namespace 考勤调整
{
    public class EmpNoteInfo
    {
        public EmpNoteInfo()
        {

        }
      
        public string ConName { get; set; }
        public bool IsHaveNote { get; set; } = false;
        public bool AutoShift { get; set; } = false;
        public string EmpPyName { get; set; }
        public List<Shift> Shifts { get; set; } = new List<Shift>();

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 考勤调整
{
  public  class Empb
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string DeptName { get; set; }
        public DateTime? HiredDay { get; set; }
        public bool IsSelect { get; set; }
        public int DeptId { get; set; }
    }
}

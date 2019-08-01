using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckDb;
namespace 考勤调整
{
  public  class CheckDelete
    {
        private attContent ac;

        public CheckDelete(attContent _ac)
        {
            ac = _ac;
        }

        public int DeleteCheck(DateTime beginDate,DateTime endDate)
        {
            
            var sqlstr = string.Format("delete  checkinout WHERE   (CHECKTIME >= '{0}') AND (CHECKTIME <= '{1}')", beginDate.ToString(), endDate.ToString());
            int count=ac.Database.ExecuteSqlCommand(sqlstr);
            return count;
        }

      
    }
}

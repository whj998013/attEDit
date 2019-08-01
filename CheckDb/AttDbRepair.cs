using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDb
{
    public class AttDbRepair
    {
        public void RepairDb(attContent ac)
        {
            string repairstr = string.Format("update userinfo set DEFAULTDEPTID=1 where DEFAULTDEPTID IS NULL");
            ac.Database.ExecuteSqlCommand(repairstr);
            string str2 = string.Format("alter table CHECKINOUT alter column WorkCode int");
            ac.Database.ExecuteSqlCommand(str2);
        }
    }
}

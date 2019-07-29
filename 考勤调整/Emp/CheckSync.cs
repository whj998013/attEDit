using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CheckDb;
namespace 考勤调整
{
    class CheckSync
    {
        private DateTime begindate;
        private DateTime enddate;

        attContent cdb;
        public CheckSync(attContent _cdb, DateTime _begindate, DateTime _enddate)
        {

            this.begindate = _begindate;
            this.enddate = _enddate;
            cdb = _cdb;
        }

        //private int execsql(string strsql)
        //{
        //    if (this.myconn.State == ConnectionState.Closed)
        //    {
        //        this.myconn.Open();
        //    }
        //    SqlCommand command = new SqlCommand(strsql, this.myconn);
        //    return command.ExecuteNonQuery();
        //}

        public void Sync(out int deNum, out int addNum)
        {
            string strsql = string.Format("delete checkinout where checktime>'{0}' and checktime<'{1}' ", this.begindate, this.enddate.AddDays(1.0));
            string str2 = string.Format("insert into checkinout select * from ciot where checktime>'{0}' and checktime<'{1}' ", this.begindate, this.enddate.AddDays(1.0));

            deNum = cdb.Database.ExecuteSqlCommand(strsql);
            addNum = cdb.Database.ExecuteSqlCommand(str2);
        }

        public int SyncCount()
        {

            string command = string.Format("select count(userid) from ciot where checktime>'{0}' and checktime<'{1}'", this.begindate, this.enddate.AddDays(1.0));
            var num = cdb.Database.SqlQuery<int>(command).ToList()[0];
            return num;
        }
    }
}

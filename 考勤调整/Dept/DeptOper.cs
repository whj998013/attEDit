using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckDb;
namespace 考勤调整
{

    public class DeptOper
    {
        attContent Sd { get; set; }
        public List<Dept> Depts = new List<Dept>();
        public DeptOper(attContent sd)
        {
            Sd = sd;
            sd.DEPARTMENTS.ToList().ForEach(p =>
            {
                Dept d = new Dept
                {
                    DeptId = p.DEPTID,
                    DeptName = p.DEPTNAME,
                    UpDptId = p.SUPDEPTID
                };
                Depts.Add(d);

            });
        }
        public string GetDeptName(short id)
        {
            var dept = Depts.FirstOrDefault(p => p.DeptId == id);
            return dept == null ? "" : dept.DeptName;
        }
    }
}

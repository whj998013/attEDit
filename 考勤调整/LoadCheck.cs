using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheckDb;
using 考勤调整.Util;

namespace 考勤调整
{
    public partial class LoadCheck : Form
    {
        List<Dept> Depts { get; set; }
        List<Empb> emps { get; set; } = new List<Empb>();
        attContent Dc { get; set; }
        List<StNode> nodes { get; set; }
        List<CHECKINOUT> clist = new List<CHECKINOUT>();
        GetDeptNameDelgate GetDeptName { get; set; }
        public LoadCheck(List<Dept> depts, attContent dc, GetDeptNameDelgate _GetDeptName)
        {
            InitializeComponent();
            Depts = depts;
            Dc = dc;
            GetDeptName = _GetDeptName;
        }

        public List<CHECKINOUT> GetCheckList(out DateTime beginDate,out DateTime endDate)
        {
            this.ShowDialog();
            beginDate = BeginDate.Value;
            endDate = EndDate.Value;
            return clist;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            nodes = new List<StNode>();
            Depts.ForEach(p =>
            {
                nodes.Add(new StNode
                {
                    Name = p.DeptName,
                    Text = p.DeptName,
                    Id = p.DeptId,
                    UpId = p.UpDptId,
                });
            });

            nodes.OrderBy(t => t.Name).ToList().ForEach(p =>
              {
                  if (p.UpId != 0)
                  {
                      var f = nodes.Single(n => n.Id == p.UpId);
                      f.Nodes.Add(p);
                  }
              });
            DeptTree.Nodes.Add(nodes.Single(p => p.UpId == 0));
            int d = DateTime.Now.Day - 1;
            EndDate.Value = DateTime.Now.Date.AddDays(-d);
            BeginDate.Value = EndDate.Value.AddMonths(-1);
            EndDate.Value = EndDate.Value.AddDays(-1);
            DeptTree.ExpandAll();

        }

        private void DeptTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode n in e.Node.Nodes)
            {
                n.Checked = e.Node.Checked;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<int> re = nodes.Where(p => p.Checked).Select(n => n.Id).ToList();
            var ulist = Dc.USERINFO.Where(p => re.Contains(p.DEFAULTDEPTID)).ToList();
            emps = new List<Empb>();
            ulist.ForEach((Action<USERINFO>)(p => emps.Add(new Empb
            {
                UserId = p.USERID,
                UserName = p.Name,
                HiredDay = p.HIREDDAY,
                IsSelect = true,
                DeptName = GetDeptName(p.DEFAULTDEPTID),
                DeptId = p.DEFAULTDEPTID,
            })));
            empBindingSource.DataSource = emps.OrderBy(p => p.DeptId);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (emps.Count > 0)
            {
                bool s = emps[0].IsSelect;
                emps.ForEach(p => p.IsSelect = !s);
                empDataGridView.Refresh();
            }
        }

        private void EmpDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DgvHelp.PointNum(empDataGridView, e);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (emps.Where(p => p.IsSelect).Count() == 0)
            {
                MessageBox.Show("请选择要导入的员工.");
                return;
            };
            if (BeginDate.Value > EndDate.Value)
            {
                MessageBox.Show("日期范围不正确.");
                return;
            }
            var edate = EndDate.Value.AddDays(2);
            List<int> idList = emps.Where(p => p.IsSelect).Select(p => p.UserId).ToList();
            clist = Dc.CHECKINOUT.Where(p => p.CHECKTIME > BeginDate.Value && p.CHECKTIME < edate && idList.Contains(p.USERID)).ToList();
            this.Close();

        }
    }

    public class StNode : TreeNode
    {
        public int Id { get; set; }
        public int UpId { get; set; }
    }
}

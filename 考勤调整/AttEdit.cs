using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheckDb;
using 考勤调整.Util;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace 考勤调整
{
    public partial class AttEdit : Form
    {
        attContent dc;
        bool IsConnect = false;
        DeptOper Doper;
        List<Shift> Shifts = new List<Shift>();
        CheckModify Cm = new CheckModify();
        List<EmpCheckMonth> Emps { get; set; }
        public AttEdit()
        {
            InitializeComponent();

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (empDgv.SelectedRows.Count > 0)
            {
                var obj = (EmpCheckMonth)empDgv.SelectedRows[0].DataBoundItem;
                empCheckDayBindingSource.DataSource = obj.EmpChecks.OrderBy(p => p.CheckDate);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var conList = ConfigurationManager.ConnectionStrings;
            for (int i = 1; i < conList.Count; i++)
            {
                tool_con.Items.Add(conList[i].Name);
            }
            Cm.Am = true;
            Cm.Pm = true;
            Cm.Ot = true;
            Cm.Need7Rest1 = true;
            Cm.OneCheckBuildOneDay = true;
            checkModifyBindingSource.DataSource = Cm;
            tool_con.SelectedIndex = 0;
            modeselect.SelectedIndex = 0;

        }
        private void ReadShift()
        {   //读取班次
            //var shiftStr = ConfigHelper.GetAppConfig("shift");
            //if (shiftStr != null && shiftStr != "")
            //{
            //    Shifts = JsonHelper.JsonToList<Shift>(shiftStr);
            //}
            Shifts.Clear();
            dc.AttParam.Where(p => p.PARATYPE == "si").ToList().ForEach(p =>
            {

                Shifts.Add(new Shift(p.PARANAME, p.PARAVALUE));
            });

            shiftBindingSource.DataSource = Shifts;
            bindingNavigator1.BindingSource = shiftBindingSource;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (!IsConnect)
            {

                string dbcon = tool_con.Text;
                if (dbcon != "")
                {
                    dc = new attContent(dbcon);
                    Doper = new DeptOper(dc);
                    ReadShift();
                    toolStripButton1.Text = "关闭连接";
                    IsConnect = true;
                }
                else
                {
                    MessageBox.Show("请选择数据库连接!");
                }

            }
            else
            {
                dc = null;
                toolStripButton1.Text = "连接数据库";
                IsConnect = false;
                empCheckMonthBindingSource.DataSource = null;
                empCheckDayBindingSource.DataSource = null;
                shiftBindingSource.DataSource = null;
            }
            tool_con.Enabled = !IsConnect;
            tabControl1.Enabled = IsConnect;
            btn_LoadData.Enabled = IsConnect;
            btn_SyncCheck.Enabled = IsConnect;
            modeselect.Enabled = IsConnect;
            BtnWriteToDb.Enabled = IsConnect;
        }

        public void setEnabled(bool yn)
        {

            tabControl1.Enabled = yn;
            btn_SyncCheck.Enabled = yn;
            btn_LoadData.Enabled = yn;
            modeselect.Enabled = yn;
            BtnWriteToDb.Enabled = yn;
            toolStripButton1.Enabled = yn;
        }

        private void Btn_LoadData_Click(object sender, EventArgs e)
        {
            LoadCheck f2 = new LoadCheck(Doper.Depts, dc, Doper.GetDeptName);
            var checks = f2.GetCheckList(out DateTime beginDate, out DateTime endDate);
            var users = dc.USERINFO.ToList();
            var getday = new AttControlClass(dc);
            Emps = new List<EmpCheckMonth>();
            checks.ForEach(p =>
            {
                var eobj = Emps.Where(o => o.Emp.USERID == p.USERID).SingleOrDefault();

                if (eobj == null)
                {
                    var user = users.Where(u => u.USERID == p.USERID).Single();

                    eobj = new EmpCheckMonth(user, getday, new DeptOper(dc).GetDeptName);
                    eobj.Shifts = this.Shifts;
                    eobj.SetDate(beginDate, endDate);
                    Emps.Add(eobj);
                }
                eobj.Add(p);
            });
            Emps.ForEach(p => p.SetShifts());
            empCheckMonthBindingSource.DataSource = Emps.OrderByDescending(p => p.DeptName).ThenBy(p => p.EmpId).ToList();

        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DgvHelp.PointNum(empDgv, e);
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            if (dayDgv.SelectedRows.Count > 0)
            {
                EmpCheckDay cr = (EmpCheckDay)dayDgv.SelectedRows[0].DataBoundItem;
                DayCheckEdit dce = new DayCheckEdit();
                dce.EditChecks(cr);
                dayDgv.Refresh();
            }
            else MessageBox.Show("请选择考勤数据");
        }

        private void BtnSaveShift_Click(object sender, EventArgs e)
        {
            //  ConfigHelper.UpdateAppConfig("shift", JsonHelper.ToJson(Shifts));

            Shifts.ForEach(p =>
           {
               if (p.ID == "")
               {
                   var ap = new AttParam
                   {
                       PARANAME = p.ID,
                       PARATYPE = "si",
                       PARAVALUE = p.ToShiftString()
                   };
                   dc.AttParam.Add(ap);
               }
               else
               {
                   var s = dc.AttParam.SingleOrDefault(at => at.PARANAME == p.ID);
                   if (s != null)
                   {
                       s.PARAVALUE = p.ToShiftString();
                   }
               }
           });
            dc.SaveChanges();
            MessageBox.Show("保存成功");



        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var selectShift = (Shift)shiftdgv.CurrentRow.DataBoundItem;
            var rows = empDgv.SelectedRows;
            foreach (DataGridViewRow r in rows)
            {
                var empobj = (EmpCheckMonth)r.DataBoundItem;
                empobj.ChangeShift(selectShift);

            }
            dayDgv.Refresh();
            MessageBox.Show("更改成功");

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            var selectShift = (Shift)shiftdgv.CurrentRow.DataBoundItem;
            var rows = dayDgv.SelectedRows;
            if (rows.Count > 0)
            {
                var ecd = (EmpCheckDay)rows[0].DataBoundItem;
                var ecm = Emps.SingleOrDefault(p => p.EmpId == ecd.Emp.USERID);
                if (ecm != null)
                {
                    foreach (DataGridViewRow r in rows)
                    {

                        var dayobj = (EmpCheckDay)r.DataBoundItem;
                        ecm.ChangeShift(dayobj, selectShift);
                    }
                    dayDgv.Refresh();
                    MessageBox.Show("更改成功");
                }

            }

        }


        private void BtnBuildCheck_Click(object sender, EventArgs e)
        {
            if (Emps != null && Emps.Count > 0)
            {
                Cm.BuildEmpCheck(Emps);
                dayDgv.Refresh();
            }
            else
            {
                MessageBox.Show("请先加载员工考勤数据。");
            }

        }


        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            bool v = checkBox6.Checked;
            Emps.ForEach(p =>
            {
                p.SetIgnore15MinuteCheck(v);
            });
            dayDgv.Refresh();
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            bool v = checkBox7.Checked;
            Emps.ForEach(p =>
            {
                p.SetShowNewCheckData(v);
            });
            dayDgv.Refresh();
            empDgv.Refresh();
        }

        private void Btn_SyncCheck_Click(object sender, EventArgs e)
        {
            new CheckSyncForm(dc).ShowDialog();
        }

        private delegate void SetPos(int ipos);
        /// <summary>
        /// 进度条值更新函数（参数必须跟声明的代理参数一样）
        /// </summary>
        /// <param name="ipos"></param>
        /// <param name="vinfo"></param>
        private void SetPbPos(int ipos)
        {
            if (this.InvokeRequired)
            {
                SetPos setPos = new SetPos(SetPbPos);
                this.Invoke(setPos, new object[] { ipos });
            }
            else
            {
                this.Pb.Value = Pb.Value + ipos;
                if (Pb.Value == Emps.Count)
                {
                    MessageBox.Show("写入完成！");
                    this.Pb.Value = 0;
                    setEnabled(true);
                }
            }
        }

        private void BtnWriteToDb_Click(object sender, EventArgs e)
        {
            bool isAllWriteMode = modeselect.SelectedIndex == 0 ? true : false;
            Pb.Maximum = Emps.Count;
            setEnabled(false);
            Task t = new Task(() =>
                   {
                       Emps.ForEach(p =>
                          {
                              p.WriteToDate(dc, isAllWriteMode);
                              SetPbPos(1);
                          });
                   }
                );
            t.Start();


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dayDgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow p in dayDgv.SelectedRows)
                {
                    EmpCheckDay cd = (EmpCheckDay)p.DataBoundItem;
                    cd.NewChecks.Clear();
                }

                dayDgv.Refresh();
            }
            else MessageBox.Show("请选择考勤数据");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var f = saveFileDialog1.ShowDialog();
            if (f == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                Emps.SaveToExcel(saveFileDialog1.FileName);
                MessageBox.Show("导出完成.");
            }

        }

        private void DayDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void NumericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (YearHoliday.Value > 0)
            {
                int v = (int)YearHoliday.Value;
                Emps.ForEach(p => p.AnnualHolidays = v);
            }

        }
    }
}

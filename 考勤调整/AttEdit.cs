﻿using System;
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
using CCWin;

namespace 考勤调整
{
    public partial class AttEdit : Skin_DevExpress
    {
        attContent dc { get; set; }
        bool IsConnect = false;
        DeptOper Doper { get; set; }
        List<Shift> Shifts = new List<Shift>();
        CheckModify Cm = new CheckModify();
        List<EmpCheckMonth> Emps { get; set; }
        LoadCheck lc;
        List<DelAttInfo> dinfo = new List<DelAttInfo>();
        public AttEdit()
        {
            InitializeComponent();

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (empDgv.SelectedRows.Count > 0)
            {
                var obj = (EmpCheckMonth)empDgv.SelectedRows[0].DataBoundItem;
                empCheckDayBindingSource.DataSource = obj.GetEmpChecks.OrderBy(p => p.CheckDate);

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
            shiftdgv.EditMode = DataGridViewEditMode.EditOnEnter;
            int d = DateTime.Today.Day;
            d1a.Value = DateTime.Today.AddDays(-d + 1).AddMonths(-1);
            d1b.Value = DateTime.Today.AddDays(-d);
            d4a.Value = d1b.Value;
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
                    dc.ConName = dbcon;
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
                dc.Dispose();
                textBox2.Text = "";
                lc = null;
                Doper = null;
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
            if (lc == null) lc = new LoadCheck(Doper.Depts, dc, Doper.GetDeptName);
            var checks = lc.GetCheckList(out DateTime beginDate, out DateTime endDate);
            var users = dc.USERINFO.ToList();
            var Acc = new AttControlClass(dc);
            Emps = new List<EmpCheckMonth>();
            checks.ForEach(p =>
            {
                var eobj = Emps.Where(o => o.Emp.USERID == p.USERID).SingleOrDefault();

                if (eobj == null)
                {
                    var user = users.Where(u => u.USERID == p.USERID).Single();

                    eobj = new EmpCheckMonth(user, Acc, new DeptOper(dc).GetDeptName);
                    eobj.Shifts = this.Shifts;
                    eobj.SetDate(beginDate, endDate);
                    Emps.Add(eobj);
                }
                eobj.Add(p);
            });
            Emps.ForEach(p => p.SetShifts());
            var list = Emps.OrderByDescending(p => p.DeptName).ThenBy(p => p.EmpId).ToList();
            empCheckMonthBindingSource.DataSource = new BindingCollection<EmpCheckMonth>(list);
            YearHoliday.Value = 0;

        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
          //  DgvHelp.PointNum(empDgv, e);
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
            gbbc.Focus();
            //保存编辑
            Shifts.ForEach(p =>
             {
                 var s = dc.AttParam.SingleOrDefault(at => at.PARANAME == p.ID);
                 if (s == null)
                 {
                     s = new AttParam
                     {
                         PARANAME = p.ID,
                         PARATYPE = "si",
                         PARAVALUE = p.ToShiftString()
                     };
                     dc.AttParam.Add(s);
                 }
                 else
                 {
                     s.PARAVALUE = p.ToShiftString();
                 }
             });
            //保存删除

            dc.AttParam.Where(p => p.PARATYPE == "si").ToList().ForEach(p =>
            {
                if (Shifts.Count(s => s.ID == p.PARANAME) == 0) dc.AttParam.Remove(p);
            });

            dc.SaveChanges();

            shiftdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shiftdgv.ReadOnly = true;
            BtnDeleteShift.Enabled = false;
            BtnAddShift.Enabled = false;
            BtnSaveShift.Enabled = false;
            BtnEditShift.Enabled = true;
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
            empDgv.Refresh();
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

        /// <summary>
        /// 写入数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWriteToDb_Click(object sender, EventArgs e)
        {
            if (Emps != null && Emps.Count > 0)
            {
                bool isAllWriteMode = modeselect.SelectedIndex == 0 ? true : false;
                Pb.Maximum = Emps.Count;
                setEnabled(false);
                Task t = new Task(() =>
                       {
                           Emps.ForEach(p =>
                              {
                                  if (isAllWriteMode)
                                  {
                                      p.FastWriteToDate(dc);

                                  }
                                  else p.WriteToDate(dc, isAllWriteMode);
                                  SetPbPos(1);
                              });
                       }
                    );
                t.Start();
            }
            else
            {
                MessageBox.Show("没有调整数据.");
            }


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

     

        private void NumericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (YearHoliday.Value >= 0)
            {
                int v = (int)YearHoliday.Value;
                Emps.ForEach(p => p.AnnualHolidays = v);
            }
            empDgv.Refresh();

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 回载考勤调整表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                dinfo.Clear();
                delAttInfoBindingSource.DataSource = null;

                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    double zdgz = double.Parse(textBox1.Text);
                    DataTable dt = ExcelOper.ReadExcelToTable(openFile.FileName);
                    if (dt != null)
                    {
                        foreach (DataRow p in dt.Rows)
                        {
                            var m = p["金额"].ToString().Replace(" ", "");
                            if (m != "")
                            {
                                DelAttInfo ndai = new DelAttInfo();
                                ndai.Name = p["姓名"].ToString();
                                ndai.LowGz = zdgz;
                                ndai.Money = Math.Round(double.Parse(m), 1);
                                dinfo.Add(ndai);
                            }
                        }
                        delAttInfoBindingSource.DataSource = dinfo;
                    }
                }
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }
        /// <summary>
        /// 开始调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            dinfo.ForEach(p =>
            {
                CheckAutoDelete cad = new CheckAutoDelete(dc, this.Shifts);
                cad.LoadCheck(p.Name, d1a.Value, d1b.Value);
                p.ReHours = cad.DeleteHour(p.Hours);

            });
            delAttInfoDataGridView.Refresh();
            MessageBox.Show("调整完成。");
        }

        private void Sc_Click(object sender, EventArgs e)
        {
            DateTime bt = d4a.Value.Add(d4t1.Value.TimeOfDay);
            DateTime et = d4a.Value.Add(d4t2.Value.TimeOfDay);
            int count = new CheckDelete(dc).DeleteCheck(bt, et);
            MessageBox.Show(string.Format("共删除了{0}条打卡记录.", count));

        }
        /// <summary>
        /// 自动排班
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            var selectrows = shiftdgv.SelectedRows;
            if (selectrows.Count > 0)
            {
                List<Shift> ls = new List<Shift>();

                foreach (DataGridViewRow r in selectrows)
                {
                    ls.Add((Shift)r.DataBoundItem);
                };
                var rows = empDgv.SelectedRows;
                foreach (DataGridViewRow r in rows)
                {
                    var empobj = (EmpCheckMonth)r.DataBoundItem;
                    empobj.AutoChangeShift(ls);

                }
                dayDgv.Refresh();
                MessageBox.Show("排班完成");
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var ulist = dc.USERINFO.ToList();
            ulist.ForEach(p =>
            {
                p.Name = p.Name.Split('\0')[0];
                if (p.DEFAULTDEPTID == null)
                {
                    p.DEFAULTDEPTID = 1;
                }
            });

            dc.SaveChanges();
            dayDgv.Refresh();
            MessageBox.Show("修正完成");
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {

            var rows = empDgv.SelectedRows;
            foreach (DataGridViewRow r in rows)
            {
                var empobj = (EmpCheckMonth)r.DataBoundItem;
                empobj.SetOneWeekIsSameShift();

            }
            dayDgv.Refresh();
            MessageBox.Show("排班完成");

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AttDbRepair adr = new AttDbRepair();
            adr.RepairDb(dc);
            MessageBox.Show("修复命令执行完成.");

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Modeselect_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton8_Click(object sender, EventArgs e)
        {
            dinfo.Clear();
            delAttInfoBindingSource.DataSource = null;
        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            bool v = checkBox9.Checked;
            Emps.ForEach(p =>
            {
                p.SetWorkHourTo8(v);
            });
            dayDgv.Refresh();
            empDgv.Refresh();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            shiftdgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            shiftdgv.ReadOnly = false;
            BtnDeleteShift.Enabled = true;
            BtnAddShift.Enabled = true;
            BtnSaveShift.Enabled = true;
            BtnEditShift.Enabled = false;
        }




        private void button8_Click(object sender, EventArgs e)
        {
            empDgv.SelectAll();

        }

        private void SaveEmpShifts_Click(object sender, EventArgs e)
        {
            Emps.ForEach(p =>
            {
                p.SaveEmpShift();
            });
            MessageBox.Show("保存成功!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ( Emps!=null&&Emps.Count > 0)
            {
                var s = textBox2.Text.ToUpper();
                if (s != "")
                {
                    var re = Emps.Where(p => p.EmpNote.EmpPyName.Contains(s)).ToList();
                    empCheckMonthBindingSource.DataSource = re;
                }
                else
                {
                    empCheckMonthBindingSource.DataSource = Emps;
                }
            }
        }

        private void skinTextBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dayDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

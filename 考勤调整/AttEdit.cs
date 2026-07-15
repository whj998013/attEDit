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
using System.Data.SqlClient;

namespace 考勤调整
{
    /// <summary>
    /// 主窗口：考勤调整界面
    /// 负责连接数据库、加载/修改/保存打卡与排班数据，以及触发相关批量操作。
    /// </summary>
    public partial class AttEdit : Form
    {
        /// <summary>
        /// 数据库上下文，用于访问和保存考勤相关表（attContent）。
        /// </summary>
        attContent dc { get; set; }

        /// <summary>
        /// 当前是否与数据库建立连接的标志。
        /// </summary>
        bool IsConnect = false;

        /// <summary>
        /// 部门操作封装（用于获取部门名称等）。
        /// </summary>
        DeptOper Doper { get; set; }

        /// <summary>
        /// 系统中可用的班次列表。
        /// </summary>
        List<Shift> Shifts = new List<Shift>();

        /// <summary>
        /// 考勤修改设置（如上/下午规则、是否合并等）。
        /// </summary>
        CheckModify Cm = new CheckModify();

        /// <summary>
        /// 当前加载的员工月度考勤集合（用于界面绑定与批量处理）。
        /// </summary>
        List<EmpCheckMonth> Emps { get; set; }

        /// <summary>
        /// 负责从数据库或文件加载打卡记录的辅助类实例。
        /// </summary>
        LoadCheck lc;

        /// <summary>
        /// 导入/删除考勤相关的临时信息列表（例如工资签字表数据）。
        /// </summary>
        List<DelAttInfo> dinfo = new List<DelAttInfo>();

        /// <summary>
        /// 构造函数：初始化窗口组件。
        /// </summary>
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

        /// <summary>
        /// 窗体加载事件：初始化连接字符串下拉、默认考勤修改设置并绑定到界面控件。
        /// 在程序启动时执行一次，用于准备界面和默认参数。
        /// </summary>
        /// <param name="sender">事件发送者</param>
        /// <param name="e">事件参数</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            var conList = ConfigurationManager.ConnectionStrings;


            for (int i = 1; i < conList.Count; i++)
            {
                var item = conList[i];
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(item.ConnectionString);
                tool_con.Items.Add(string.Format("{0}/{1}", item.Name, builder.DataSource));
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

        /// <summary>
        /// 连接/断开数据库按钮点击处理。
        /// 连接时根据所选连接名创建 attContent、读取班次并启用界面功能；断开时释放资源并清空绑定数据。
        /// </summary>
        /// <param name="sender">事件发送者</param>
        /// <param name="e">事件参数</param>
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (!IsConnect)
            {

                string dbcon = tool_con.Text.Split('/').First();
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

        /// <summary>
        /// 加载考勤数据按钮点击处理：从数据库读取打卡记录，按员工构建 EmpCheckMonth 对象并绑定到界面。
        /// 会根据读取到的起止日期为每个员工初始化日考勤集合并设置默认班次。
        /// </summary>
        /// <param name="sender">事件发送者</param>
        /// <param name="e">事件参数</param>
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
                    DataTable dt = ExcelOper.ExcelToDataTable(openFile.FileName, "签字工资表", 1, 2);
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
                }
                ;
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
            if (Emps != null && Emps.Count > 0)
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

        private void empDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            new DbMangeForm().ShowDialog();
        }

        private void tool_con_Click(object sender, EventArgs e)
        {

        }

        private void AttEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 将原始考勤复制到新考勤（撤销所有调整），用于恢复原始数据。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (Emps != null && Emps.Count > 0)
            {
                Emps.ForEach(p =>
                {
                    p.EmpChecks.ForEach(check =>
                    {
                        check.NewChecks.Clear();
                        check.RawChecks.ForEach(c =>
                        {
                            check.NewChecks.Add(c.Clone());
                        });
                    });

                });
                dayDgv.Refresh();
            }
        }
        /// <summary>
        /// 删除首位打卡中间的所有打卡记录。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            if (Emps != null && Emps.Count > 0)
            {
                Emps.ForEach(p =>
                {
                    p.EmpChecks.ForEach(check =>
                    {
                       check.NewChecks = check.NewChecks.OrderBy(c => c.CHECKTIME).ToList();
                        if (check.NewChecks.Count > 2)
                        {
                            var first = check.NewChecks.First();
                            var last = check.NewChecks.Last();
                            check.NewChecks.Clear();
                            check.NewChecks.Add(first);
                            check.NewChecks.Add(last);
                        }
                    });
                });
                dayDgv.Refresh();

            }
        }

        private void shiftdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

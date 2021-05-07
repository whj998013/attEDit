using CheckDb;
using System;
using System.Linq;
using System.Windows.Forms;

namespace 考勤调整
{
    public partial class CheckSyncForm : Form
    {
        private attContent cdb { get; set; }
        public CheckSyncForm(attContent _cdb)
        {
            InitializeComponent();
            cdb = _cdb;
        }

        private void CheckSyncForm_Load(object sender, EventArgs e)
        {
            int d = DateTime.Now.Day - 1;
            EndDate.Value = DateTime.Now.Date.AddDays(-d);
            BeginDate.Value = EndDate.Value.AddMonths(-1);
            EndDate.Value = EndDate.Value.AddDays(-1);
            var r = cdb.tday.First();
            l4.Text += string.Format("开始日期:{0},结束日期:{1}", r.t1.Value.ToShortDateString(), r.t2.Value.ToShortDateString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (EndDate.Value <= DateTime.Parse("2022-1-1"))
            {
                CheckSync cs = new CheckSync(cdb, BeginDate.Value, EndDate.Value);
                int count = cs.SyncCount();
                var re = MessageBox.Show(string.Format("本次同步将增加{0}条记录，是否继续同步。", count), "是否同步", MessageBoxButtons.OKCancel);
                if (re == DialogResult.OK)
                {
                    cs.Sync(out int delNum, out int addNum);
                    var r = cdb.tday.First();
                    r.t1 = BeginDate.Value;
                    r.t2 = EndDate.Value;
                    cdb.SaveChanges();
                    MessageBox.Show(string.Format("同步成功，删除{0}条,新加{1}", delNum, addNum));
                }
            }
            else
            {
                throw new Exception("内部时间错误，请联系开发人员");
            }

        }
    }
}

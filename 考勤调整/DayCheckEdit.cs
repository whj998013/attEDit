using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheckDb;

namespace 考勤调整
{
    public partial class DayCheckEdit : Form
    {
        private EmpCheckDay Ecd { get; set; }
        
        public DayCheckEdit()
        {
            InitializeComponent();
        }
        
        public void EditChecks(EmpCheckDay ecd)
        {
            Ecd = ecd;
            cHECKINOUTBindingSource.DataSource = Ecd.NewChecks;
            this.ShowDialog();
        }
    

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            Ecd.NewChecks.Add(new CHECKINOUT
            {
                USERID = Ecd.Emp.USERID,
                CHECKTIME = Ecd.CheckDate,
            });
            cHECKINOUTBindingSource.DataSource = null;
            cHECKINOUTBindingSource.DataSource = Ecd.NewChecks;

            cdgv.Refresh();
        }
    }
}

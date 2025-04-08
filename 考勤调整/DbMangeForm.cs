using NPOI.SS.Formula.Eval;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;
using System.Configuration;
namespace 考勤调整
{

    public partial class DbMangeForm : Form
    {
        SqlInfo Si { get; set; }
        public DbMangeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Si = GetSqlInfo();
                if (Si == null) return;

                bool result = Si.CheckDatabaseExists("att2000sql");
                if (result)
                {
                    SetState(result);

                }
                else
                {
                    var vv = MessageBox.Show("服务器连接成功，未建立原始数据库，是否建立原始数据库？", "是否初始化？", MessageBoxButtons.YesNo);
                    if (vv == DialogResult.Yes)
                    {

                        Si.CreateDatabaseAndExecuteScript("att2000sql", "a.sql");
                        MessageBox.Show("初始化成功");
                        SetState(result);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }


        private void SetState(bool state)
        {
            if (state)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
        }



        private SqlInfo GetSqlInfo()
        {
            if (string.IsNullOrEmpty(textBox_server.Text))
            {
                MessageBox.Show("请输入服务器名称");
                return null;
            }
            if (string.IsNullOrEmpty(textBox_UserName.Text))
            {
                MessageBox.Show("请输入用户名");
                return null;
            }

            if (string.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("请输入密码");
                return null;
            }

            SqlInfo si = new SqlInfo
            {
                ServerName = textBox_server.Text,
                User = textBox_UserName.Text,
                PassWord = textBox_Password.Text
            };
            return si;
        }

        // ...

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Si != null && textBox1.Text != "")
                {
                    string BDbName = textBox1.Text;
                    Si.CreateDatabaseAndExecuteScript(BDbName, "b.sql");
                    MessageBox.Show("创建成功");

                    var connectionString = new ConnectionStringSettings
                    {
                        Name = BDbName,
                        ConnectionString = $"Server={Si.ServerName};Database={BDbName};User Id={Si.User};Password={Si.PassWord};",
                        ProviderName = "System.Data.SqlClient"
                    };
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.ConnectionStrings.ConnectionStrings.Add(connectionString);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("connectionStrings");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DbMangeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

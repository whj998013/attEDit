namespace 考勤调整
{
    partial class DbMangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_UserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_server);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "连接服务器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 56);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "库名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "建立B考勤数据库";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::考勤调整.Properties.Settings.Default, "SqlUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_UserName.Location = new System.Drawing.Point(51, 48);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(143, 21);
            this.textBox_UserName.TabIndex = 2;
            this.textBox_UserName.Text = global::考勤调整.Properties.Settings.Default.SqlUser;
            // 
            // textBox_server
            // 
            this.textBox_server.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::考勤调整.Properties.Settings.Default, "SqlServerAddr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_server.Location = new System.Drawing.Point(51, 19);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(143, 21);
            this.textBox_server.TabIndex = 0;
            this.textBox_server.Text = global::考勤调整.Properties.Settings.Default.SqlServerAddr;
            // 
            // textBox_Password
            // 
            this.textBox_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::考勤调整.Properties.Settings.Default, "SqlPwd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Password.Location = new System.Drawing.Point(51, 76);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(143, 21);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.Text = global::考勤调整.Properties.Settings.Default.SqlPwd;
            // 
            // DbMangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbMangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库管理";
            this.Load += new System.EventHandler(this.DbMangeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}
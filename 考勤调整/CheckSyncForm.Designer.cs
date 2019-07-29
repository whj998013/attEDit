namespace 考勤调整
{
    partial class CheckSyncForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.BeginDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "结束日期";
            // 
            // EndDate
            // 
            this.EndDate.CausesValidation = false;
            this.EndDate.Location = new System.Drawing.Point(111, 89);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(161, 21);
            this.EndDate.TabIndex = 3;
            this.EndDate.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // BeginDate
            // 
            this.BeginDate.CausesValidation = false;
            this.BeginDate.Location = new System.Drawing.Point(111, 50);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Size = new System.Drawing.Size(161, 21);
            this.BeginDate.TabIndex = 4;
            this.BeginDate.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "开始日期";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l4.Location = new System.Drawing.Point(28, 20);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(83, 12);
            this.l4.TabIndex = 7;
            this.l4.Text = "上次同步日期:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "同步";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CheckSyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckSyncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤同步";
            this.Load += new System.EventHandler(this.CheckSyncForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker BeginDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Button button1;
    }
}
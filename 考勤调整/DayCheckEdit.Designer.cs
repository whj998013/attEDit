namespace 考勤调整
{
    partial class DayCheckEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayCheckEdit));
            this.cHECKINOUTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.cHECKINOUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cdgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cHECKINOUTBindingNavigator)).BeginInit();
            this.cHECKINOUTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHECKINOUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cHECKINOUTBindingNavigator
            // 
            this.cHECKINOUTBindingNavigator.AddNewItem = null;
            this.cHECKINOUTBindingNavigator.BindingSource = this.cHECKINOUTBindingSource;
            this.cHECKINOUTBindingNavigator.CountItem = null;
            this.cHECKINOUTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cHECKINOUTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.cHECKINOUTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cHECKINOUTBindingNavigator.MoveFirstItem = null;
            this.cHECKINOUTBindingNavigator.MoveLastItem = null;
            this.cHECKINOUTBindingNavigator.MoveNextItem = null;
            this.cHECKINOUTBindingNavigator.MovePreviousItem = null;
            this.cHECKINOUTBindingNavigator.Name = "cHECKINOUTBindingNavigator";
            this.cHECKINOUTBindingNavigator.PositionItem = null;
            this.cHECKINOUTBindingNavigator.Size = new System.Drawing.Size(360, 25);
            this.cHECKINOUTBindingNavigator.TabIndex = 0;
            this.cHECKINOUTBindingNavigator.Text = "bindingNavigator1";
            // 
            // cHECKINOUTBindingSource
            // 
            this.cHECKINOUTBindingSource.DataSource = typeof(CheckDb.CHECKINOUT);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "退出";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "增加";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // cdgv
            // 
            this.cdgv.AllowUserToAddRows = false;
            this.cdgv.AutoGenerateColumns = false;
            this.cdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cdgv.DataSource = this.cHECKINOUTBindingSource;
            this.cdgv.Location = new System.Drawing.Point(0, 28);
            this.cdgv.Name = "cdgv";
            this.cdgv.RowTemplate.Height = 23;
            this.cdgv.Size = new System.Drawing.Size(359, 305);
            this.cdgv.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "USERID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CHECKTIME";
            this.dataGridViewTextBoxColumn2.HeaderText = "打卡时间";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // DayCheckEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 341);
            this.Controls.Add(this.cdgv);
            this.Controls.Add(this.cHECKINOUTBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DayCheckEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤修改";
            ((System.ComponentModel.ISupportInitialize)(this.cHECKINOUTBindingNavigator)).EndInit();
            this.cHECKINOUTBindingNavigator.ResumeLayout(false);
            this.cHECKINOUTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHECKINOUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cHECKINOUTBindingSource;
        private System.Windows.Forms.BindingNavigator cHECKINOUTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.DataGridView cdgv;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
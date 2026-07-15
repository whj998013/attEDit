using System.Windows.Forms;

namespace 考勤调整
{
    partial class AttEdit
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empDgv = new System.Windows.Forms.DataGridView();
            this.BigWeekHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dayDgv = new System.Windows.Forms.DataGridView();
            this.ShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewCheckRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuildCheck = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tool_con = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SyncCheck = new System.Windows.Forms.ToolStripButton();
            this.btn_LoadData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Pb = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnWriteToDb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.modeselect = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label16 = new System.Windows.Forms.Label();
            this.SaveEmpShifts = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.YearHoliday = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bigeweektime = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbbc = new System.Windows.Forms.GroupBox();
            this.shiftdgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnAddShift = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteShift = new System.Windows.Forms.ToolStripButton();
            this.BtnEditShift = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveShift = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.d4a = new System.Windows.Forms.DateTimePicker();
            this.d4t1 = new System.Windows.Forms.DateTimePicker();
            this.d4t2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delAttInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            this.d1b = new System.Windows.Forms.DateTimePicker();
            this.d1a = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hollydayTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restdayTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstCheckDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCheckMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstAmendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAmendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCheckDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkModifyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delAttInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayDgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearHoliday)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigeweektime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delAttInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCheckMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCheckDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkModifyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delAttInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empDgv
            // 
            this.empDgv.AllowUserToAddRows = false;
            this.empDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.empDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empDgv.AutoGenerateColumns = false;
            this.empDgv.BackgroundColor = System.Drawing.Color.White;
            this.empDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empNameDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn1,
            this.workTimeDataGridViewTextBoxColumn,
            this.overTimeDataGridViewTextBoxColumn,
            this.hollydayTimeDataGridViewTextBoxColumn,
            this.restdayTimeDataGridViewTextBoxColumn,
            this.totalTimeDataGridViewTextBoxColumn,
            this.BigWeekHour,
            this.firstCheckDateDataGridViewTextBoxColumn,
            this.CheckNum,
            this.EmpId});
            this.empDgv.DataSource = this.empCheckMonthBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.empDgv.EnableHeadersVisualStyles = false;
            this.empDgv.GridColor = System.Drawing.Color.Silver;
            this.empDgv.Location = new System.Drawing.Point(0, 32);
            this.empDgv.Name = "empDgv";
            this.empDgv.ReadOnly = true;
            this.empDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.empDgv.RowHeadersWidth = 40;
            this.empDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.empDgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.empDgv.RowTemplate.Height = 23;
            this.empDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empDgv.Size = new System.Drawing.Size(492, 568);
            this.empDgv.TabIndex = 0;
            this.empDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDgv_CellContentClick);
            this.empDgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView1_RowPostPaint);
            this.empDgv.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // BigWeekHour
            // 
            this.BigWeekHour.DataPropertyName = "BigWeekHour";
            this.BigWeekHour.HeaderText = "最大周工时";
            this.BigWeekHour.Name = "BigWeekHour";
            this.BigWeekHour.ReadOnly = true;
            // 
            // CheckNum
            // 
            this.CheckNum.DataPropertyName = "CheckNum";
            this.CheckNum.HeaderText = "出勤天数";
            this.CheckNum.Name = "CheckNum";
            this.CheckNum.ReadOnly = true;
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "员工ID";
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(582, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dayDgv
            // 
            this.dayDgv.AllowUserToAddRows = false;
            this.dayDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dayDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dayDgv.AutoGenerateColumns = false;
            this.dayDgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dayDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dayDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dayDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dayDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkDateDataGridViewTextBoxColumn,
            this.dayTypeDataGridViewTextBoxColumn,
            this.ShiftName,
            this.CheckRecord,
            this.NewCheckRecord,
            this.firstAmendDataGridViewTextBoxColumn,
            this.lastAmendDataGridViewTextBoxColumn,
            this.workTimeDataGridViewTextBoxColumn1,
            this.overTimeDataGridViewTextBoxColumn1,
            this.totalTimeDataGridViewTextBoxColumn1,
            this.allTimeDataGridViewTextBoxColumn});
            this.dayDgv.DataSource = this.empCheckDayBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dayDgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.dayDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayDgv.EnableHeadersVisualStyles = false;
            this.dayDgv.GridColor = System.Drawing.Color.LightGray;
            this.dayDgv.Location = new System.Drawing.Point(0, 0);
            this.dayDgv.Name = "dayDgv";
            this.dayDgv.ReadOnly = true;
            this.dayDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dayDgv.RowHeadersWidth = 30;
            this.dayDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dayDgv.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dayDgv.RowTemplate.Height = 23;
            this.dayDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dayDgv.Size = new System.Drawing.Size(943, 566);
            this.dayDgv.TabIndex = 2;
            this.dayDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dayDgv_CellContentClick);
            // 
            // ShiftName
            // 
            this.ShiftName.DataPropertyName = "ShiftName";
            this.ShiftName.HeaderText = "班次";
            this.ShiftName.Name = "ShiftName";
            this.ShiftName.ReadOnly = true;
            this.ShiftName.Width = 60;
            // 
            // CheckRecord
            // 
            this.CheckRecord.DataPropertyName = "CheckRecord";
            this.CheckRecord.HeaderText = "打卡记录";
            this.CheckRecord.Name = "CheckRecord";
            this.CheckRecord.ReadOnly = true;
            this.CheckRecord.Width = 250;
            // 
            // NewCheckRecord
            // 
            this.NewCheckRecord.DataPropertyName = "NewCheckRecord";
            this.NewCheckRecord.HeaderText = "调整后";
            this.NewCheckRecord.Name = "NewCheckRecord";
            this.NewCheckRecord.ReadOnly = true;
            this.NewCheckRecord.Width = 350;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DayType";
            this.dataGridViewTextBoxColumn1.HeaderText = "DayType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // BtnBuildCheck
            // 
            this.BtnBuildCheck.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnBuildCheck.Location = new System.Drawing.Point(582, 110);
            this.BtnBuildCheck.Name = "BtnBuildCheck";
            this.BtnBuildCheck.Size = new System.Drawing.Size(130, 74);
            this.BtnBuildCheck.TabIndex = 3;
            this.BtnBuildCheck.Text = "生成调整考勤";
            this.BtnBuildCheck.UseVisualStyleBackColor = false;
            this.BtnBuildCheck.Click += new System.EventHandler(this.BtnBuildCheck_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.tool_con,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btn_SyncCheck,
            this.btn_LoadData,
            this.toolStripSeparator2,
            this.Pb,
            this.toolStripSeparator3,
            this.BtnWriteToDb,
            this.toolStripSeparator4,
            this.modeselect,
            this.toolStripLabel2,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1453, 30);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(88, 27);
            this.toolStripButton9.Text = "数据库管理";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 27);
            this.toolStripLabel1.Text = "数据库：";
            // 
            // tool_con
            // 
            this.tool_con.AutoSize = false;
            this.tool_con.AutoToolTip = true;
            this.tool_con.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tool_con.DropDownWidth = 221;
            this.tool_con.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tool_con.Name = "tool_con";
            this.tool_con.Size = new System.Drawing.Size(221, 25);
            this.tool_con.Click += new System.EventHandler(this.tool_con_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 27);
            this.toolStripButton1.Text = "连接数据库";
            this.toolStripButton1.ToolTipText = "连接数据库";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // btn_SyncCheck
            // 
            this.btn_SyncCheck.Enabled = false;
            this.btn_SyncCheck.Image = ((System.Drawing.Image)(resources.GetObject("btn_SyncCheck.Image")));
            this.btn_SyncCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SyncCheck.Name = "btn_SyncCheck";
            this.btn_SyncCheck.Size = new System.Drawing.Size(76, 27);
            this.btn_SyncCheck.Text = "考勤同步";
            this.btn_SyncCheck.Click += new System.EventHandler(this.Btn_SyncCheck_Click);
            // 
            // btn_LoadData
            // 
            this.btn_LoadData.Enabled = false;
            this.btn_LoadData.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoadData.Image")));
            this.btn_LoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LoadData.Name = "btn_LoadData";
            this.btn_LoadData.Size = new System.Drawing.Size(100, 27);
            this.btn_LoadData.Text = "载入考勤数据";
            this.btn_LoadData.Click += new System.EventHandler(this.Btn_LoadData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // Pb
            // 
            this.Pb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Pb.Name = "Pb";
            this.Pb.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // BtnWriteToDb
            // 
            this.BtnWriteToDb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnWriteToDb.Enabled = false;
            this.BtnWriteToDb.Image = ((System.Drawing.Image)(resources.GetObject("BtnWriteToDb.Image")));
            this.BtnWriteToDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnWriteToDb.Name = "BtnWriteToDb";
            this.BtnWriteToDb.Size = new System.Drawing.Size(88, 27);
            this.BtnWriteToDb.Text = "写入数据库";
            this.BtnWriteToDb.Click += new System.EventHandler(this.BtnWriteToDb_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // modeselect
            // 
            this.modeselect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.modeselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeselect.Enabled = false;
            this.modeselect.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.modeselect.Items.AddRange(new object[] {
            "覆盖模式(按调整数据生成全部数据)",
            "调整模式(无调整数据则不删除原数据)"});
            this.modeselect.Name = "modeselect";
            this.modeselect.Size = new System.Drawing.Size(221, 30);
            this.modeselect.Click += new System.EventHandler(this.Modeselect_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 27);
            this.toolStripLabel2.Text = " 写入模式";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1453, 827);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1445, 801);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "考勤调整";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.gbbc);
            this.splitContainer2.Size = new System.Drawing.Size(1439, 795);
            this.splitContainer2.SplitterDistance = 600;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.SaveEmpShifts);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.empDgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1439, 600);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 5;
            this.label16.Text = "输入拼音查找";
            // 
            // SaveEmpShifts
            // 
            this.SaveEmpShifts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEmpShifts.BackColor = System.Drawing.Color.Transparent;
            this.SaveEmpShifts.Location = new System.Drawing.Point(385, 5);
            this.SaveEmpShifts.Name = "SaveEmpShifts";
            this.SaveEmpShifts.Size = new System.Drawing.Size(104, 23);
            this.SaveEmpShifts.TabIndex = 4;
            this.SaveEmpShifts.Text = "保存为默认班次";
            this.SaveEmpShifts.UseVisualStyleBackColor = true;
            this.SaveEmpShifts.Click += new System.EventHandler(this.SaveEmpShifts_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(339, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "全选";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.button10);
            this.splitContainer3.Panel1.Controls.Add(this.button9);
            this.splitContainer3.Panel1MinSize = 30;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dayDgv);
            this.splitContainer3.Size = new System.Drawing.Size(943, 600);
            this.splitContainer3.SplitterDistance = 30;
            this.splitContainer3.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Location = new System.Drawing.Point(833, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "删除中间考勤";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(735, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "复制原始数据";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BtnBuildCheck);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(713, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 189);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(648, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "清除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(582, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "导出考勤表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Controls.Add(this.YearHoliday);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Location = new System.Drawing.Point(392, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 170);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "考勤计算";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(7, 43);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(126, 16);
            this.checkBox9.TabIndex = 17;
            this.checkBox9.Text = "正常班次按8小时计";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // YearHoliday
            // 
            this.YearHoliday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "BigWeekHour", true));
            this.YearHoliday.Location = new System.Drawing.Point(79, 90);
            this.YearHoliday.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.YearHoliday.Name = "YearHoliday";
            this.YearHoliday.Size = new System.Drawing.Size(61, 21);
            this.YearHoliday.TabIndex = 16;
            this.YearHoliday.ValueChanged += new System.EventHandler(this.NumericUpDown6_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "年休假天数";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(8, 68);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(132, 16);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "显示调整后工时数据";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(8, 17);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(168, 16);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Text = "忽略首尾15分钟内出勤时间";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bigeweektime);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDown4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(182, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 170);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "生成随机范围";
            // 
            // bigeweektime
            // 
            this.bigeweektime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "LimtBigWeekTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bigeweektime.Location = new System.Drawing.Point(118, 140);
            this.bigeweektime.Name = "bigeweektime";
            this.bigeweektime.Size = new System.Drawing.Size(46, 21);
            this.bigeweektime.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "限制最大周工时";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 110);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(143, 16);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "打卡一次生成半天考勤";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "OneCheckBuildOneDay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton3.Location = new System.Drawing.Point(10, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(143, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "打卡一次生成全天考勤";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "后";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "前";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "OutB", true));
            this.numericUpDown3.Location = new System.Drawing.Point(148, 50);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "下班：";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "OutF", true));
            this.numericUpDown4.Location = new System.Drawing.Point(64, 50);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown4.TabIndex = 8;
            this.numericUpDown4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "后";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "前";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "InB", true));
            this.numericUpDown2.Location = new System.Drawing.Point(148, 18);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "上班：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "InF", true));
            this.numericUpDown1.Location = new System.Drawing.Point(64, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 170);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成方式";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "IsHollyDayNotWork", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox8.Location = new System.Drawing.Point(8, 145);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(96, 16);
            this.checkBox8.TabIndex = 17;
            this.checkBox8.Text = "节假日不上班";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "NoCheckAlwaysBuild", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox5.Location = new System.Drawing.Point(8, 100);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(156, 16);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "当天无打卡记录生成考勤";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "Need7Rest1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(8, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "保证七休一";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "Pm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Location = new System.Drawing.Point(68, 25);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(36, 16);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "PM";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "Ot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.Location = new System.Drawing.Point(128, 25);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(36, 16);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "OT";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "Am", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(9, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(36, 16);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "AM";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(155, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "仅生成首尾打卡区域考勤";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.checkModifyBindingSource, "BuildAllCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton2.Location = new System.Drawing.Point(9, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "生成全部考勤";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbbc
            // 
            this.gbbc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbbc.Controls.Add(this.shiftdgv);
            this.gbbc.Controls.Add(this.bindingNavigator1);
            this.gbbc.Location = new System.Drawing.Point(3, -1);
            this.gbbc.Name = "gbbc";
            this.gbbc.Size = new System.Drawing.Size(707, 192);
            this.gbbc.TabIndex = 4;
            this.gbbc.TabStop = false;
            this.gbbc.Text = "班次";
            // 
            // shiftdgv
            // 
            this.shiftdgv.AllowUserToAddRows = false;
            this.shiftdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.shiftdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.shiftdgv.AutoGenerateColumns = false;
            this.shiftdgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.shiftdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shiftdgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.shiftdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column1,
            this.BeginTime,
            this.EndTime});
            this.shiftdgv.DataSource = this.shiftBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shiftdgv.DefaultCellStyle = dataGridViewCellStyle21;
            this.shiftdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiftdgv.EnableHeadersVisualStyles = false;
            this.shiftdgv.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.shiftdgv.Location = new System.Drawing.Point(3, 42);
            this.shiftdgv.Name = "shiftdgv";
            this.shiftdgv.ReadOnly = true;
            this.shiftdgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.shiftdgv.RowHeadersWidth = 20;
            this.shiftdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.shiftdgv.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.shiftdgv.RowTemplate.Height = 23;
            this.shiftdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shiftdgv.Size = new System.Drawing.Size(701, 147);
            this.shiftdgv.TabIndex = 1;
            this.shiftdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shiftdgv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RestDay";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column1.HeaderText = "休息日";
            this.Column1.Items.AddRange(new object[] {
            "周日",
            "周一",
            "周二",
            "周三",
            "周四",
            "周五",
            "周六"});
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // BeginTime
            // 
            this.BeginTime.DataPropertyName = "BeginTime";
            this.BeginTime.HeaderText = "开始时间";
            this.BeginTime.Name = "BeginTime";
            this.BeginTime.ReadOnly = true;
            this.BeginTime.Width = 80;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "结束时间";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 80;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.BtnAddShift;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.BtnDeleteShift;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEditShift,
            this.BtnAddShift,
            this.BtnDeleteShift,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.BtnSaveShift});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(701, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "修改";
            // 
            // BtnAddShift
            // 
            this.BtnAddShift.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAddShift.Enabled = false;
            this.BtnAddShift.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddShift.Image")));
            this.BtnAddShift.Name = "BtnAddShift";
            this.BtnAddShift.RightToLeftAutoMirrorImage = true;
            this.BtnAddShift.Size = new System.Drawing.Size(23, 22);
            this.BtnAddShift.Text = "新添";
            // 
            // BtnDeleteShift
            // 
            this.BtnDeleteShift.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeleteShift.Enabled = false;
            this.BtnDeleteShift.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteShift.Image")));
            this.BtnDeleteShift.Name = "BtnDeleteShift";
            this.BtnDeleteShift.RightToLeftAutoMirrorImage = true;
            this.BtnDeleteShift.Size = new System.Drawing.Size(23, 22);
            this.BtnDeleteShift.Text = "删除";
            // 
            // BtnEditShift
            // 
            this.BtnEditShift.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnEditShift.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditShift.Image")));
            this.BtnEditShift.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditShift.Name = "BtnEditShift";
            this.BtnEditShift.Size = new System.Drawing.Size(36, 22);
            this.BtnEditShift.Text = "编辑";
            this.BtnEditShift.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(136, 22);
            this.toolStripButton3.Text = "更改选定日期的班次";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(136, 22);
            this.toolStripButton2.Text = "更改选定员工的班次";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(124, 22);
            this.toolStripButton6.Text = "选定员工自动排班";
            this.toolStripButton6.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton7.Text = "一周为同一班次";
            this.toolStripButton7.Click += new System.EventHandler(this.ToolStripButton7_Click);
            // 
            // BtnSaveShift
            // 
            this.BtnSaveShift.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnSaveShift.Enabled = false;
            this.BtnSaveShift.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveShift.Image")));
            this.BtnSaveShift.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveShift.Name = "BtnSaveShift";
            this.BtnSaveShift.Size = new System.Drawing.Size(36, 22);
            this.BtnSaveShift.Text = "保存";
            this.BtnSaveShift.Click += new System.EventHandler(this.BtnSaveShift_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.d1b);
            this.tabPage2.Controls.Add(this.d1a);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1445, 801);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "考勤调整工具";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(898, 289);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(245, 43);
            this.button7.TabIndex = 23;
            this.button7.Text = "数据库修复";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(898, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(245, 43);
            this.button6.TabIndex = 22;
            this.button6.Text = "姓名乱码修正";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.sc);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.d4a);
            this.groupBox6.Controls.Add(this.d4t1);
            this.groupBox6.Controls.Add(this.d4t2);
            this.groupBox6.Location = new System.Drawing.Point(898, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(487, 110);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "删除操作";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(19, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "日期";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(131, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "小于";
            // 
            // sc
            // 
            this.sc.BackColor = System.Drawing.Color.Transparent;
            this.sc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sc.Location = new System.Drawing.Point(272, 21);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(75, 62);
            this.sc.TabIndex = 5;
            this.sc.Text = "删除";
            this.sc.UseVisualStyleBackColor = true;
            this.sc.Click += new System.EventHandler(this.Sc_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(18, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "大于";
            // 
            // d4a
            // 
            this.d4a.CausesValidation = false;
            this.d4a.Location = new System.Drawing.Point(74, 21);
            this.d4a.Name = "d4a";
            this.d4a.Size = new System.Drawing.Size(161, 21);
            this.d4a.TabIndex = 2;
            this.d4a.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // d4t1
            // 
            this.d4t1.CausesValidation = false;
            this.d4t1.CustomFormat = "hh:mm";
            this.d4t1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.d4t1.Location = new System.Drawing.Point(53, 57);
            this.d4t1.Name = "d4t1";
            this.d4t1.ShowUpDown = true;
            this.d4t1.Size = new System.Drawing.Size(72, 21);
            this.d4t1.TabIndex = 6;
            this.d4t1.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // d4t2
            // 
            this.d4t2.CausesValidation = false;
            this.d4t2.CustomFormat = "hh:mm";
            this.d4t2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.d4t2.Location = new System.Drawing.Point(166, 57);
            this.d4t2.Name = "d4t2";
            this.d4t2.ShowUpDown = true;
            this.d4t2.Size = new System.Drawing.Size(72, 21);
            this.d4t2.TabIndex = 6;
            this.d4t2.Value = new System.DateTime(2014, 10, 20, 23, 59, 59, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delAttInfoDataGridView);
            this.panel1.Controls.Add(this.bindingNavigator2);
            this.panel1.Location = new System.Drawing.Point(17, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 573);
            this.panel1.TabIndex = 20;
            // 
            // delAttInfoDataGridView
            // 
            this.delAttInfoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.delAttInfoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.delAttInfoDataGridView.AutoGenerateColumns = false;
            this.delAttInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.delAttInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.delAttInfoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delAttInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.delAttInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delAttInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.delAttInfoDataGridView.DataSource = this.delAttInfoBindingSource;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.delAttInfoDataGridView.DefaultCellStyle = dataGridViewCellStyle25;
            this.delAttInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delAttInfoDataGridView.EnableHeadersVisualStyles = false;
            this.delAttInfoDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delAttInfoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.delAttInfoDataGridView.Name = "delAttInfoDataGridView";
            this.delAttInfoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.delAttInfoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.delAttInfoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.delAttInfoDataGridView.RowTemplate.Height = 23;
            this.delAttInfoDataGridView.Size = new System.Drawing.Size(806, 548);
            this.delAttInfoDataGridView.TabIndex = 2;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton4;
            this.bindingNavigator2.BindingSource = this.delAttInfoBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator2.DeleteItem = this.toolStripButton5;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton8});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator2.Size = new System.Drawing.Size(806, 25);
            this.bindingNavigator2.TabIndex = 2;
            this.bindingNavigator2.Text = "bindingNavigator2";
            this.bindingNavigator2.RefreshItems += new System.EventHandler(this.bindingNavigator2_RefreshItems);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton8.Text = "清除";
            this.toolStripButton8.Click += new System.EventHandler(this.ToolStripButton8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(157, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "结束日期";
            // 
            // d1b
            // 
            this.d1b.CausesValidation = false;
            this.d1b.Location = new System.Drawing.Point(240, 38);
            this.d1b.Name = "d1b";
            this.d1b.Size = new System.Drawing.Size(161, 21);
            this.d1b.TabIndex = 16;
            this.d1b.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // d1a
            // 
            this.d1a.CausesValidation = false;
            this.d1a.Location = new System.Drawing.Point(240, 10);
            this.d1a.Name = "d1a";
            this.d1a.Size = new System.Drawing.Size(161, 21);
            this.d1a.TabIndex = 17;
            this.d1a.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(157, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "开始日期";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 21);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "2010";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "基本工资";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(708, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 33);
            this.button4.TabIndex = 13;
            this.button4.Text = "开始调整";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(17, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 33);
            this.button5.TabIndex = 12;
            this.button5.Text = "打开考勤调整表";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "OutF", true));
            this.numericUpDown6.Location = new System.Drawing.Point(79, 146);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown6.TabIndex = 18;
            this.numericUpDown6.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkModifyBindingSource, "OutF", true));
            this.numericUpDown5.Location = new System.Drawing.Point(79, 120);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown5.TabIndex = 16;
            this.numericUpDown5.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xlsx";
            this.saveFileDialog1.FileName = "考勤表";
            this.saveFileDialog1.Filter = "Excel文件(*.xlsx)|*.xlsx";
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // deptNameDataGridViewTextBoxColumn1
            // 
            this.deptNameDataGridViewTextBoxColumn1.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn1.HeaderText = "部门";
            this.deptNameDataGridViewTextBoxColumn1.Name = "deptNameDataGridViewTextBoxColumn1";
            this.deptNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.deptNameDataGridViewTextBoxColumn1.Width = 60;
            // 
            // workTimeDataGridViewTextBoxColumn
            // 
            this.workTimeDataGridViewTextBoxColumn.DataPropertyName = "WorkTime";
            this.workTimeDataGridViewTextBoxColumn.HeaderText = "平日工作";
            this.workTimeDataGridViewTextBoxColumn.Name = "workTimeDataGridViewTextBoxColumn";
            this.workTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.workTimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // overTimeDataGridViewTextBoxColumn
            // 
            this.overTimeDataGridViewTextBoxColumn.DataPropertyName = "OverTime";
            this.overTimeDataGridViewTextBoxColumn.HeaderText = "平日加班";
            this.overTimeDataGridViewTextBoxColumn.Name = "overTimeDataGridViewTextBoxColumn";
            this.overTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.overTimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // hollydayTimeDataGridViewTextBoxColumn
            // 
            this.hollydayTimeDataGridViewTextBoxColumn.DataPropertyName = "HollydayTime";
            this.hollydayTimeDataGridViewTextBoxColumn.HeaderText = "假日加班";
            this.hollydayTimeDataGridViewTextBoxColumn.Name = "hollydayTimeDataGridViewTextBoxColumn";
            this.hollydayTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hollydayTimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // restdayTimeDataGridViewTextBoxColumn
            // 
            this.restdayTimeDataGridViewTextBoxColumn.DataPropertyName = "RestdayTime";
            this.restdayTimeDataGridViewTextBoxColumn.HeaderText = "休息日加班";
            this.restdayTimeDataGridViewTextBoxColumn.Name = "restdayTimeDataGridViewTextBoxColumn";
            this.restdayTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.restdayTimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // totalTimeDataGridViewTextBoxColumn
            // 
            this.totalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.HeaderText = "总工时";
            this.totalTimeDataGridViewTextBoxColumn.Name = "totalTimeDataGridViewTextBoxColumn";
            this.totalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalTimeDataGridViewTextBoxColumn.Width = 70;
            // 
            // firstCheckDateDataGridViewTextBoxColumn
            // 
            this.firstCheckDateDataGridViewTextBoxColumn.DataPropertyName = "FirstCheckDate";
            this.firstCheckDateDataGridViewTextBoxColumn.HeaderText = "首次打卡日";
            this.firstCheckDateDataGridViewTextBoxColumn.Name = "firstCheckDateDataGridViewTextBoxColumn";
            this.firstCheckDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstCheckDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // empCheckMonthBindingSource
            // 
            this.empCheckMonthBindingSource.DataSource = typeof(考勤调整.EmpCheckMonth);
            // 
            // checkDateDataGridViewTextBoxColumn
            // 
            this.checkDateDataGridViewTextBoxColumn.DataPropertyName = "CheckDate";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.checkDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.checkDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.checkDateDataGridViewTextBoxColumn.Name = "checkDateDataGridViewTextBoxColumn";
            this.checkDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkDateDataGridViewTextBoxColumn.Width = 60;
            // 
            // dayTypeDataGridViewTextBoxColumn
            // 
            this.dayTypeDataGridViewTextBoxColumn.DataPropertyName = "DayType";
            this.dayTypeDataGridViewTextBoxColumn.HeaderText = "类型";
            this.dayTypeDataGridViewTextBoxColumn.Name = "dayTypeDataGridViewTextBoxColumn";
            this.dayTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayTypeDataGridViewTextBoxColumn.Width = 60;
            // 
            // firstAmendDataGridViewTextBoxColumn
            // 
            this.firstAmendDataGridViewTextBoxColumn.DataPropertyName = "FirstAmend";
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.firstAmendDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.firstAmendDataGridViewTextBoxColumn.HeaderText = "首次打卡修正";
            this.firstAmendDataGridViewTextBoxColumn.Name = "firstAmendDataGridViewTextBoxColumn";
            this.firstAmendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastAmendDataGridViewTextBoxColumn
            // 
            this.lastAmendDataGridViewTextBoxColumn.DataPropertyName = "LastAmend";
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            this.lastAmendDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.lastAmendDataGridViewTextBoxColumn.HeaderText = "末次打卡修正";
            this.lastAmendDataGridViewTextBoxColumn.Name = "lastAmendDataGridViewTextBoxColumn";
            this.lastAmendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workTimeDataGridViewTextBoxColumn1
            // 
            this.workTimeDataGridViewTextBoxColumn1.DataPropertyName = "WorkTime";
            this.workTimeDataGridViewTextBoxColumn1.HeaderText = "工作时间";
            this.workTimeDataGridViewTextBoxColumn1.Name = "workTimeDataGridViewTextBoxColumn1";
            this.workTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // overTimeDataGridViewTextBoxColumn1
            // 
            this.overTimeDataGridViewTextBoxColumn1.DataPropertyName = "OverTime";
            this.overTimeDataGridViewTextBoxColumn1.HeaderText = "加班时间";
            this.overTimeDataGridViewTextBoxColumn1.Name = "overTimeDataGridViewTextBoxColumn1";
            this.overTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalTimeDataGridViewTextBoxColumn1
            // 
            this.totalTimeDataGridViewTextBoxColumn1.DataPropertyName = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn1.HeaderText = "工时";
            this.totalTimeDataGridViewTextBoxColumn1.Name = "totalTimeDataGridViewTextBoxColumn1";
            this.totalTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // allTimeDataGridViewTextBoxColumn
            // 
            this.allTimeDataGridViewTextBoxColumn.DataPropertyName = "AllTime";
            this.allTimeDataGridViewTextBoxColumn.HeaderText = "出勤时间";
            this.allTimeDataGridViewTextBoxColumn.Name = "allTimeDataGridViewTextBoxColumn";
            this.allTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empCheckDayBindingSource
            // 
            this.empCheckDayBindingSource.DataSource = typeof(考勤调整.EmpCheckDay);
            // 
            // checkModifyBindingSource
            // 
            this.checkModifyBindingSource.DataSource = typeof(考勤调整.CheckModify);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ShiftName";
            this.dataGridViewTextBoxColumn2.HeaderText = "班次名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AmCheckIn";
            dataGridViewCellStyle15.Format = "t";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn3.HeaderText = "AM上";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AmcheckOut";
            dataGridViewCellStyle16.Format = "t";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn4.HeaderText = "AM下";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PmCheckIn";
            dataGridViewCellStyle17.Format = "t";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn5.HeaderText = "PM上";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PmCheckOut";
            dataGridViewCellStyle18.Format = "t";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn6.HeaderText = "PM下";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OTCheckIn";
            dataGridViewCellStyle19.Format = "t";
            dataGridViewCellStyle19.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn7.HeaderText = "OT上";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OTCheckOut";
            dataGridViewCellStyle20.Format = "t";
            dataGridViewCellStyle20.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn8.HeaderText = "OT下";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataSource = typeof(考勤调整.Shift);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LowGz";
            this.dataGridViewTextBoxColumn10.HeaderText = "最低工资";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Money";
            this.dataGridViewTextBoxColumn11.HeaderText = "金额";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Hours";
            this.dataGridViewTextBoxColumn12.HeaderText = "拆合小时数";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ReHours";
            this.dataGridViewTextBoxColumn13.HeaderText = "调整小时";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // delAttInfoBindingSource
            // 
            this.delAttInfoBindingSource.DataSource = typeof(考勤调整.DelAttInfo);
            // 
            // AttEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 857);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤调整";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttEdit_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayDgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearHoliday)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bigeweektime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbbc.ResumeLayout(false);
            this.gbbc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delAttInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCheckMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empCheckDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkModifyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delAttInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource empCheckMonthBindingSource;
        private System.Windows.Forms.BindingSource empCheckDayBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tool_con;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_LoadData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btn_SyncCheck;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbbc;
        private System.Windows.Forms.BindingSource shiftBindingSource;
        private System.Windows.Forms.ToolStripProgressBar Pb;
        private System.Windows.Forms.ToolStripButton BtnWriteToDb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.BindingSource checkModifyBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewCheckRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstAmendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAmendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn overTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn allTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown bigeweektime;
        private System.Windows.Forms.ToolStripComboBox modeselect;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown YearHoliday;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker d4a;
        private System.Windows.Forms.DateTimePicker d4t1;
        private System.Windows.Forms.DateTimePicker d4t2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker d1b;
        private System.Windows.Forms.DateTimePicker d1a;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource delAttInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hollydayTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restdayTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BigWeekHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstCheckDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton BtnAddShift;
        private System.Windows.Forms.ToolStripButton BtnDeleteShift;
        private System.Windows.Forms.ToolStripButton BtnEditShift;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton BtnSaveShift;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private Button button5;
        private Button button1;
        private Button BtnBuildCheck;
        private Button button2;
        private Button button3;
        private Button sc;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button SaveEmpShifts;
        private DataGridView empDgv;
        private DataGridView dayDgv;
        private DataGridView shiftdgv;
        private DataGridView delAttInfoDataGridView;
        private SplitContainer splitContainer3;
        private ToolStripButton toolStripButton9;
        private ToolStripSeparator toolStripSeparator6;
        private Button button9;
        private Button button10;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
    }
}


namespace GUI
{
    partial class frmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numLocTang = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radConguoi = new System.Windows.Forms.RadioButton();
            this.radRepair = new System.Windows.Forms.RadioButton();
            this.radTrong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gbInfoTable = new System.Windows.Forms.GroupBox();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocTang)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbInfoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(635, 47);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc theo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(13, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 178);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numLocTang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radConguoi);
            this.groupBox1.Controls.Add(this.radRepair);
            this.groupBox1.Controls.Add(this.radTrong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // numLocTang
            // 
            this.numLocTang.Location = new System.Drawing.Point(125, 75);
            this.numLocTang.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLocTang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLocTang.Name = "numLocTang";
            this.numLocTang.Size = new System.Drawing.Size(429, 30);
            this.numLocTang.TabIndex = 8;
            this.numLocTang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLocTang.ValueChanged += new System.EventHandler(this.numLocTang_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tầng:";
            // 
            // radConguoi
            // 
            this.radConguoi.AutoSize = true;
            this.radConguoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radConguoi.Location = new System.Drawing.Point(295, 30);
            this.radConguoi.Name = "radConguoi";
            this.radConguoi.Size = new System.Drawing.Size(101, 27);
            this.radConguoi.TabIndex = 6;
            this.radConguoi.Text = "Có người";
            this.radConguoi.UseVisualStyleBackColor = true;
            this.radConguoi.CheckedChanged += new System.EventHandler(this.radConguoi_CheckedChanged);
            // 
            // radRepair
            // 
            this.radRepair.AutoSize = true;
            this.radRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radRepair.Location = new System.Drawing.Point(453, 30);
            this.radRepair.Name = "radRepair";
            this.radRepair.Size = new System.Drawing.Size(101, 27);
            this.radRepair.TabIndex = 7;
            this.radRepair.Text = "Sửa chữa";
            this.radRepair.UseVisualStyleBackColor = true;
            this.radRepair.CheckedChanged += new System.EventHandler(this.radRepair_CheckedChanged);
            // 
            // radTrong
            // 
            this.radTrong.AutoSize = true;
            this.radTrong.BackColor = System.Drawing.SystemColors.Window;
            this.radTrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radTrong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radTrong.Location = new System.Drawing.Point(125, 30);
            this.radTrong.Name = "radTrong";
            this.radTrong.Size = new System.Drawing.Size(116, 28);
            this.radTrong.TabIndex = 5;
            this.radTrong.Text = "Bàn trống";
            this.radTrong.UseVisualStyleBackColor = false;
            this.radTrong.CheckedChanged += new System.EventHandler(this.radTrong_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 878);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(35, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1603, 273);
            this.panel3.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(499, 206);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(155, 49);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(334, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(155, 49);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "    Xoá";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel8.Controls.Add(this.label4);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(678, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(901, 47);
            this.panel8.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông tin bàn";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(3, 206);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(155, 49);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "  Thêm";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(169, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(155, 49);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "    Sửa ";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.gbInfoTable);
            this.panel6.Location = new System.Drawing.Point(688, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(903, 165);
            this.panel6.TabIndex = 17;
            // 
            // gbInfoTable
            // 
            this.gbInfoTable.Controls.Add(this.numFloor);
            this.gbInfoTable.Controls.Add(this.cbStatus);
            this.gbInfoTable.Controls.Add(this.txtName);
            this.gbInfoTable.Controls.Add(this.txtID);
            this.gbInfoTable.Controls.Add(this.label8);
            this.gbInfoTable.Controls.Add(this.label7);
            this.gbInfoTable.Controls.Add(this.label6);
            this.gbInfoTable.Controls.Add(this.label5);
            this.gbInfoTable.Location = new System.Drawing.Point(7, 45);
            this.gbInfoTable.Name = "gbInfoTable";
            this.gbInfoTable.Size = new System.Drawing.Size(890, 114);
            this.gbInfoTable.TabIndex = 0;
            this.gbInfoTable.TabStop = false;
            // 
            // numFloor
            // 
            this.numFloor.Location = new System.Drawing.Point(559, 69);
            this.numFloor.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(306, 30);
            this.numFloor.TabIndex = 2;
            this.numFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(559, 26);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(306, 31);
            this.cbStatus.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 30);
            this.txtName.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(106, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(350, 30);
            this.txtID.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tầng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã bàn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên bàn:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.txtSearch);
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Location = new System.Drawing.Point(678, 19);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(913, 56);
            this.panel9.TabIndex = 21;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(6, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(836, 23);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(857, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvTable);
            this.panel4.Controls.Add(this.flowTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(35, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1603, 605);
            this.panel4.TabIndex = 8;
            // 
            // dtgvTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTable.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvTable.Location = new System.Drawing.Point(688, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersVisible = false;
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(902, 568);
            this.dtgvTable.TabIndex = 1;
            this.dtgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTable_CellClick);
            // 
            // flowTable
            // 
            this.flowTable.AutoScroll = true;
            this.flowTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowTable.Location = new System.Drawing.Point(0, 0);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(683, 605);
            this.flowTable.TabIndex = 0;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 878);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTable";
            this.Text = "BÀN";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocTang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.gbInfoTable.ResumeLayout(false);
            this.gbInfoTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRepair;
        private System.Windows.Forms.RadioButton radTrong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton radConguoi;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox gbInfoTable;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.FlowLayoutPanel flowTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.NumericUpDown numLocTang;
    }
}
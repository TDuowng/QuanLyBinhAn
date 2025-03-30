namespace GUI
{
    partial class frmIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngredients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIngredient = new System.Windows.Forms.ComboBox();
            this.cbProvide = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoHetHang = new System.Windows.Forms.RadioButton();
            this.rdoTonKhoThap = new System.Windows.Forms.RadioButton();
            this.rdoConHang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpkOverDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIdIngredient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.dtgvIngredients = new System.Windows.Forms.DataGridView();
            this.numCountTon = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 47);
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
            this.panel2.Location = new System.Drawing.Point(16, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 248);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbIngredient);
            this.groupBox1.Controls.Add(this.cbProvide);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdoHetHang);
            this.groupBox1.Controls.Add(this.rdoTonKhoThap);
            this.groupBox1.Controls.Add(this.rdoConHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Công thức:";
            // 
            // cbIngredient
            // 
            this.cbIngredient.FormattingEnabled = true;
            this.cbIngredient.Location = new System.Drawing.Point(167, 135);
            this.cbIngredient.Name = "cbIngredient";
            this.cbIngredient.Size = new System.Drawing.Size(370, 31);
            this.cbIngredient.TabIndex = 3;
            this.cbIngredient.SelectedIndexChanged += new System.EventHandler(this.cbIngredient_SelectedIndexChanged);
            // 
            // cbProvide
            // 
            this.cbProvide.FormattingEnabled = true;
            this.cbProvide.Location = new System.Drawing.Point(167, 87);
            this.cbProvide.Name = "cbProvide";
            this.cbProvide.Size = new System.Drawing.Size(370, 31);
            this.cbProvide.TabIndex = 3;
            this.cbProvide.SelectedIndexChanged += new System.EventHandler(this.cbProvide_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // rdoHetHang
            // 
            this.rdoHetHang.AutoSize = true;
            this.rdoHetHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHetHang.Location = new System.Drawing.Point(288, 42);
            this.rdoHetHang.Name = "rdoHetHang";
            this.rdoHetHang.Size = new System.Drawing.Size(102, 27);
            this.rdoHetHang.TabIndex = 1;
            this.rdoHetHang.Text = "Hết hàng";
            this.rdoHetHang.UseVisualStyleBackColor = true;
            this.rdoHetHang.CheckedChanged += new System.EventHandler(this.rdoHetHang_CheckedChanged);
            // 
            // rdoTonKhoThap
            // 
            this.rdoTonKhoThap.AutoSize = true;
            this.rdoTonKhoThap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTonKhoThap.Location = new System.Drawing.Point(404, 43);
            this.rdoTonKhoThap.Name = "rdoTonKhoThap";
            this.rdoTonKhoThap.Size = new System.Drawing.Size(133, 27);
            this.rdoTonKhoThap.TabIndex = 1;
            this.rdoTonKhoThap.Text = "Tồn kho thấp";
            this.rdoTonKhoThap.UseVisualStyleBackColor = true;
            this.rdoTonKhoThap.CheckedChanged += new System.EventHandler(this.rdoTonKhoThap_CheckedChanged);
            // 
            // rdoConHang
            // 
            this.rdoConHang.AutoSize = true;
            this.rdoConHang.BackColor = System.Drawing.SystemColors.Window;
            this.rdoConHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoConHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdoConHang.Location = new System.Drawing.Point(167, 42);
            this.rdoConHang.Name = "rdoConHang";
            this.rdoConHang.Size = new System.Drawing.Size(115, 28);
            this.rdoConHang.TabIndex = 1;
            this.rdoConHang.Text = "Còn hàng";
            this.rdoConHang.UseVisualStyleBackColor = false;
            this.rdoConHang.CheckedChanged += new System.EventHandler(this.rdoConHang_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
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
            this.panel1.Size = new System.Drawing.Size(35, 865);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(35, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1603, 102);
            this.panel3.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.textBox4);
            this.panel9.Controls.Add(this.button5);
            this.panel9.Location = new System.Drawing.Point(6, 26);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(888, 56);
            this.panel9.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(62, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(823, 23);
            this.textBox4.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 56);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = false;
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
            this.btnDelete.Location = new System.Drawing.Point(1256, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(158, 56);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "     Xoá";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(1087, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(158, 56);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "    Sửa";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(1425, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(158, 56);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "   Làm mới";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(918, 26);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(158, 56);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "   Thêm";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(6, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(572, 47);
            this.panel4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin nguyên liệu";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(16, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(581, 506);
            this.panel6.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCountTon);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpkOverDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbUnit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numPrice);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtIdIngredient);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(9, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 458);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(167, 381);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(370, 30);
            this.txtNote.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ghi chú:";
            // 
            // dtpkOverDate
            // 
            this.dtpkOverDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkOverDate.Location = new System.Drawing.Point(167, 328);
            this.dtpkOverDate.Name = "dtpkOverDate";
            this.dtpkOverDate.Size = new System.Drawing.Size(370, 30);
            this.dtpkOverDate.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày quá hạn:";
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(167, 217);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(370, 31);
            this.cbUnit.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Đơn vị tính:";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(167, 164);
            this.numPrice.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(370, 30);
            this.numPrice.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 30);
            this.txtName.TabIndex = 0;
            // 
            // txtIdIngredient
            // 
            this.txtIdIngredient.Location = new System.Drawing.Point(167, 45);
            this.txtIdIngredient.Name = "txtIdIngredient";
            this.txtIdIngredient.ReadOnly = true;
            this.txtIdIngredient.Size = new System.Drawing.Size(370, 30);
            this.txtIdIngredient.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn giá nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên nguyên liệu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã nguyên liệu:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(35, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(606, 763);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.numMonth);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.btnPrint);
            this.panel8.Controls.Add(this.btnThongke);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(641, 102);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(997, 72);
            this.panel8.TabIndex = 11;
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(434, 25);
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(93, 30);
            this.numMonth.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(533, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 28);
            this.label13.TabIndex = 33;
            this.label13.Text = "tháng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 28);
            this.label12.TabIndex = 33;
            this.label12.Text = "Xem nguyên liệu sắp hết hạn trong vòng";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(819, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(158, 42);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "      In ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnThongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(650, 19);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongke.Size = new System.Drawing.Size(158, 42);
            this.btnThongke.TabIndex = 30;
            this.btnThongke.Text = "  Thống kê";
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // dtgvIngredients
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvIngredients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dtgvIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvIngredients.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvIngredients.GridColor = System.Drawing.Color.White;
            this.dtgvIngredients.Location = new System.Drawing.Point(647, 180);
            this.dtgvIngredients.Name = "dtgvIngredients";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIngredients.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvIngredients.RowHeadersVisible = false;
            this.dtgvIngredients.RowHeadersWidth = 51;
            this.dtgvIngredients.RowTemplate.Height = 24;
            this.dtgvIngredients.Size = new System.Drawing.Size(971, 623);
            this.dtgvIngredients.TabIndex = 12;
            this.dtgvIngredients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvIngredients_CellClick);
            // 
            // numCountTon
            // 
            this.numCountTon.Location = new System.Drawing.Point(167, 272);
            this.numCountTon.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numCountTon.Name = "numCountTon";
            this.numCountTon.Size = new System.Drawing.Size(370, 30);
            this.numCountTon.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 23);
            this.label14.TabIndex = 13;
            this.label14.Text = "Số lượng tồn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1232, 822);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "Tổng số nguyên liệu:";
            // 
            // numCount
            // 
            this.numCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCount.Location = new System.Drawing.Point(1415, 821);
            this.numCount.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.ReadOnly = true;
            this.numCount.Size = new System.Drawing.Size(120, 26);
            this.numCount.TabIndex = 14;
            this.numCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 865);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtgvIngredients);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIngredients";
            this.Text = "NGUYÊN LIỆU";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIngredient;
        private System.Windows.Forms.ComboBox cbProvide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoHetHang;
        private System.Windows.Forms.RadioButton rdoTonKhoThap;
        private System.Windows.Forms.RadioButton rdoConHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdIngredient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpkOverDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgvIngredients;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown numCountTon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numCount;
    }
}
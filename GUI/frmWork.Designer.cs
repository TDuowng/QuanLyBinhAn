namespace GUI
{
    partial class frmWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWork));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpkDateIn = new System.Windows.Forms.DateTimePicker();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.numCountHour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdWord = new System.Windows.Forms.TextBox();
            this.txtNameWork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertWork = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateWork = new System.Windows.Forms.Button();
            this.btnDeleteWork = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvWork = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountHour)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 45);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "CA LÀM VIỆC";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(574, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpkDateOut);
            this.groupBox1.Controls.Add(this.dtpkDateIn);
            this.groupBox1.Controls.Add(this.numSalary);
            this.groupBox1.Controls.Add(this.numCountHour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdWord);
            this.groupBox1.Controls.Add(this.txtNameWork);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ca làm việc";
            // 
            // dtpkDateOut
            // 
            this.dtpkDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkDateOut.Location = new System.Drawing.Point(384, 69);
            this.dtpkDateOut.Name = "dtpkDateOut";
            this.dtpkDateOut.ShowUpDown = true;
            this.dtpkDateOut.Size = new System.Drawing.Size(190, 30);
            this.dtpkDateOut.TabIndex = 2;
            this.dtpkDateOut.ValueChanged += new System.EventHandler(this.dtpkDateOut_ValueChanged);
            // 
            // dtpkDateIn
            // 
            this.dtpkDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkDateIn.Location = new System.Drawing.Point(384, 30);
            this.dtpkDateIn.Name = "dtpkDateIn";
            this.dtpkDateIn.ShowUpDown = true;
            this.dtpkDateIn.Size = new System.Drawing.Size(190, 30);
            this.dtpkDateIn.TabIndex = 1;
            this.dtpkDateIn.ValueChanged += new System.EventHandler(this.dtpkDateIn_ValueChanged);
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(384, 107);
            this.numSalary.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(190, 30);
            this.numSalary.TabIndex = 3;
            // 
            // numCountHour
            // 
            this.numCountHour.DecimalPlaces = 2;
            this.numCountHour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCountHour.Location = new System.Drawing.Point(94, 110);
            this.numCountHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numCountHour.Name = "numCountHour";
            this.numCountHour.ReadOnly = true;
            this.numCountHour.Size = new System.Drawing.Size(174, 30);
            this.numCountHour.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mức lương:";
            // 
            // txtIdWord
            // 
            this.txtIdWord.Location = new System.Drawing.Point(94, 32);
            this.txtIdWord.Name = "txtIdWord";
            this.txtIdWord.ReadOnly = true;
            this.txtIdWord.Size = new System.Drawing.Size(174, 30);
            this.txtIdWord.TabIndex = 8;
            // 
            // txtNameWork
            // 
            this.txtNameWork.Location = new System.Drawing.Point(94, 70);
            this.txtNameWork.Name = "txtNameWork";
            this.txtNameWork.Size = new System.Drawing.Size(174, 30);
            this.txtNameWork.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số giờ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên ca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ca:";
            // 
            // btnInsertWork
            // 
            this.btnInsertWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnInsertWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertWork.FlatAppearance.BorderSize = 0;
            this.btnInsertWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertWork.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertWork.ForeColor = System.Drawing.Color.White;
            this.btnInsertWork.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertWork.Image")));
            this.btnInsertWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertWork.Location = new System.Drawing.Point(36, 217);
            this.btnInsertWork.Name = "btnInsertWork";
            this.btnInsertWork.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInsertWork.Size = new System.Drawing.Size(130, 40);
            this.btnInsertWork.TabIndex = 4;
            this.btnInsertWork.Text = " Thêm";
            this.btnInsertWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertWork.UseVisualStyleBackColor = false;
            this.btnInsertWork.Click += new System.EventHandler(this.btnInsertWork_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(444, 217);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdateWork
            // 
            this.btnUpdateWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnUpdateWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateWork.FlatAppearance.BorderSize = 0;
            this.btnUpdateWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWork.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWork.ForeColor = System.Drawing.Color.White;
            this.btnUpdateWork.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateWork.Image")));
            this.btnUpdateWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWork.Location = new System.Drawing.Point(172, 217);
            this.btnUpdateWork.Name = "btnUpdateWork";
            this.btnUpdateWork.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdateWork.Size = new System.Drawing.Size(130, 40);
            this.btnUpdateWork.TabIndex = 5;
            this.btnUpdateWork.Text = "  Sửa";
            this.btnUpdateWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateWork.UseVisualStyleBackColor = false;
            this.btnUpdateWork.Click += new System.EventHandler(this.btnUpdateWork_Click);
            // 
            // btnDeleteWork
            // 
            this.btnDeleteWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnDeleteWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteWork.FlatAppearance.BorderSize = 0;
            this.btnDeleteWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWork.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWork.ForeColor = System.Drawing.Color.White;
            this.btnDeleteWork.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteWork.Image")));
            this.btnDeleteWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteWork.Location = new System.Drawing.Point(308, 217);
            this.btnDeleteWork.Name = "btnDeleteWork";
            this.btnDeleteWork.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeleteWork.Size = new System.Drawing.Size(130, 40);
            this.btnDeleteWork.TabIndex = 6;
            this.btnDeleteWork.Text = "  Xoá";
            this.btnDeleteWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteWork.UseVisualStyleBackColor = false;
            this.btnDeleteWork.Click += new System.EventHandler(this.btnDeleteWork_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvWork);
            this.groupBox2.Location = new System.Drawing.Point(10, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 258);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // dtgvWork
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvWork.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvWork.BackgroundColor = System.Drawing.Color.White;
            this.dtgvWork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvWork.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvWork.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgvWork.Location = new System.Drawing.Point(5, 15);
            this.dtgvWork.Name = "dtgvWork";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvWork.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvWork.RowHeadersVisible = false;
            this.dtgvWork.RowHeadersWidth = 51;
            this.dtgvWork.RowTemplate.Height = 24;
            this.dtgvWork.Size = new System.Drawing.Size(586, 237);
            this.dtgvWork.TabIndex = 0;
            this.dtgvWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvWork_CellClick);
            // 
            // frmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDeleteWork);
            this.Controls.Add(this.btnUpdateWork);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsertWork);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWork";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountHour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkDateOut;
        private System.Windows.Forms.DateTimePicker dtpkDateIn;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.NumericUpDown numCountHour;
        private System.Windows.Forms.TextBox txtIdWord;
        private System.Windows.Forms.TextBox txtNameWork;
        private System.Windows.Forms.Button btnInsertWork;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateWork;
        private System.Windows.Forms.Button btnDeleteWork;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvWork;
        private System.Windows.Forms.Label label7;
    }
}
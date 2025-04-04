namespace GUI
{
    partial class frmTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTargetTable = new System.Windows.Forms.ComboBox();
            this.nmrDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.btnMergeTables = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.nmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerFood = new System.Timers.Timer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerFood)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 52);
            this.panel2.TabIndex = 2;
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.button6);
            this.panelSideBar.Controls.Add(this.btnAdmin);
            this.panelSideBar.Controls.Add(this.btnTable);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 103);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(228, 880);
            this.panelSideBar.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 120);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(228, 60);
            this.button6.TabIndex = 9;
            this.button6.Text = "   ĐĂNG XUẤT";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 60);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(228, 60);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "  QUẢN LÝ";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTable.Image = ((System.Drawing.Image)(resources.GetObject("btnTable.Image")));
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(0, 0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTable.Size = new System.Drawing.Size(228, 60);
            this.btnTable.TabIndex = 5;
            this.btnTable.Text = "   BÀN ĂN";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(228, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1696, 880);
            this.panel4.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(1228, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(468, 949);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lsvBill);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(439, 857);
            this.panel8.TabIndex = 0;
            // 
            // lsvBill
            // 
            this.lsvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(14, 153);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(402, 433);
            this.lsvBill.TabIndex = 6;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 146;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.lblFinalPrice);
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.lblDiscountAmount);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.txtTotalPrice);
            this.panel9.Controls.Add(this.btnCheckout);
            this.panel9.Controls.Add(this.lblTotal);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(14, 592);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(415, 252);
            this.panel9.TabIndex = 5;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblFinalPrice.Location = new System.Drawing.Point(235, 115);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(0, 32);
            this.lblFinalPrice.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(121)))), ((int)(((byte)(122)))));
            this.pictureBox1.Location = new System.Drawing.Point(15, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 1);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.label7.Location = new System.Drawing.Point(11, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tổng tiền";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.lblDiscountAmount.Location = new System.Drawing.Point(255, 62);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(0, 25);
            this.lblDiscountAmount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giảm giá";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(215, 16);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(0, 41);
            this.txtTotalPrice.TabIndex = 6;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(13, 175);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(392, 63);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.lblTotal.Location = new System.Drawing.Point(254, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(85)))), ((int)(((byte)(118)))));
            this.button1.Location = new System.Drawing.Point(291, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xoá hết";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoá đơn hiện tại";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvFood);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.flowTable);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(24, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1204, 880);
            this.panel6.TabIndex = 1;
            // 
            // dgvFood
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.Color.White;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvFood.GridColor = System.Drawing.Color.White;
            this.dgvFood.Location = new System.Drawing.Point(3, 88);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(514, 639);
            this.dgvFood.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.cboTargetTable);
            this.panel5.Controls.Add(this.nmrDiscount);
            this.panel5.Controls.Add(this.btnSwitchTable);
            this.panel5.Controls.Add(this.btnMergeTables);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 739);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(514, 124);
            this.panel5.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(471, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "(%)";
            // 
            // cboTargetTable
            // 
            this.cboTargetTable.FormattingEnabled = true;
            this.cboTargetTable.Location = new System.Drawing.Point(16, 72);
            this.cboTargetTable.Name = "cboTargetTable";
            this.cboTargetTable.Size = new System.Drawing.Size(356, 31);
            this.cboTargetTable.TabIndex = 11;
            // 
            // nmrDiscount
            // 
            this.nmrDiscount.Location = new System.Drawing.Point(390, 73);
            this.nmrDiscount.Name = "nmrDiscount";
            this.nmrDiscount.Size = new System.Drawing.Size(78, 30);
            this.nmrDiscount.TabIndex = 10;
            this.nmrDiscount.ValueChanged += new System.EventHandler(this.nmrDiscount_ValueChanged);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnSwitchTable.FlatAppearance.BorderSize = 0;
            this.btnSwitchTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSwitchTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchTable.Image")));
            this.btnSwitchTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitchTable.Location = new System.Drawing.Point(197, 15);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSwitchTable.Size = new System.Drawing.Size(175, 46);
            this.btnSwitchTable.TabIndex = 9;
            this.btnSwitchTable.Text = " Chuyển bàn";
            this.btnSwitchTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitchTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // btnMergeTables
            // 
            this.btnMergeTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnMergeTables.FlatAppearance.BorderSize = 0;
            this.btnMergeTables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMergeTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMergeTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeTables.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMergeTables.Image = ((System.Drawing.Image)(resources.GetObject("btnMergeTables.Image")));
            this.btnMergeTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMergeTables.Location = new System.Drawing.Point(16, 15);
            this.btnMergeTables.Name = "btnMergeTables";
            this.btnMergeTables.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMergeTables.Size = new System.Drawing.Size(175, 46);
            this.btnMergeTables.TabIndex = 9;
            this.btnMergeTables.Text = "  Gộp bàn";
            this.btnMergeTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMergeTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMergeTables.UseVisualStyleBackColor = false;
            this.btnMergeTables.Click += new System.EventHandler(this.btnMergeTables_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(391, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giảm giá";
            // 
            // flowTable
            // 
            this.flowTable.AutoScroll = true;
            this.flowTable.Location = new System.Drawing.Point(538, 88);
            this.flowTable.Name = "flowTable";
            this.flowTable.Size = new System.Drawing.Size(663, 877);
            this.flowTable.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboCategory);
            this.panel3.Controls.Add(this.nmrQuantity);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 82);
            this.panel3.TabIndex = 0;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(3, 6);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(339, 31);
            this.cboCategory.TabIndex = 22;
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.Location = new System.Drawing.Point(3, 41);
            this.nmrQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Size = new System.Drawing.Size(339, 30);
            this.nmrQuantity.TabIndex = 10;
            this.nmrQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.txtSearch);
            this.panel10.Controls.Add(this.btnSearchFood);
            this.panel10.Location = new System.Drawing.Point(538, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(663, 65);
            this.panel10.TabIndex = 21;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(14, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(582, 23);
            this.txtSearch.TabIndex = 15;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackColor = System.Drawing.Color.White;
            this.btnSearchFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchFood.FlatAppearance.BorderSize = 0;
            this.btnSearchFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.Image")));
            this.btnSearchFood.Location = new System.Drawing.Point(599, 0);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(64, 65);
            this.btnSearchFood.TabIndex = 14;
            this.btnSearchFood.UseVisualStyleBackColor = false;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(348, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddFood.Size = new System.Drawing.Size(169, 67);
            this.btnAddFood.TabIndex = 9;
            this.btnAddFood.Text = "  Thêm món";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(24, 880);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // timerFood
            // 
            this.timerFood.Enabled = true;
            this.timerFood.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1924, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 43);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(113, 43);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 51);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG TÀO PHỚ BÌNH AN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTableManager";
            this.Text = "frmTableManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerFood)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotal;
        private System.Timers.Timer timerFood;
        private System.Windows.Forms.FlowLayoutPanel flowTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnMergeTables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTargetTable;
        private System.Windows.Forms.NumericUpDown nmrDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
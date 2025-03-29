namespace GUI
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.btnBestSeller = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panelMaterial = new System.Windows.Forms.Panel();
            this.btnListMaterial = new System.Windows.Forms.Button();
            this.btnImportMaterial = new System.Windows.Forms.Button();
            this.btnProvide = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.btnListEmployee = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnAccumulatePoints = new System.Windows.Forms.Button();
            this.btnListCustomer = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.btnCook = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.panelMaterial.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 58);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG TÀO PHỚ BÌNH AN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1710, 56);
            this.panel2.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(1064, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelSideBar
            // 
            this.panelSideBar.AutoScroll = true;
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panelSideBar.Controls.Add(this.panelReport);
            this.panelSideBar.Controls.Add(this.btnReport);
            this.panelSideBar.Controls.Add(this.panelMaterial);
            this.panelSideBar.Controls.Add(this.btnMaterial);
            this.panelSideBar.Controls.Add(this.panelEmployee);
            this.panelSideBar.Controls.Add(this.btnEmployee);
            this.panelSideBar.Controls.Add(this.panelCustomer);
            this.panelSideBar.Controls.Add(this.btnCustomer);
            this.panelSideBar.Controls.Add(this.panelCategory);
            this.panelSideBar.Controls.Add(this.btnLogOut);
            this.panelSideBar.Controls.Add(this.btnCategory);
            this.panelSideBar.Controls.Add(this.btnAccount);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 114);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(270, 813);
            this.panelSideBar.TabIndex = 4;
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.SystemColors.Control;
            this.panelReport.Controls.Add(this.btnBestSeller);
            this.panelReport.Controls.Add(this.btnSell);
            this.panelReport.Controls.Add(this.btnDailyReport);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReport.Location = new System.Drawing.Point(0, 880);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(249, 150);
            this.panelReport.TabIndex = 16;
            // 
            // btnBestSeller
            // 
            this.btnBestSeller.BackColor = System.Drawing.Color.White;
            this.btnBestSeller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBestSeller.FlatAppearance.BorderSize = 0;
            this.btnBestSeller.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBestSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestSeller.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBestSeller.Image = global::GUI.Properties.Resources.playorange;
            this.btnBestSeller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestSeller.Location = new System.Drawing.Point(0, 100);
            this.btnBestSeller.Name = "btnBestSeller";
            this.btnBestSeller.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBestSeller.Size = new System.Drawing.Size(249, 50);
            this.btnBestSeller.TabIndex = 2;
            this.btnBestSeller.Text = "   Món ăn bán chạy";
            this.btnBestSeller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBestSeller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBestSeller.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.White;
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSell.Image = global::GUI.Properties.Resources.playorange;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(0, 50);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(249, 50);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "   Danh số bán hàng";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.White;
            this.btnDailyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDailyReport.FlatAppearance.BorderSize = 0;
            this.btnDailyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyReport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDailyReport.Image = global::GUI.Properties.Resources.playorange;
            this.btnDailyReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailyReport.Location = new System.Drawing.Point(0, 0);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDailyReport.Size = new System.Drawing.Size(249, 50);
            this.btnDailyReport.TabIndex = 0;
            this.btnDailyReport.Text = "   Doanh thu hằng ngày";
            this.btnDailyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDailyReport.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 815);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(249, 65);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "   BÁO CÁO";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panelMaterial
            // 
            this.panelMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.panelMaterial.Controls.Add(this.btnListMaterial);
            this.panelMaterial.Controls.Add(this.btnImportMaterial);
            this.panelMaterial.Controls.Add(this.btnProvide);
            this.panelMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaterial.Location = new System.Drawing.Point(0, 665);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(249, 150);
            this.panelMaterial.TabIndex = 14;
            // 
            // btnListMaterial
            // 
            this.btnListMaterial.BackColor = System.Drawing.Color.White;
            this.btnListMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMaterial.FlatAppearance.BorderSize = 0;
            this.btnListMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnListMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMaterial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnListMaterial.Image = global::GUI.Properties.Resources.playorange;
            this.btnListMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListMaterial.Location = new System.Drawing.Point(0, 100);
            this.btnListMaterial.Name = "btnListMaterial";
            this.btnListMaterial.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListMaterial.Size = new System.Drawing.Size(249, 50);
            this.btnListMaterial.TabIndex = 2;
            this.btnListMaterial.Text = "   Danh sách nguyên liệu";
            this.btnListMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListMaterial.UseVisualStyleBackColor = false;
            this.btnListMaterial.Click += new System.EventHandler(this.btnListMaterial_Click);
            // 
            // btnImportMaterial
            // 
            this.btnImportMaterial.BackColor = System.Drawing.Color.White;
            this.btnImportMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportMaterial.FlatAppearance.BorderSize = 0;
            this.btnImportMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnImportMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportMaterial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnImportMaterial.Image = global::GUI.Properties.Resources.playorange;
            this.btnImportMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportMaterial.Location = new System.Drawing.Point(0, 50);
            this.btnImportMaterial.Name = "btnImportMaterial";
            this.btnImportMaterial.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnImportMaterial.Size = new System.Drawing.Size(249, 50);
            this.btnImportMaterial.TabIndex = 1;
            this.btnImportMaterial.Text = "   Nhập nguyên liệu";
            this.btnImportMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportMaterial.UseVisualStyleBackColor = false;
            this.btnImportMaterial.Click += new System.EventHandler(this.btnImportMaterial_Click);
            // 
            // btnProvide
            // 
            this.btnProvide.BackColor = System.Drawing.Color.White;
            this.btnProvide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProvide.FlatAppearance.BorderSize = 0;
            this.btnProvide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnProvide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvide.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProvide.Image = global::GUI.Properties.Resources.playorange;
            this.btnProvide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvide.Location = new System.Drawing.Point(0, 0);
            this.btnProvide.Name = "btnProvide";
            this.btnProvide.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProvide.Size = new System.Drawing.Size(249, 50);
            this.btnProvide.TabIndex = 0;
            this.btnProvide.Text = "   Nhà cung cấp";
            this.btnProvide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProvide.UseVisualStyleBackColor = false;
            this.btnProvide.Click += new System.EventHandler(this.btnProvide_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterial.Image")));
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(0, 600);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMaterial.Size = new System.Drawing.Size(249, 65);
            this.btnMaterial.TabIndex = 13;
            this.btnMaterial.Text = "   NGUYÊN LIỆU";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.panelEmployee.Controls.Add(this.btnListEmployee);
            this.panelEmployee.Controls.Add(this.btnSalary);
            this.panelEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployee.Location = new System.Drawing.Point(0, 500);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(249, 100);
            this.panelEmployee.TabIndex = 12;
            // 
            // btnListEmployee
            // 
            this.btnListEmployee.BackColor = System.Drawing.Color.White;
            this.btnListEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListEmployee.FlatAppearance.BorderSize = 0;
            this.btnListEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnListEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnListEmployee.Image = global::GUI.Properties.Resources.playorange;
            this.btnListEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListEmployee.Location = new System.Drawing.Point(0, 50);
            this.btnListEmployee.Name = "btnListEmployee";
            this.btnListEmployee.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListEmployee.Size = new System.Drawing.Size(249, 50);
            this.btnListEmployee.TabIndex = 1;
            this.btnListEmployee.Text = "   Danh sách nhân viên";
            this.btnListEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListEmployee.UseVisualStyleBackColor = false;
            this.btnListEmployee.Click += new System.EventHandler(this.btnListEmployee_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.White;
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSalary.Image = global::GUI.Properties.Resources.playorange;
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(0, 0);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(249, 50);
            this.btnSalary.TabIndex = 0;
            this.btnSalary.Text = "   Tính lương";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 435);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(249, 65);
            this.btnEmployee.TabIndex = 11;
            this.btnEmployee.Text = "   NHÂN VIÊN";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.panelCustomer.Controls.Add(this.btnAccumulatePoints);
            this.panelCustomer.Controls.Add(this.btnListCustomer);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomer.Location = new System.Drawing.Point(0, 335);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(249, 100);
            this.panelCustomer.TabIndex = 10;
            // 
            // btnAccumulatePoints
            // 
            this.btnAccumulatePoints.BackColor = System.Drawing.Color.White;
            this.btnAccumulatePoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccumulatePoints.FlatAppearance.BorderSize = 0;
            this.btnAccumulatePoints.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAccumulatePoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccumulatePoints.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccumulatePoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccumulatePoints.Image = global::GUI.Properties.Resources.playorange;
            this.btnAccumulatePoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccumulatePoints.Location = new System.Drawing.Point(0, 50);
            this.btnAccumulatePoints.Name = "btnAccumulatePoints";
            this.btnAccumulatePoints.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAccumulatePoints.Size = new System.Drawing.Size(249, 50);
            this.btnAccumulatePoints.TabIndex = 1;
            this.btnAccumulatePoints.Text = "  Lịch sử tích điểm";
            this.btnAccumulatePoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccumulatePoints.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccumulatePoints.UseVisualStyleBackColor = false;
            this.btnAccumulatePoints.Click += new System.EventHandler(this.btnAccumulatePoints_Click);
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.BackColor = System.Drawing.Color.White;
            this.btnListCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListCustomer.FlatAppearance.BorderSize = 0;
            this.btnListCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnListCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnListCustomer.Image = global::GUI.Properties.Resources.playorange;
            this.btnListCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListCustomer.Size = new System.Drawing.Size(249, 50);
            this.btnListCustomer.TabIndex = 0;
            this.btnListCustomer.Text = "  Danh sách khách hàng";
            this.btnListCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListCustomer.UseVisualStyleBackColor = false;
            this.btnListCustomer.Click += new System.EventHandler(this.btnListCustomer_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 270);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(249, 65);
            this.btnCustomer.TabIndex = 9;
            this.btnCustomer.Text = "   KHÁCH HÀNG";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.SystemColors.Control;
            this.panelCategory.Controls.Add(this.btnCook);
            this.panelCategory.Controls.Add(this.btnFood);
            this.panelCategory.Controls.Add(this.btnTable);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategory.Location = new System.Drawing.Point(0, 120);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(249, 150);
            this.panelCategory.TabIndex = 8;
            // 
            // btnCook
            // 
            this.btnCook.BackColor = System.Drawing.Color.White;
            this.btnCook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCook.FlatAppearance.BorderSize = 0;
            this.btnCook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCook.Image = global::GUI.Properties.Resources.playorange;
            this.btnCook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCook.Location = new System.Drawing.Point(0, 100);
            this.btnCook.Name = "btnCook";
            this.btnCook.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCook.Size = new System.Drawing.Size(249, 50);
            this.btnCook.TabIndex = 2;
            this.btnCook.Text = "  Công thức nấu";
            this.btnCook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCook.UseVisualStyleBackColor = false;
            this.btnCook.Click += new System.EventHandler(this.btnCook_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.White;
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFood.Image = global::GUI.Properties.Resources.playorange;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 50);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnFood.Size = new System.Drawing.Size(249, 50);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "  Thực đơn";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.White;
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTable.Image = global::GUI.Properties.Resources.playorange;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(0, 0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTable.Size = new System.Drawing.Size(249, 50);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "  Bàn";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 1030);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(249, 65);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "   ĐĂNG XUẤT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 60);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(249, 60);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "   DANH MỤC";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(249, 60);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "   TÀI KHOẢN";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(270, 114);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1440, 813);
            this.panelDesktopPanel.TabIndex = 6;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 927);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminClone";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            this.panelMaterial.ResumeLayout(false);
            this.panelEmployee.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Button btnBestSeller;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panelMaterial;
        private System.Windows.Forms.Button btnListMaterial;
        private System.Windows.Forms.Button btnImportMaterial;
        private System.Windows.Forms.Button btnProvide;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Button btnListEmployee;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button btnAccumulatePoints;
        private System.Windows.Forms.Button btnListCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Button btnCook;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}
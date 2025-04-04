namespace GUI
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdatePermission = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxPermissions = new System.Windows.Forms.GroupBox();
            this.chkNhanVien = new System.Windows.Forms.CheckBox();
            this.chkKhachHang = new System.Windows.Forms.CheckBox();
            this.chkDanhMuc = new System.Windows.Forms.CheckBox();
            this.chkNguyenLieu = new System.Windows.Forms.CheckBox();
            this.chkBaoCao = new System.Windows.Forms.CheckBox();
            this.chkBanHang = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbTypeAccount = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxPermissions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 878);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(35, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1603, 101);
            this.panel2.TabIndex = 7;
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
            this.btnDelete.Location = new System.Drawing.Point(1178, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(194, 56);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "     Xoá ";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.txtSearch);
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Location = new System.Drawing.Point(5, 27);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(762, 56);
            this.panel9.TabIndex = 21;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(10, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(690, 23);
            this.txtSearch.TabIndex = 9;
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
            this.btnSearch.Location = new System.Drawing.Point(706, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(978, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(194, 56);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "     Sửa ";
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
            this.btnRefresh.Location = new System.Drawing.Point(1378, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(194, 56);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "    Làm mới";
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
            this.btnInsert.Location = new System.Drawing.Point(778, 27);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(194, 56);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "    Thêm ";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnUpdatePermission);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(35, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 777);
            this.panel3.TabIndex = 8;
            // 
            // btnUpdatePermission
            // 
            this.btnUpdatePermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnUpdatePermission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePermission.FlatAppearance.BorderSize = 0;
            this.btnUpdatePermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePermission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePermission.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePermission.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePermission.Image")));
            this.btnUpdatePermission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePermission.Location = new System.Drawing.Point(15, 689);
            this.btnUpdatePermission.Name = "btnUpdatePermission";
            this.btnUpdatePermission.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdatePermission.Size = new System.Drawing.Size(478, 60);
            this.btnUpdatePermission.TabIndex = 14;
            this.btnUpdatePermission.Text = "                       CẬP NHẬT QUYỀN";
            this.btnUpdatePermission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatePermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdatePermission.UseVisualStyleBackColor = false;
            this.btnUpdatePermission.Click += new System.EventHandler(this.btnUpdatePermission_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel8.Controls.Add(this.label7);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(5, 416);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(477, 47);
            this.panel8.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phân quyền";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(5, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(477, 47);
            this.panel5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.groupBoxPermissions);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(15, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 667);
            this.panel4.TabIndex = 10;
            // 
            // groupBoxPermissions
            // 
            this.groupBoxPermissions.Controls.Add(this.chkNhanVien);
            this.groupBoxPermissions.Controls.Add(this.chkKhachHang);
            this.groupBoxPermissions.Controls.Add(this.chkDanhMuc);
            this.groupBoxPermissions.Controls.Add(this.chkNguyenLieu);
            this.groupBoxPermissions.Controls.Add(this.chkBaoCao);
            this.groupBoxPermissions.Controls.Add(this.chkBanHang);
            this.groupBoxPermissions.Location = new System.Drawing.Point(6, 452);
            this.groupBoxPermissions.Name = "groupBoxPermissions";
            this.groupBoxPermissions.Size = new System.Drawing.Size(461, 206);
            this.groupBoxPermissions.TabIndex = 1;
            this.groupBoxPermissions.TabStop = false;
            // 
            // chkNhanVien
            // 
            this.chkNhanVien.AutoSize = true;
            this.chkNhanVien.Location = new System.Drawing.Point(34, 144);
            this.chkNhanVien.Name = "chkNhanVien";
            this.chkNhanVien.Size = new System.Drawing.Size(171, 27);
            this.chkNhanVien.TabIndex = 3;
            this.chkNhanVien.Text = "Quản lý nhân viên";
            this.chkNhanVien.UseVisualStyleBackColor = true;
            // 
            // chkKhachHang
            // 
            this.chkKhachHang.AutoSize = true;
            this.chkKhachHang.Location = new System.Drawing.Point(250, 94);
            this.chkKhachHang.Name = "chkKhachHang";
            this.chkKhachHang.Size = new System.Drawing.Size(185, 27);
            this.chkKhachHang.TabIndex = 2;
            this.chkKhachHang.Text = "Quản lý khách hàng";
            this.chkKhachHang.UseVisualStyleBackColor = true;
            // 
            // chkDanhMuc
            // 
            this.chkDanhMuc.AutoSize = true;
            this.chkDanhMuc.Location = new System.Drawing.Point(250, 144);
            this.chkDanhMuc.Name = "chkDanhMuc";
            this.chkDanhMuc.Size = new System.Drawing.Size(173, 27);
            this.chkDanhMuc.TabIndex = 2;
            this.chkDanhMuc.Text = "Quản lý danh mục";
            this.chkDanhMuc.UseVisualStyleBackColor = true;
            // 
            // chkNguyenLieu
            // 
            this.chkNguyenLieu.AutoSize = true;
            this.chkNguyenLieu.Location = new System.Drawing.Point(250, 43);
            this.chkNguyenLieu.Name = "chkNguyenLieu";
            this.chkNguyenLieu.Size = new System.Drawing.Size(185, 27);
            this.chkNguyenLieu.TabIndex = 2;
            this.chkNguyenLieu.Text = "Quản lý nguyên liệu";
            this.chkNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // chkBaoCao
            // 
            this.chkBaoCao.AutoSize = true;
            this.chkBaoCao.Location = new System.Drawing.Point(34, 94);
            this.chkBaoCao.Name = "chkBaoCao";
            this.chkBaoCao.Size = new System.Drawing.Size(157, 27);
            this.chkBaoCao.TabIndex = 1;
            this.chkBaoCao.Text = "Quản lý báo cáo";
            this.chkBaoCao.UseVisualStyleBackColor = true;
            // 
            // chkBanHang
            // 
            this.chkBanHang.AutoSize = true;
            this.chkBanHang.Location = new System.Drawing.Point(34, 43);
            this.chkBanHang.Name = "chkBanHang";
            this.chkBanHang.Size = new System.Drawing.Size(169, 27);
            this.chkBanHang.TabIndex = 0;
            this.chkBanHang.Text = "Quản lý bán hàng";
            this.chkBanHang.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEmployee);
            this.groupBox1.Controls.Add(this.cbTypeAccount);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDisplayName);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(154, 296);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(289, 31);
            this.cbEmployee.TabIndex = 4;
            // 
            // cbTypeAccount
            // 
            this.cbTypeAccount.FormattingEnabled = true;
            this.cbTypeAccount.Location = new System.Drawing.Point(154, 169);
            this.cbTypeAccount.Name = "cbTypeAccount";
            this.cbTypeAccount.Size = new System.Drawing.Size(289, 31);
            this.cbTypeAccount.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 232);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(154, 111);
            this.txtDisplayName.Multiline = true;
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(289, 31);
            this.txtDisplayName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(154, 55);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(289, 31);
            this.txtUserName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email đăng ký:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hiển thị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.dtgvAccount);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(540, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1098, 777);
            this.panel7.TabIndex = 10;
            // 
            // dtgvAccount
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAccount.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvAccount.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgvAccount.Location = new System.Drawing.Point(19, 7);
            this.dtgvAccount.Name = "dtgvAccount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvAccount.RowHeadersVisible = false;
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(1056, 742);
            this.dtgvAccount.TabIndex = 1;
            this.dtgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellClick);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1638, 878);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccount";
            this.Text = "TÀI KHOẢN";
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBoxPermissions.ResumeLayout(false);
            this.groupBoxPermissions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeAccount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxPermissions;
        private System.Windows.Forms.Button btnUpdatePermission;
        private System.Windows.Forms.CheckBox chkNhanVien;
        private System.Windows.Forms.CheckBox chkKhachHang;
        private System.Windows.Forms.CheckBox chkDanhMuc;
        private System.Windows.Forms.CheckBox chkNguyenLieu;
        private System.Windows.Forms.CheckBox chkBaoCao;
        private System.Windows.Forms.CheckBox chkBanHang;
    }
}
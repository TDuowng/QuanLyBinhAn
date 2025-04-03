namespace GUI
{
    partial class frmCook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCook));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSeachCook = new System.Windows.Forms.TextBox();
            this.btnSearchCook = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCook = new System.Windows.Forms.Button();
            this.btnUpdateCook = new System.Windows.Forms.Button();
            this.btnRefreshCook = new System.Windows.Forms.Button();
            this.btnInsertCook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowFood = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvCook = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 878);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnDeleteCook);
            this.panel3.Controls.Add(this.btnUpdateCook);
            this.panel3.Controls.Add(this.btnRefreshCook);
            this.panel3.Controls.Add(this.btnInsertCook);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(35, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1603, 209);
            this.panel3.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.txtSeachCook);
            this.panel9.Controls.Add(this.btnSearchCook);
            this.panel9.Location = new System.Drawing.Point(605, 16);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(986, 56);
            this.panel9.TabIndex = 22;
            // 
            // txtSeachCook
            // 
            this.txtSeachCook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeachCook.Location = new System.Drawing.Point(6, 17);
            this.txtSeachCook.Name = "txtSeachCook";
            this.txtSeachCook.Size = new System.Drawing.Size(918, 23);
            this.txtSeachCook.TabIndex = 15;
            // 
            // btnSearchCook
            // 
            this.btnSearchCook.BackColor = System.Drawing.Color.White;
            this.btnSearchCook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCook.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchCook.FlatAppearance.BorderSize = 0;
            this.btnSearchCook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnSearchCook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCook.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCook.Image")));
            this.btnSearchCook.Location = new System.Drawing.Point(930, 0);
            this.btnSearchCook.Name = "btnSearchCook";
            this.btnSearchCook.Size = new System.Drawing.Size(56, 56);
            this.btnSearchCook.TabIndex = 14;
            this.btnSearchCook.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(563, 47);
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
            // btnDeleteCook
            // 
            this.btnDeleteCook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnDeleteCook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCook.FlatAppearance.BorderSize = 0;
            this.btnDeleteCook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCook.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCook.Image")));
            this.btnDeleteCook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCook.Location = new System.Drawing.Point(1155, 128);
            this.btnDeleteCook.Name = "btnDeleteCook";
            this.btnDeleteCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeleteCook.Size = new System.Drawing.Size(204, 60);
            this.btnDeleteCook.TabIndex = 5;
            this.btnDeleteCook.Text = "        Xoá";
            this.btnDeleteCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCook.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCook
            // 
            this.btnUpdateCook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnUpdateCook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCook.FlatAppearance.BorderSize = 0;
            this.btnUpdateCook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCook.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCook.Image")));
            this.btnUpdateCook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCook.Location = new System.Drawing.Point(924, 128);
            this.btnUpdateCook.Name = "btnUpdateCook";
            this.btnUpdateCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdateCook.Size = new System.Drawing.Size(204, 60);
            this.btnUpdateCook.TabIndex = 5;
            this.btnUpdateCook.Text = "       Sửa";
            this.btnUpdateCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateCook.UseVisualStyleBackColor = false;
            // 
            // btnRefreshCook
            // 
            this.btnRefreshCook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnRefreshCook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCook.FlatAppearance.BorderSize = 0;
            this.btnRefreshCook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCook.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCook.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCook.Image")));
            this.btnRefreshCook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCook.Location = new System.Drawing.Point(1387, 128);
            this.btnRefreshCook.Name = "btnRefreshCook";
            this.btnRefreshCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefreshCook.Size = new System.Drawing.Size(204, 60);
            this.btnRefreshCook.TabIndex = 5;
            this.btnRefreshCook.Text = "    Làm mới";
            this.btnRefreshCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshCook.UseVisualStyleBackColor = false;
            // 
            // btnInsertCook
            // 
            this.btnInsertCook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnInsertCook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertCook.FlatAppearance.BorderSize = 0;
            this.btnInsertCook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertCook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCook.ForeColor = System.Drawing.Color.White;
            this.btnInsertCook.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertCook.Image")));
            this.btnInsertCook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCook.Location = new System.Drawing.Point(693, 129);
            this.btnInsertCook.Name = "btnInsertCook";
            this.btnInsertCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInsertCook.Size = new System.Drawing.Size(204, 60);
            this.btnInsertCook.TabIndex = 5;
            this.btnInsertCook.Text = "       Thêm ";
            this.btnInsertCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertCook.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 179);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(135, 23);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(394, 31);
            this.cbCategory.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(394, 31);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nguyên liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại thực đơn:";
            // 
            // flowFood
            // 
            this.flowFood.AutoScroll = true;
            this.flowFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowFood.Location = new System.Drawing.Point(35, 209);
            this.flowFood.Name = "flowFood";
            this.flowFood.Size = new System.Drawing.Size(888, 669);
            this.flowFood.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvCook);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(923, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 669);
            this.panel4.TabIndex = 10;
            // 
            // dtgvCook
            // 
            this.dtgvCook.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCook.Location = new System.Drawing.Point(6, 3);
            this.dtgvCook.Name = "dtgvCook";
            this.dtgvCook.RowHeadersWidth = 51;
            this.dtgvCook.RowTemplate.Height = 24;
            this.dtgvCook.Size = new System.Drawing.Size(697, 635);
            this.dtgvCook.TabIndex = 0;
            // 
            // frmCook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 878);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowFood);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCook";
            this.Text = "CÔNG THỨC NẤU ĂN";
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCook;
        private System.Windows.Forms.Button btnUpdateCook;
        private System.Windows.Forms.Button btnRefreshCook;
        private System.Windows.Forms.Button btnInsertCook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dtgvCook;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSeachCook;
        private System.Windows.Forms.Button btnSearchCook;
    }
}
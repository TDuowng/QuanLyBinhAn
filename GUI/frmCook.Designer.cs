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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboIngredient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowFood = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtIdCook = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rikDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rikQuantitative = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMainIngredient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.lblTitle);
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1417, 84);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(174, 53);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "In công thức";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(881, 165);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(510, 38);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "CÔNG THỨC NẤU GÀ SỐT TƯƠNG TỎI";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.txtSeachCook);
            this.panel9.Controls.Add(this.btnSearchCook);
            this.panel9.Location = new System.Drawing.Point(652, 16);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(939, 56);
            this.panel9.TabIndex = 22;
            // 
            // txtSeachCook
            // 
            this.txtSeachCook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeachCook.Location = new System.Drawing.Point(13, 17);
            this.txtSeachCook.Name = "txtSeachCook";
            this.txtSeachCook.Size = new System.Drawing.Size(844, 23);
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
            this.btnSearchCook.Location = new System.Drawing.Point(883, 0);
            this.btnSearchCook.Name = "btnSearchCook";
            this.btnSearchCook.Size = new System.Drawing.Size(56, 56);
            this.btnSearchCook.TabIndex = 14;
            this.btnSearchCook.UseVisualStyleBackColor = false;
            this.btnSearchCook.Click += new System.EventHandler(this.btnSearchCook_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(7, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(608, 47);
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
            this.btnDeleteCook.Location = new System.Drawing.Point(1036, 84);
            this.btnDeleteCook.Name = "btnDeleteCook";
            this.btnDeleteCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeleteCook.Size = new System.Drawing.Size(174, 53);
            this.btnDeleteCook.TabIndex = 5;
            this.btnDeleteCook.Text = "        Xoá";
            this.btnDeleteCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCook.UseVisualStyleBackColor = false;
            this.btnDeleteCook.Click += new System.EventHandler(this.btnDeleteCook_Click);
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
            this.btnUpdateCook.Location = new System.Drawing.Point(844, 84);
            this.btnUpdateCook.Name = "btnUpdateCook";
            this.btnUpdateCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdateCook.Size = new System.Drawing.Size(174, 53);
            this.btnUpdateCook.TabIndex = 5;
            this.btnUpdateCook.Text = "       Sửa";
            this.btnUpdateCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateCook.UseVisualStyleBackColor = false;
            this.btnUpdateCook.Click += new System.EventHandler(this.btnUpdateCook_Click);
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
            this.btnRefreshCook.Location = new System.Drawing.Point(1227, 84);
            this.btnRefreshCook.Name = "btnRefreshCook";
            this.btnRefreshCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefreshCook.Size = new System.Drawing.Size(174, 53);
            this.btnRefreshCook.TabIndex = 5;
            this.btnRefreshCook.Text = "    Làm mới";
            this.btnRefreshCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshCook.UseVisualStyleBackColor = false;
            this.btnRefreshCook.Click += new System.EventHandler(this.btnRefreshCook_Click);
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
            this.btnInsertCook.Location = new System.Drawing.Point(652, 84);
            this.btnInsertCook.Name = "btnInsertCook";
            this.btnInsertCook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInsertCook.Size = new System.Drawing.Size(174, 53);
            this.btnInsertCook.TabIndex = 5;
            this.btnInsertCook.Text = "       Thêm ";
            this.btnInsertCook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertCook.UseVisualStyleBackColor = false;
            this.btnInsertCook.Click += new System.EventHandler(this.btnInsertCook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 179);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.cboIngredient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(135, 26);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(457, 31);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboIngredient
            // 
            this.cboIngredient.FormattingEnabled = true;
            this.cboIngredient.Location = new System.Drawing.Point(135, 75);
            this.cboIngredient.Name = "cboIngredient";
            this.cboIngredient.Size = new System.Drawing.Size(457, 31);
            this.cboIngredient.TabIndex = 3;
            this.cboIngredient.SelectedIndexChanged += new System.EventHandler(this.cboIngredient_SelectedIndexChanged);
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
            this.label2.Location = new System.Drawing.Point(10, 30);
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
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(923, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 669);
            this.panel4.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.panel7.Controls.Add(this.txtIdCook);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 46);
            this.panel7.TabIndex = 12;
            // 
            // txtIdCook
            // 
            this.txtIdCook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.txtIdCook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCook.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtIdCook.ForeColor = System.Drawing.Color.White;
            this.txtIdCook.Location = new System.Drawing.Point(174, 8);
            this.txtIdCook.Name = "txtIdCook";
            this.txtIdCook.Size = new System.Drawing.Size(48, 31);
            this.txtIdCook.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Công thức số:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(7, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(697, 635);
            this.panel6.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rikDescription);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rikQuantitative);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboMainIngredient);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(11, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 624);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // rikDescription
            // 
            this.rikDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rikDescription.Location = new System.Drawing.Point(15, 338);
            this.rikDescription.Name = "rikDescription";
            this.rikDescription.Size = new System.Drawing.Size(647, 275);
            this.rikDescription.TabIndex = 11;
            this.rikDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Các bước làm:";
            // 
            // rikQuantitative
            // 
            this.rikQuantitative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rikQuantitative.Location = new System.Drawing.Point(15, 179);
            this.rikQuantitative.Name = "rikQuantitative";
            this.rikQuantitative.Size = new System.Drawing.Size(647, 116);
            this.rikQuantitative.TabIndex = 9;
            this.rikQuantitative.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Định lượng:";
            // 
            // cboMainIngredient
            // 
            this.cboMainIngredient.FormattingEnabled = true;
            this.cboMainIngredient.Location = new System.Drawing.Point(199, 91);
            this.cboMainIngredient.Name = "cboMainIngredient";
            this.cboMainIngredient.Size = new System.Drawing.Size(463, 31);
            this.cboMainIngredient.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nguyên liệu chính:";
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
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboIngredient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSeachCook;
        private System.Windows.Forms.Button btnSearchCook;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rikDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rikQuantitative;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMainIngredient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtIdCook;
        private System.Windows.Forms.Label label7;
    }
}
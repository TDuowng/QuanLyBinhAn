namespace GUI
{
    partial class UcTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTable));
            this.grbUcTable = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ptbFood = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.grbUcTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFood)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUcTable
            // 
            this.grbUcTable.BackColor = System.Drawing.Color.Transparent;
            this.grbUcTable.Controls.Add(this.lblName);
            this.grbUcTable.Controls.Add(this.ptbFood);
            this.grbUcTable.Controls.Add(this.lblStatus);
            this.grbUcTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUcTable.Location = new System.Drawing.Point(6, -5);
            this.grbUcTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUcTable.Name = "grbUcTable";
            this.grbUcTable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbUcTable.Size = new System.Drawing.Size(201, 121);
            this.grbUcTable.TabIndex = 4;
            this.grbUcTable.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.lblName.Location = new System.Drawing.Point(9, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Bàn 1";
            // 
            // ptbFood
            // 
            this.ptbFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbFood.Image = ((System.Drawing.Image)(resources.GetObject("ptbFood.Image")));
            this.ptbFood.Location = new System.Drawing.Point(117, 31);
            this.ptbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbFood.Name = "ptbFood";
            this.ptbFood.Size = new System.Drawing.Size(78, 80);
            this.ptbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFood.TabIndex = 2;
            this.ptbFood.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(119)))), ((int)(((byte)(20)))));
            this.lblStatus.Location = new System.Drawing.Point(9, 73);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 28);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Bàn trống";
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.grbUcTable);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(213, 123);
            this.pnlBackground.TabIndex = 5;
            // 
            // UcTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBackground);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcTable";
            this.Size = new System.Drawing.Size(213, 123);
            this.Load += new System.EventHandler(this.UcTable_Load);
            this.grbUcTable.ResumeLayout(false);
            this.grbUcTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFood)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUcTable;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox ptbFood;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlBackground;
    }
}

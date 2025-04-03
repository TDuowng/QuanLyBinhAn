using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UcTable : UserControl
    {
        public event EventHandler OnSelect = null;

        private string tableName;
        private string status;

        public string TableName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }
        public UcTable()
        {
            InitializeComponent();
        }
        
        public void SetTableData(string tableName, string status)
        {
            lblName.Text = tableName;
            lblStatus.Text = status;
            UpdateStatusColor();
        }
        
        private void UpdateStatusColor()
        {
            switch (lblStatus.Text)
            {
                case "Bàn trống":
                    this.BackColor = Color.White;
                    break;
                case "Có người":
                    this.BackColor = Color.FromArgb(255, 192, 128);
                    lblStatus.ForeColor = Color.White;
                    break;
                case "Sửa chữa":
                    this.BackColor = SystemColors.Control; 
                    break;
            }
        }

        // Thêm phương thức để highlight khi được chọn
        public void SetSelected(bool isSelected)
        {
            if (isSelected)
            {
                this.BorderStyle = BorderStyle.FixedSingle; 
            }
            else
            {
                UpdateStatusColor(); 
                this.BorderStyle = BorderStyle.None; 
            }
        }

        private void UcTable_Load(object sender, EventArgs e)
        {
            
            this.Click += UcTable_Click; 
            lblName.Click += UcTable_Click;
            lblStatus.Click += UcTable_Click;
        }

        private void UcTable_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e); // Kích hoạt sự kiện khi click

        }


    }
}

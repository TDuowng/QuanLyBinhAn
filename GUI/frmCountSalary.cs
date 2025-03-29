using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCountSalary : Form
    {
        public frmCountSalary()
        {
            InitializeComponent();
            LoadListEmployee();
            LoadListWork();
        }

        #region Methods
        private void LoadListEmployee()
        {
            List<EmployeeDTO> employeeList = EmployeeBLL.GetListEmployee();
            dtgvEmployee.DataSource = employeeList;
            dtgvEmployee.Columns["idEmployee"].HeaderText = "Mã nhân viên";
            dtgvEmployee.Columns["idEmployee"].Visible = false;
            dtgvEmployee.Columns["Name"].HeaderText = "Tên nhân viên";
            dtgvEmployee.Columns["Gender"].HeaderText = "Giới tính";
            dtgvEmployee.Columns["Phone"].HeaderText = "Số điện thoại";
            dtgvEmployee.Columns["Position"].HeaderText = "Chức vụ";
            dtgvEmployee.Columns["Image"].Visible = false;
            dtgvEmployee.Columns["TypeEmployee"].HeaderText = "Loại nhân viên";
            dtgvEmployee.Columns["TypeEmployee"].Visible = false;
            dtgvEmployee.RowTemplate.Height = 40;
        }

        private void LoadListWork()
        {
            List<WorkDTO> workList = WorkBLL.GetListWork();
            cbWork.DataSource = workList;
            cbWork.DisplayMember = "NameWork";
            cbWork.ValueMember = "IdWork";
        }

        private void ClearText()
        {
            txtIdEmployee.Text = "";
            txtNameEmployee.Text = "";
            txtPhoneEmployee.Text = "";
            cbPositionEmployee.Text = "";
        }

        private void WorkShiftControlsByFullTime()
        {
            cbWork.Enabled = false;
            dtpkIn.Enabled = false;
            dtpkOut.Enabled = false;
            numCountHour.Enabled = false;
            numSalary.Enabled = true;

        }

        private void WorkShiftControlsByPartTime()
        {
            cbWork.Enabled = true;
            dtpkIn.Enabled = true;
            dtpkOut.Enabled = true;
            numCountHour.Enabled = true;
            numSalary.Enabled = false;
        }

        private void CountHour()
        {
            try
            {
                // Lấy giá trị từ DateTimePicker
                DateTime gioBatDau = dtpkIn.Value;
                DateTime gioKetThuc = dtpkOut.Value;

                // Đảm bảo giờ kết thúc lớn hơn giờ bắt đầu
                if (gioKetThuc <= gioBatDau)
                {
                    MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính số giờ làm
                TimeSpan thoiGianLam = gioKetThuc - gioBatDau;

                // Gán vào NumericUpDown
                numCountHour.Value = (decimal)thoiGianLam.TotalHours;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events
        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không bấm vào header
            {
                DataGridViewRow row = dtgvEmployee.Rows[e.RowIndex];

                string loaiNV = row.Cells["TypeEmployee"].Value?.ToString(); // Kiểm tra null

                if (!string.IsNullOrEmpty(loaiNV))
                {
                    if (loaiNV.Trim().ToLower() == "part-time")
                    {
                        WorkShiftControlsByPartTime();
                    }
                    else if (loaiNV.Trim().ToLower() == "full-time")
                    {
                        WorkShiftControlsByFullTime();
                    }
                }
            }
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertSalaryEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateSalaryEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSalaryEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshSalaryEmployee_Click(object sender, EventArgs e)
        {

        }
        private void btnWork_Click(object sender, EventArgs e)
        {
            Form f = new frmWork();
            f.ShowDialog();
        }

        private void cbWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWork.SelectedValue != null && cbWork.SelectedValue is int)
            {
                int maCa = Convert.ToInt32(cbWork.SelectedValue);
                List<WorkDTO> list = WorkBLL.GetHourByWork(maCa);

                if (list.Count > 0)
                {
                    WorkDTO work = list[0];
                    dtpkIn.Text = work.DateIn.ToString("HH:mm");
                    dtpkOut.Text = work.DateOut.ToString("HH:mm");
                    numCountHour.Text = work.NumberHour.ToString();
                }
            }
        }

        #endregion

        private void dtgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvEmployee.Rows.Count)
            {
                DataGridViewRow row = dtgvEmployee.Rows[e.RowIndex];
                txtIdEmployee.Text = row.Cells["idEmployee"].Value.ToString();
                txtNameEmployee.Text = row.Cells["Name"].Value.ToString();
                txtPhoneEmployee.Text = row.Cells["Phone"].Value.ToString();
                cbPositionEmployee.Text = row.Cells["Position"].Value.ToString();
            }
        }

        private void dtpkIn_ValueChanged(object sender, EventArgs e)
        {
            CountHour();
        }

        private void dtpkOut_ValueChanged(object sender, EventArgs e)
        {
            CountHour();
        }
    }
}

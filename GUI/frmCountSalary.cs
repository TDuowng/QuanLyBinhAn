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
        private void LoadWorkShiftList(int maNV)
        {
            DataTable workShiftList = WorkShiftBLL.LoadListWorkShift(maNV);
            dtgvListSalaryEmployee.DataSource = workShiftList;


            if (dtgvListSalaryEmployee.Columns.Contains("MaPhien"))
            {
                dtgvListSalaryEmployee.Columns["MaPhien"].HeaderText = "Mã phiên";
            }

            if (dtgvListSalaryEmployee.Columns.Contains("NgayLam"))
            {
                dtgvListSalaryEmployee.Columns["NgayLam"].HeaderText = "Ngày làm";
            }

            if (dtgvListSalaryEmployee.Columns.Contains("GioCheckin"))
            {
                dtgvListSalaryEmployee.Columns["GioCheckin"].HeaderText = "Giờ vào ca";
            }

            if (dtgvListSalaryEmployee.Columns.Contains("GioCheckout"))
            {
                dtgvListSalaryEmployee.Columns["GioCheckout"].HeaderText = "Giờ kết ca";
            }
            else
            {
                MessageBox.Show("Column 'GioCheckout' does not exist.");
            }

            if (dtgvListSalaryEmployee.Columns.Contains("SoGioThucTe"))
            {
                dtgvListSalaryEmployee.Columns["SoGioThucTe"].HeaderText = "Số giờ";
            }

            if (dtgvListSalaryEmployee.Columns.Contains("TongLuong"))
            {
                dtgvListSalaryEmployee.Columns["TongLuong"].HeaderText = "Tổng lương";
            }

            if (dtgvListSalaryEmployee.Columns.Contains("Thuong"))
            {
                dtgvListSalaryEmployee.Columns["Thuong"].HeaderText = "Thưởng";
            }
            dtgvListSalaryEmployee.RowTemplate.Height = 40;

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
                int maNV = Convert.ToInt32(txtIdEmployee.Text);
                LoadWorkShiftList(maNV);
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
            if (string.IsNullOrEmpty(txtIdEmployee.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maNV = Convert.ToInt32(txtIdEmployee.Text);
                string loaiNV = EmployeeBLL.GetTypeEmployee(maNV);

                // Chuẩn hoá kiểu dữ liệu
                double mucLuongCoBan = Convert.ToDouble(numSalary.Value);
                double thuong = Convert.ToDouble(numBonus.Value);
                DateTime ngayLam = dtpkDateWork.Value;
                DateTime gioCheckin = dtpkIn.Value;
                DateTime gioCheckout = dtpkOut.Value;

                if (loaiNV.Trim().ToLower() == "part-time")
                {
                    if (cbWork.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn ca làm việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int maCa = Convert.ToInt32(cbWork.SelectedValue);
                    double soGioThucTe = Convert.ToDouble(numCountHour.Value);

                    WorkShiftDTO workShift = new WorkShiftDTO
                    {
                        IdEmployee = maNV,
                        IdWork = maCa,
                        DateWork = ngayLam,
                        DateIn = gioCheckin,
                        DateOut = gioCheckout,
                        NumberHour = soGioThucTe,
                        Salary = mucLuongCoBan,
                        AWard = thuong
                    };

                    if (WorkShiftBLL.InsertWorkShift(workShift))
                    {
                        MessageBox.Show("Thêm phiên làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WorkShiftBLL.CalculateSalary(maNV); 
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiên làm việc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (loaiNV.Trim().ToLower() == "full-time")
                {
                    if (mucLuongCoBan == 0)
                    {
                        MessageBox.Show("Vui lòng nhập mức lương cơ bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    WorkShiftDTO workShift = new WorkShiftDTO(maNV, -1, 0, ngayLam, gioCheckin, gioCheckout, 0, mucLuongCoBan, thuong);

                    if (WorkShiftBLL.InsertWorkShift(workShift))
                    {
                        MessageBox.Show("Thêm phiên làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WorkShiftBLL.CalculateSalary(maNV);
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiên làm việc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSalaryEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEmployee.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int maNV = Convert.ToInt32(txtIdEmployee.Text);
                string loaiNV = EmployeeBLL.GetTypeEmployee(maNV);
                if (loaiNV.Trim().ToLower() == "part-time")
                {
                    if (cbWork.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn ca làm việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int maCa = Convert.ToInt32(cbWork.SelectedValue);
                    DateTime ngayLam = dtpkDateWork.Value;
                    DateTime gioCheckin = dtpkIn.Value;
                    DateTime gioCheckout = dtpkOut.Value;
                    double soGioThucTe = Convert.ToDouble(numCountHour.Value);
                    double mucLuongCoBan = Convert.ToDouble(numSalary.Value);
                    double thuong = Convert.ToDouble(numBonus.Value);
                    WorkShiftDTO workShift = new WorkShiftDTO
                    {
                        IdEmployee = maNV,
                        IdWork = maCa,
                        DateWork = ngayLam,
                        DateIn = gioCheckin,
                        DateOut = gioCheckout,
                        NumberHour = soGioThucTe,
                        Salary = mucLuongCoBan,
                        AWard = thuong
                    };

                    if (WorkShiftBLL.UpdateWorkShift(workShift))
                    {
                        MessageBox.Show("Cập nhật phiên làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật làm việc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (loaiNV.Trim().ToLower() == "full-time")
                {
                    if (numSalary.Value == 0)
                    {
                        MessageBox.Show("Vui lòng nhập mức lương cơ bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    float mucLuongCoBan = Convert.ToSingle(numSalary.Value);
                    float thuong = 0;
                    DateTime ngayLam = dtpkDateWork.Value;
                    DateTime gioCheckin = dtpkIn.Value;
                    DateTime gioCheckout = dtpkOut.Value;
                    WorkShiftDTO workShift = new WorkShiftDTO(maNV, -1, 0, ngayLam, gioCheckin, gioCheckout, 0, mucLuongCoBan, thuong);
                    if (WorkShiftBLL.UpdateWorkShift(workShift))
                    {
                        MessageBox.Show("Cập nhật phiên làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiên việc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                    numSalary.Text = work.Salary.ToString();
                }
            }
        }

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
        #endregion


    }
}

using BLL;
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
    public partial class frmCountSalary : Form
    {
        public frmCountSalary()
        {
            InitializeComponent();
            LoadListEmployee();
            LoadListWork();
            LoadListWorkShift();
            LoadDateTimePicker();
            cbWork.SelectedIndex = -1;

            SetupAutoComplete();
            dtpkFromDate.CustomFormat = "dd/MM/yyyy";
            dtpkToDate.CustomFormat = "dd/MM/yyyy";
            dtpkDateWork.CustomFormat = "dd/MM/yyyy";
            dtpkIn.CustomFormat = "HH:mm";
            dtpkOut.CustomFormat = "HH:mm";
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        #region Methods

        private bool isFiltered = false; // Biến để kiểm tra xem có đang lọc không
        private DateTime? filterFromDate = null; // Lưu ngày bắt đầu của bộ lọc
        private DateTime? filterToDate = null; // Lưu ngày kết thúc của bộ lọc
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
        private void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        private void LoadListWork()
        {
            List<WorkDTO> workList = WorkBLL.GetListWork();
            cbWork.DataSource = workList;
            cbWork.DisplayMember = "NameWork";
            cbWork.ValueMember = "IdWork";
        }
        private void LoadListWorkShift()
        {
            if (isFiltered && filterFromDate.HasValue && filterToDate.HasValue)
            {
                // Nếu đang có bộ lọc, áp dụng lại bộ lọc
                LoadListWorkShiftByDateRange(filterFromDate.Value, filterToDate.Value);
            }
            else
            {
                // Nếu không có bộ lọc, load tất cả
                List<WorkShiftDTO> workShiftList = WorkShiftBLL.GetAllWorkShift();
                dtgvWorkShift.DataSource = workShiftList;
                CustomDataGridView(true);

                // Tính tổng lương của tất cả các phiên làm việc
                float totalSalary = WorkShiftBLL.GetTongLuongAll();
                txtTotalSalary.Text = totalSalary.ToString("N0");
            }
        }

        private void LoadListWorkShiftByDateRange(DateTime fromDate, DateTime toDate)
        {
            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isFiltered = true;
            filterFromDate = fromDate;
            filterToDate = toDate;

            List<WorkShiftDTO> workShiftList = WorkShiftBLL.GetWorkShiftByDateRange(fromDate, toDate);
            dtgvWorkShift.DataSource = workShiftList;
            CustomDataGridView(true);

            float totalSalary = WorkShiftBLL.GetTongLuongByDateRange(fromDate, toDate);
            txtTotalSalary.Text = totalSalary.ToString("N0");

            // Thông báo nếu không có dữ liệu
            if (workShiftList.Count == 0)
            {
                MessageBox.Show("Không có phiên làm việc nào trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadListWorkShiftByEmployee(int idEmployee)
        {
            List<WorkShiftDTO> workShiftList;
            float totalSalary;

            if (isFiltered && filterFromDate.HasValue && filterToDate.HasValue)
            {
                workShiftList = WorkShiftBLL.GetWorkShiftsByEmployeeIDAndDateRange(idEmployee, filterFromDate.Value, filterToDate.Value);
                totalSalary = WorkShiftBLL.GetTongLuongByEmployeeIDAndDateRange(idEmployee, filterFromDate.Value, filterToDate.Value);
            }
            else
            {
                workShiftList = WorkShiftBLL.GetWorkShiftByIDEmployee(idEmployee);
                totalSalary = workShiftList.Sum(ws => ws.Total);
            }

            dtgvWorkShift.DataSource = workShiftList;
            CustomDataGridView();

            txtTotalSalary.Text = totalSalary.ToString("N0");

            // Thông báo nếu không có dữ liệu
            if (workShiftList.Count == 0)
            {
                MessageBox.Show($"Nhân viên này không có phiên làm việc nào {(isFiltered ? "trong khoảng thời gian này" : "")}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void CustomDataGridView(bool showNameEmployee = false)
        {
            dtgvWorkShift.Columns["IdWorkShift"].HeaderText = "Mã phiên";
            dtgvWorkShift.Columns["IdWork"].Visible = false;
            dtgvWorkShift.Columns["IdEmployee"].Visible = false;
            dtgvWorkShift.Columns["NameEmployee"].HeaderText = "Tên nhân viên";
            dtgvWorkShift.Columns["NameEmployee"].Visible = showNameEmployee; // Hiển thị hoặc ẩn cột NameEmployee
            dtgvWorkShift.Columns["NameWork"].HeaderText = "Tên ca";
            dtgvWorkShift.Columns["DateWork"].HeaderText = "Ngày làm";
            dtgvWorkShift.Columns["DateWork"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvWorkShift.Columns["CheckinHour"].HeaderText = "Giờ check-in";
            dtgvWorkShift.Columns["CheckoutHour"].HeaderText = "Giờ check-out";
            dtgvWorkShift.Columns["CheckinHour"].DefaultCellStyle.Format = "HH:mm";
            dtgvWorkShift.Columns["CheckoutHour"].DefaultCellStyle.Format = "HH:mm";
            dtgvWorkShift.Columns["Salary"].HeaderText = "Lương";
            dtgvWorkShift.Columns["NumberHour"].HeaderText = "Số giờ làm";
            dtgvWorkShift.Columns["Bonus"].HeaderText = "Thưởng";
            dtgvWorkShift.Columns["Total"].HeaderText = "Tổng lương";
            dtgvWorkShift.RowTemplate.Height = 40;
        }

        
        private void ClearText()
        {
            txtIdEmployee.Text = "";
            txtNameEmployee.Text = "";
            txtPhoneEmployee.Text = "";
            cbPositionEmployee.Text = "";
            numSalary.Value = 0;
            numBonus.Value = 0;
            numCountHour.Value = 0;
            cbWork.Text = " ";

            LoadListWorkShift();
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

        private void SetupAutoComplete()
        {
            var food = EmployeeBLL.GetListEmployee()
                                  .Select(i => i.Name)
                                  .ToArray();

            // Cấu hình AutoComplete
            txtSearchSalary.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchSalary.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(food);

            txtSearchSalary.AutoCompleteCustomSource = collection;
        }



        #endregion

        #region Events

        private void dtgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvEmployee.Rows[e.RowIndex];
                int idEmployee = Convert.ToInt32(row.Cells["IdEmployee"].Value);
                LoadListWorkShiftByEmployee(idEmployee);
            }
        }


        private void btnSearchSalary_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchSalary.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                List<EmployeeDTO> employeeList = EmployeeBLL.SearchEmployee(keyword);
                dtgvEmployee.DataSource = employeeList;
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
            else
            {
                LoadListEmployee(); // Load all employees items if the search term is empty
            }
        }

        private void btnInsertSalaryEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(txtIdEmployee.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần thêm phiên làm việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbWork.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (numSalary.Value <= 0)
                {
                    MessageBox.Show("Lương phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get values from the form controls
                int idEmployee = Convert.ToInt32(txtIdEmployee.Text);
                int idWork = Convert.ToInt32(cbWork.SelectedValue);
                DateTime dateWork = dtpkDateWork.Value;
                DateTime checkinHour = dtpkIn.Value;
                DateTime checkoutHour = dtpkOut.Value;
                float numhour = (float)numCountHour.Value;
                float salary = (float)numSalary.Value;
                float bonus = (float)numBonus.Value;

                // Create a new WorkShiftDTO object
                WorkShiftDTO newWorkShift = new WorkShiftDTO
                {
                    IdEmployee = idEmployee,
                    IdWork = idWork,
                    DateWork = dateWork,
                    CheckinHour = checkinHour,
                    CheckoutHour = checkoutHour,
                    NumberHour = numhour,
                    Salary = salary,
                    Bonus = bonus
                };

                if (!WorkShiftBLL.InsertWorkShift(newWorkShift))
                {
                    MessageBox.Show("Thêm phiên làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListWorkShift(); // Refresh the work shift list
                }
                else
                {
                    MessageBox.Show("Thêm phiên làm việc thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadListWorkShift();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSalaryEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvWorkShift.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một ô trong bảng phiên làm việc để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validate input
                if (string.IsNullOrEmpty(txtIdEmployee.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật phiên làm việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbWork.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (numSalary.Value <= 0)
                {
                    MessageBox.Show("Lương phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get values from the form controls
                int idWorkShift = Convert.ToInt32(dtgvWorkShift.CurrentRow.Cells["IdWorkShift"].Value);
                int idEmployee = Convert.ToInt32(txtIdEmployee.Text);
                int idWork = Convert.ToInt32(cbWork.SelectedValue);
                DateTime dateWork = dtpkDateWork.Value;
                DateTime checkinHour = dtpkIn.Value;
                DateTime checkoutHour = dtpkOut.Value;
                float numhour = (float)numCountHour.Value;
                float salary = (float)numSalary.Value;
                float bonus = (float)numBonus.Value;

                // Create a new WorkShiftDTO object
                WorkShiftDTO updatedWorkShift = new WorkShiftDTO
                {
                    IdWorkShift = idWorkShift,
                    IdEmployee = idEmployee,
                    IdWork = idWork,
                    DateWork = dateWork,
                    CheckinHour = checkinHour,
                    CheckoutHour = checkoutHour,
                    NumberHour = numhour,
                    Salary = salary,
                    Bonus = bonus
                };

                // Update the existing work shift record
                bool isUpdated = WorkShiftBLL.UpdateWorkShift(updatedWorkShift);

                if (!isUpdated)
                {
                    MessageBox.Show("Cập nhật phiên làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListWorkShiftByEmployee(idEmployee); 
                }
                else
                {
                    MessageBox.Show("Cập nhật phiên làm việc thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteSalaryEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào đang được chọn không (dựa trên ô hiện tại)
                if (dtgvWorkShift.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một ô trong bảng phiên làm việc để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy dòng hiện tại (dòng chứa ô được chọn)
                DataGridViewRow row = dtgvWorkShift.CurrentRow;

                // Lấy IdWorkShift của phiên làm việc cần xóa
                int idWorkShift = Convert.ToInt32(row.Cells["IdWorkShift"].Value);

                // Hỏi xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiên làm việc này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                // Gọi BLL để xóa phiên làm việc
                bool isDeleted = WorkShiftBLL.DeleteWorkShift(idWorkShift);

                if (!isDeleted)
                {
                    MessageBox.Show("Xóa phiên làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListWorkShift(); // Refresh danh sách phiên làm việc
                    ClearText(); // Xóa các control nhập liệu sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa phiên làm việc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshSalaryEmployee_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadListEmployee();
            isFiltered = false; // Reset bộ lọc
            filterFromDate = null;
            filterToDate = null;
            LoadListWorkShift(); // Quay lại trạng thái ban đầu
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
                string typeEmployee = row.Cells["TypeEmployee"].Value.ToString();
                if (dtgvEmployee.SelectedRows.Count == 0)
                    return;

                int idEmployee = Convert.ToInt32(dtgvEmployee.SelectedRows[0].Cells["IdEmployee"].Value);
                LoadListWorkShiftByEmployee(idEmployee);



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

        private void dtgvWorkShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click vào một ô hợp lệ không
            if (e.RowIndex >= 0 && e.RowIndex < dtgvWorkShift.Rows.Count)
            {
                DataGridViewRow row = dtgvWorkShift.Rows[e.RowIndex];
                txtIdEmployee.Text = row.Cells["IdEmployee"].Value.ToString();
                cbWork.SelectedValue = row.Cells["IdWork"].Value;
                dtpkDateWork.Value = Convert.ToDateTime(row.Cells["DateWork"].Value);
                dtpkIn.Value = row.Cells["CheckinHour"].Value != null ? Convert.ToDateTime(row.Cells["CheckinHour"].Value) : DateTime.Now;
                dtpkOut.Value = row.Cells["CheckoutHour"].Value != null ? Convert.ToDateTime(row.Cells["CheckoutHour"].Value) : DateTime.Now;
                numCountHour.Value = row.Cells["NumberHour"].Value != null ? Convert.ToDecimal(row.Cells["NumberHour"].Value) : 0;
                numSalary.Value = Convert.ToDecimal(row.Cells["Salary"].Value);
                numBonus.Value = row.Cells["Bonus"].Value != null ? Convert.ToDecimal(row.Cells["Bonus"].Value) : 0;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpkFromDate.Value.Date; // Lấy ngày, bỏ giờ
            DateTime toDate = dtpkToDate.Value.Date; // Lấy ngày, bỏ giờ

            LoadListWorkShiftByDateRange(fromDate, toDate);
        }

        private void btnPrintSalary_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem DataGridView có dữ liệu không
                if (dtgvEmployee.Rows.Count == 0)
                {
                    MessageBox.Show("Danh sách nhân viên trống! Vui lòng thêm nhân viên trước khi in phiếu lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem có dòng hiện tại không
                if (dtgvEmployee.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để in phiếu lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy ID nhân viên từ dòng hiện tại
                int idEmployee = Convert.ToInt32(dtgvEmployee.CurrentRow.Cells["IdEmployee"].Value);

                // Lấy khoảng thời gian từ DateTimePicker

                // Lấy khoảng thời gian từ DateTimePicker
                DateTime fromDate = dtpkFromDate.Value.Date;
                DateTime toDate = dtpkToDate.Value.Date;

                if (fromDate > toDate)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi stored procedure để lấy thông tin phiếu lương
                DataTable payrollData = WorkShiftBLL.GetPayroll(idEmployee, fromDate, toDate);
                if (payrollData == null || payrollData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu phiếu lương cho nhân viên này trong khoảng thời gian đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo form báo cáo và hiển thị
                frmReportViewer reportViewer = new frmReportViewer();
                string reportPath = Path.Combine(Application.StartupPath, "PayRoll", "D:\\QLTP\\GUI\\rptSalary.rdlc");
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File báo cáo không tồn tại: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                reportViewer.LoadPayrollReport(payrollData, reportPath);
                reportViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}

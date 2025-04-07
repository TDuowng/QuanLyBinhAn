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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            LoadListEmployee();
            LoadPositions();
            this.cbPosition.KeyDown += new KeyEventHandler(cbPosition_KeyDown);

            SetupAutoComplete();
        }

        #region Method
        private void LoadListEmployee()
        {
            List<EmployeeDTO> employeeList = EmployeeBLL.GetListEmployee();
            dtgvEmployee.DataSource = employeeList;
            dtgvEmployee.Columns["idEmployee"].HeaderText = "Mã nhân viên";
            dtgvEmployee.Columns["Name"].HeaderText = "Tên nhân viên";
            dtgvEmployee.Columns["Gender"].HeaderText = "Giới tính";
            dtgvEmployee.Columns["Phone"].HeaderText = "Số điện thoại";
            dtgvEmployee.Columns["Position"].HeaderText = "Chức vụ";
            dtgvEmployee.Columns["Image"].HeaderText = "Hình ảnh";
            dtgvEmployee.Columns["Image"].Visible = false;
            dtgvEmployee.Columns["TypeEmployee"].HeaderText = "Loại nhân viên";
            dtgvEmployee.RowTemplate.Height = 40;
        }
        private void LoadPositions()
        {
            List<string> positions = EmployeeBLL.GetListPositions();
            cbPosition.Items.Clear();
            cbPosition.Items.AddRange(positions.ToArray());
            cbPosition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPosition.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void ClearEmployeeDetails()
        {
            txtIdEmployee.Text = "";
            txtNameEmployee.Text = "";
            txtPhoneEmployee.Text = "";
            cbPosition.Text = "";
            radMale.Checked = true;
            ptbImageEmployee.Image = null;
            dtgvEmployee.ClearSelection();
        }

        private void SetupAutoComplete()
        {
            var food = EmployeeBLL.GetListEmployee()
                                  .Select(i => i.Name)
                                  .ToArray();

            // Cấu hình AutoComplete
            txtSearchEmployee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchEmployee.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(food);

            txtSearchEmployee.AutoCompleteCustomSource = collection;
        }


        #endregion

        #region Event
        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNameEmployee.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneEmployee.Text) ||
                    string.IsNullOrWhiteSpace(cbPosition.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidPhoneNumber(txtPhoneEmployee.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                if (EmployeeBLL.IsPhoneNumberExist(txtPhoneEmployee.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if(ptbImageEmployee.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn ảnh nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                } 
                    
                string typeEmployee = radFullTime.Checked ? "Full-time" : "Part-time";
                EmployeeDTO newEmployee = new EmployeeDTO
                {
                    Name = txtNameEmployee.Text,
                    Phone = txtPhoneEmployee.Text,
                    Position = cbPosition.Text,
                    Gender = radMale.Checked ? "Nam" : "Nữ",
                    Image = ImageToByteArray(ptbImageEmployee.Image),
                    TypeEmployee = typeEmployee

                };

                EmployeeBLL.InsertEmployee(newEmployee);
                LoadListEmployee();
                MessageBox.Show($"Thêm nhân viên '{newEmployee.Name}' thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvEmployee.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để cập nhật", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNameEmployee.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneEmployee.Text) ||
                    string.IsNullOrWhiteSpace(cbPosition.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                string phoneNumber = txtPhoneEmployee.Text.Trim();

                if (!IsValidPhoneNumber(phoneNumber))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                int selectedEmployeeId = (int)dtgvEmployee.CurrentRow.Cells["idEmployee"].Value;
                string typeEmployee = radFullTime.Checked ? "Full-time" : "Part-time";

                EmployeeDTO updatedEmployee = new EmployeeDTO
                {
                    IdEmployee = selectedEmployeeId,
                    Name = txtNameEmployee.Text,
                    Gender = radMale.Checked ? "Nam" : "Nữ",
                    Phone = phoneNumber,
                    Position = cbPosition.Text,
                    Image = ImageToByteArray(ptbImageEmployee.Image),
                    TypeEmployee = typeEmployee
                };

                EmployeeBLL.UpdateEmployee(updatedEmployee);
                LoadListEmployee();
                MessageBox.Show($"Cập nhật nhân viên '{updatedEmployee.Name}' thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvEmployee.SelectedRows == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dtgvEmployee.CurrentRow;
                string employeeName = selectedRow.Cells["Name"].Value.ToString();
                int selectedEmployeeId = (int)selectedRow.Cells["idEmployee"].Value;

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên '{employeeName}' không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    EmployeeBLL.DeleteEmployee(selectedEmployeeId);
                    LoadListEmployee();
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearEmployeeDetails();
            LoadListEmployee();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Display the image in the PictureBox
                    ptbImageEmployee.Image = Image.FromFile(filePath);
                }
            }
        }

        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvEmployee.Rows[e.RowIndex];
                txtIdEmployee.Text = selectedRow.Cells["idEmployee"].Value.ToString();
                txtNameEmployee.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPhoneEmployee.Text = selectedRow.Cells["Phone"].Value.ToString();
                cbPosition.Text = selectedRow.Cells["Position"].Value.ToString();
                if (selectedRow.Cells["Gender"].Value.ToString() == "Nam")
                {
                    radMale.Checked = true;
                }
                else
                {
                    radFemale.Checked = true;
                }
                if (selectedRow.Cells["TypeEmployee"].Value.ToString() == "Full-time")
                {
                    radFullTime.Checked = true;
                }
                else
                {
                    radPartTime.Checked = true;
                }
                object imageData = selectedRow.Cells["Image"].Value;
                if (imageData != DBNull.Value && imageData != null)
                {
                    byte[] imageBytes = (byte[])imageData;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        ptbImageEmployee.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbImageEmployee.Image = null;
                }
            }
        }

        private void cbPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newPosition = cbPosition.Text.Trim();
                if (!string.IsNullOrEmpty(newPosition) && !cbPosition.Items.Contains(newPosition))
                {
                    cbPosition.Items.Add(newPosition);
                }
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchEmployee.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                List<EmployeeDTO> employeeList = EmployeeBLL.SearchEmployee(keyword);
                dtgvEmployee.DataSource = employeeList;
                dtgvEmployee.Columns["idEmployee"].HeaderText = "Mã nhân viên";
                dtgvEmployee.Columns["Name"].HeaderText = "Tên nhân viên";
                dtgvEmployee.Columns["Gender"].HeaderText = "Giới tính";
                dtgvEmployee.Columns["Phone"].HeaderText = "Số điện thoại";
                dtgvEmployee.Columns["Position"].HeaderText = "Chức vụ";
                dtgvEmployee.Columns["Image"].HeaderText = "Hình ảnh";
                dtgvEmployee.Columns["Image"].Visible = false;
                dtgvEmployee.RowTemplate.Height = 40;
            }
            else
            {
                LoadListEmployee(); // Load all employees items if the search term is empty
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                sv.FilterIndex = 1;
                sv.FileName = "DanhSachNhanVien.xlsx";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    var list = (List<EmployeeDTO>)dtgvEmployee.DataSource;
                    DataTable dt = frmProvide.ToDataTable(list);
                    ExportFileExcel.ExportEmployeeToExcel(dt, sv.FileName);
                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi xuất file: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách nguyên liệu
                var employee = EmployeeBLL.GetListEmployee();

                // Kiểm tra nếu danh sách rỗng
                if (employee == null || !employee.Any())
                {
                    MessageBox.Show("Không có nguyên liệu nào để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo form báo cáo và hiển thị
                frmReportViewer reportViewer = new frmReportViewer();
                string reportPath = Path.Combine(Application.StartupPath, "EmployeeDaTa", "D:\\QLTP\\GUI\\rptEmployee.rdlc");
                reportViewer.LoadEmployeeReport(employee, reportPath);
                reportViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


    }
}

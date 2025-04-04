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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            LoadEmployeeIntoCombobox();
            LoadListAccount();
            LoadTypeAccountCombobox();
        }

        #region Methods

        private void LoadEmployeeIntoCombobox()
        {
            cbEmployee.DataSource = AccountBLL.GetListEmployeeWithoutAccount();
            cbEmployee.DisplayMember = "Name"; // Hiển thị tên nhân viên
            cbEmployee.ValueMember = "IdEmployee";
        }

        private void LoadListAccount()
        {
            dtgvAccount.AutoGenerateColumns = false;  // Tắt tự động sinh cột
            dtgvAccount.Columns.Clear();
            dtgvAccount.DataSource = AccountBLL.GetListAccount();
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "UserName",
                HeaderText = "Tên đăng nhập",
                Name = "UserName"
            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DisplayName",
                HeaderText = "Tên hiển thị",
                Name = "DisplayName"

            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Name = "Email"
            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NameEmployee",
                HeaderText = "Tên nhân viên",
                Name = "NameEmployee"
            });
            dtgvAccount.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TypeName",  // Hiển thị chuỗi "Admin"/"User"
                HeaderText = "Loại tài khoản",
                Name = "TypeName"
            });
            dtgvAccount.RowTemplate.Height = 40;

        }

        private void LoadTypeAccountCombobox()
        {
            cbTypeAccount.DataSource = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(0, "Admin"),
                new KeyValuePair<int, string>(1, "User")
            };
            cbTypeAccount.DisplayMember = "Value";  // Hiển thị chữ "Admin" hoặc "User"
            cbTypeAccount.ValueMember = "Key";      // Khi chọn sẽ lấy giá trị 1 hoặc 0
        }


        private void LoadPermissionsForUser(string userName)
        {
            List<int> listPermission = AccountBLL.GetPermissionsByUserName(userName);
            chkBanHang.Checked = listPermission.Contains(1);
            chkBaoCao.Checked = listPermission.Contains(2);
            chkNhanVien.Checked = listPermission.Contains(3);
            chkNguyenLieu.Checked = listPermission.Contains(4);
            chkKhachHang.Checked = listPermission.Contains(5);
            chkDanhMuc.Checked = listPermission.Contains(6);
        }

        private string GetModuleName(int moduleId)
        {
            switch (moduleId)
            {
                case 1: return "Quản lý bán hàng";
                case 2: return "Quản lý báo cáo";
                case 3: return "Quản lý nhân viên";
                case 4: return "Quản lý nguyên liệu";
                case 5: return "Quản lý khách hàng";
                case 6: return "Quản lý danh mục";
                default: return "Không xác định";
            }
        }

        private void ClearInputFields()
        {
            txtUserName.Clear();
            txtDisplayName.Clear();
            txtEmail.Clear();
            cbEmployee.SelectedIndex = -1;
            cbTypeAccount.SelectedIndex = -1;
            chkBanHang.Checked = false;
            chkBaoCao.Checked = false;
            chkNhanVien.Checked = false;
            chkNguyenLieu.Checked = false;
            chkKhachHang.Checked = false;
            chkDanhMuc.Checked = false;
        }

        #endregion

        #region Events
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string displayName = txtDisplayName.Text.Trim();
                string email = txtEmail.Text.Trim();
                int type = (int)cbTypeAccount.SelectedValue;
                int idEmployee = cbEmployee.SelectedValue != null ? (int)cbEmployee.SelectedValue : 0;

                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(displayName) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (AccountBLL.IsUserNameExist(userName))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(cbEmployee.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AccountDTO newAccount = new AccountDTO(userName, displayName, "0", email, type, idEmployee);
                if (AccountBLL.InsertAccount(newAccount))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListAccount();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string displayName = txtDisplayName.Text.Trim();
                string email = txtEmail.Text.Trim();
                int type = (int)cbTypeAccount.SelectedValue;
                int idEmployee = cbEmployee.SelectedValue != null ? (int)cbEmployee.SelectedValue : 0;
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(displayName) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AccountDTO updatedAccount = new AccountDTO(userName, displayName, "0", email, type, idEmployee);
                if (AccountBLL.UpdateAccount(updatedAccount))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListAccount();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {userName} không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (AccountBLL.DeleteAccount(userName))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListAccount();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                List<AccountDTO> employeeList = AccountBLL.SearchAccount(keyword);
                dtgvAccount.DataSource = employeeList;
                dtgvAccount.Columns["UserName"].HeaderText = "Tên đăng nhập";
                dtgvAccount.Columns["DisplayName"].HeaderText = "Tên hiển thị";
                dtgvAccount.Columns["Email"].HeaderText = "Email";
                dtgvAccount.Columns["NameEmployee"].HeaderText = "Tên nhân viên";
                dtgvAccount.Columns["TypeName"].HeaderText = "Loại tài khoản";
                dtgvAccount.RowTemplate.Height = 40;
            }
            else
            {
                LoadListAccount(); 
            }
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvAccount.Rows[e.RowIndex];
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                txtDisplayName.Text = row.Cells["DisplayName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cbTypeAccount.Text = row.Cells["TypeName"].Value.ToString();
                cbEmployee.Text = row.Cells["NameEmployee"].Value.ToString();

                // Lấy thông tin employee từ database dựa vào username
                string userName = row.Cells["UserName"].Value.ToString();
                AccountDTO account = AccountBLL.GetAccountByUserName(userName);
                if (account != null)
                {
                    cbEmployee.SelectedValue = account.IdEmployee;
                    cbTypeAccount.SelectedValue = account.Type;
                }

                LoadPermissionsForUser(userName);
            }
        }

        private void btnUpdatePermission_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản trước!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> currentPermissions = AccountBLL.GetPermissionsByUserName(userName);
            List<int> newPermissions = new List<int>();

            // Lấy danh sách quyền mới từ checkbox
            if (chkBanHang.Checked) newPermissions.Add(1);
            if (chkBaoCao.Checked) newPermissions.Add(2);
            if (chkNhanVien.Checked) newPermissions.Add(3);
            if (chkNguyenLieu.Checked) newPermissions.Add(4);
            if (chkKhachHang.Checked) newPermissions.Add(5);
            if (chkDanhMuc.Checked) newPermissions.Add(6);


            // Cập nhật quyền
            foreach (int moduleId in newPermissions)
            {
                if (!currentPermissions.Contains(moduleId))
                {
                    if (ModuleBLL.GrantPermission(userName, moduleId))
                    {
                        MessageBox.Show($"Đã cấp quyền {GetModuleName(moduleId)}","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            foreach (int moduleId in currentPermissions)
            {
                if (!newPermissions.Contains(moduleId))
                {
                    ModuleBLL.RevokePermission(userName, moduleId);
                    MessageBox.Show($"Đã hủy quyền {GetModuleName(moduleId)}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadPermissionsForUser(userName);
            MessageBox.Show("Cập nhật quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


    }
}

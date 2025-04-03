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
                new KeyValuePair<int, string>(1, "Admin"),
                new KeyValuePair<int, string>(0, "User")
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

        #endregion

        #region Events
        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Form f = new frmChangePassword();
            f.ShowDialog();
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


                string userName = row.Cells["UserName"].Value.ToString();
                LoadPermissionsForUser(userName); // Load quyền mà không thay đổi ngay
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

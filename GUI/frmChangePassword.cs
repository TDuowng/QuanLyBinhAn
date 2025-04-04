using BLL;
using DAO;
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
    public partial class frmChangePassword : Form
    {
        private string currentUserName;
        public frmChangePassword(string currentUserName)
        {
            InitializeComponent();
            this.currentUserName = currentUserName;
            LoadAccountInfo();
        }
        private void LoadAccountInfo()
        {
            AccountDTO account = AccountBLL.GetAccountByUserName(currentUserName);
            txtUserName.Text = account.UserName;
            txtDisplayName.Text = account.DisplayName;
            txtEmail.Text = account.Email ?? "";
            txtCurrentPassword.Text = account.Password;
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string displayName = txtDisplayName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string newPassword = txtNewPassword.Text.Trim();
                string confirmPassword = txtConfirmPassword.Text.Trim();

                if (string.IsNullOrEmpty(displayName))
                {
                    MessageBox.Show("Tên hiển thị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDisplayName.Focus();
                    return;
                }

                AccountDTO account = AccountBLL.GetAccountByUserName(currentUserName);
                AccountDTO updatedAccount = new AccountDTO(
                    currentUserName,
                    displayName,
                    account.Password, // Giữ nguyên mật khẩu cũ nếu không đổi
                    email,
                    account.Type,
                    account.IdEmployee
                );
                if (newPassword != "" || !string.IsNullOrEmpty(confirmPassword))
                {
                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNewPassword.Focus();
                        return;
                    }
                    updatedAccount.Password = newPassword;
                }

                if (!AccountBLL.ChangePassword(currentUserName, account.Password, newPassword))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccountInfo(); // Refresh thông tin
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại! Kiểm tra lại mật khẩu hiện tại.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

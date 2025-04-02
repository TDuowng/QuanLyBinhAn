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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbllinkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgotPassword f = new frmForgotPassword();
            f.ShowDialog();
            this.Close();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra input rỗng
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Xử lý đăng nhập với quyền
            if (AccountBLL.Login(userName, password, out List<int> permissions))
            {
                AccountDTO account = AccountBLL.GetAccountByUserName(userName);
                MessageBox.Show($"Đăng nhập thành công! Xin chào {account.DisplayName}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmTableManager f = new frmTableManager(userName, account.Type, permissions);
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                txtUserName.SelectAll();
            }

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            // Nếu nhấn Cancel thì không làm gì, ở lại form login
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}

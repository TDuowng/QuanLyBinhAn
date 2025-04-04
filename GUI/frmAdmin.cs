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
    public partial class frmAdmin : Form
    {
        private Form actionForm;
        private string currentUserName;
        private int userType;
        private List<int> userPermissions;
        public frmAdmin(string userName, int type, List<int> permissions)
        {
            InitializeComponent();
            this.currentUserName = userName;
            this.userType = type;
            this.userPermissions = permissions;
            customizeDesign();
            ApplyPermissions();

        }
        private void customizeDesign()
        {
            panelCategory.Visible = false;
            panelEmployee.Visible = false;
            panelMaterial.Visible = false;
            panelReport.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCategory.Visible == true)
                panelCategory.Visible = false;
            if (panelEmployee.Visible == true)
                panelEmployee.Visible = false;
            if (panelMaterial.Visible == true)
                panelMaterial.Visible = false;
            if (panelReport.Visible == true)
                panelReport.Visible = false;
        }
        private void showCategory(Panel caTegory) => TogglePanel(caTegory);
        private void showEmployee(Panel employee) => TogglePanel(employee);
        private void showMaterial(Panel material) => TogglePanel(material);
        private void showReport(Panel report) => TogglePanel(report);

        private void TogglePanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void ApplyPermissions()
        {
            // Admin (Type = 0) thấy hết
            if (userType == 0) return;

            // User (Type = 1) chỉ thấy nút theo quyền
            btnCategory.Visible = userPermissions.Contains(6); // Quản lý danh mục
            btnAccount.Visible = userPermissions.Contains(5); // Quản lý khách hàng
            btnEmployee.Visible = userPermissions.Contains(3); // Quản lý nhân viên
            btnMaterial.Visible = userPermissions.Contains(4); // Quản lý nguyên liệu
            btnReport.Visible = userPermissions.Contains(2);   // Quản lý báo cáo
            btnTable.Visible = userPermissions.Contains(1);    // Quản lý bán hàng
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (actionForm != null)
            {
                actionForm.Close();
            }
            actionForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private bool HasPermission(int moduleId)
        {
            return userType == 0 || userPermissions.Contains(moduleId);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (HasPermission(6)) showCategory(panelCategory);
            else MessageBox.Show("Bạn không có quyền truy cập Quản lý danh mục!");
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (HasPermission(3)) showEmployee(panelEmployee);
            else MessageBox.Show("Bạn không có quyền truy cập Quản lý nhân viên!");
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            if (HasPermission(4)) showMaterial(panelMaterial);
            else MessageBox.Show("Bạn không có quyền truy cập Quản lý nguyên liệu!");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (HasPermission(2)) showReport(panelReport);
            else MessageBox.Show("Bạn không có quyền truy cập Quản lý báo cáo!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTable(), sender);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFood(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (userType == 0)
            {
                openChildForm(new frmAccount(), sender);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập Quản lý tài khoản!");
            }
        }

        private void btnListEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee(), sender);
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCook(), sender);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCountSalary(), sender);
        }

        private void btnProvide_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProvide(), sender);
        }

        private void btnImportMaterial_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportMaterial(currentUserName), sender);
        }

        private void btnListMaterial_Click(object sender, EventArgs e)
        {
            openChildForm(new frmIngredients(), sender);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReport(), sender);
        }
    }
}

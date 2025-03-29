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
        public frmAdmin()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelCategory.Visible = false;
            panelCustomer.Visible = false;
            panelEmployee.Visible = false;
            panelMaterial.Visible = false;
            panelReport.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelCategory.Visible == true)
                panelCategory.Visible = false;
            if (panelCustomer.Visible == true)
                panelCustomer.Visible = false;
            if (panelEmployee.Visible == true)
                panelEmployee.Visible = false;
            if (panelMaterial.Visible == true)
                panelMaterial.Visible = false;
            if (panelReport.Visible == true)
                panelReport.Visible = false;
        }
        private void showCategory(Panel caTegory)
        {
            if (caTegory.Visible == false)
            {
                hideSubMenu();
                caTegory.Visible = true;
            }
            else
                caTegory.Visible = false;
        }
        private void showCustomer(Panel customer)
        {
            if (customer.Visible == false)
            {
                hideSubMenu();
                customer.Visible = true;
            }
            else
                customer.Visible = false;
        }
        private void showEmployee(Panel employee)
        {
            if (employee.Visible == false)
            {
                hideSubMenu();
                employee.Visible = true;
            }
            else
                employee.Visible = false;
        }
        private void showMaterial(Panel material)
        {
            if (material.Visible == false)
            {
                hideSubMenu();
                material.Visible = true;
            }
            else
                material.Visible = false;
        }
        private void showReport(Panel report)
        {
            if (report.Visible == false)
            {
                hideSubMenu();
                report.Visible = true;
            }
            else
                report.Visible = false;
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

        private void btnCategory_Click(object sender, EventArgs e)
        {
            showCategory(panelCategory);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showCustomer(panelCustomer);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showEmployee(panelEmployee);
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            showMaterial(panelMaterial);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showReport(panelReport);
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
            openChildForm(new frmAccount(), sender);
        }

        private void btnListEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee(), sender);
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCook(), sender);
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer(), sender);
        }

        private void btnAccumulatePoints_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAccumulatePoints(), sender);
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
            openChildForm(new frmImportMaterial(), sender);
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

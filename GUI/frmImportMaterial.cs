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
    public partial class frmImportMaterial : Form
    {
        public frmImportMaterial()
        {
            InitializeComponent();
            LoadProvide();
            LoadIngredientIntoComboBox();
        }

        #region Methods

        private void LoadProvide()
        {
            cbProvide.DataSource = ProvideBLL.GetListProvide();
            cbProvide.DisplayMember = "NameProvide";
            cbProvide.ValueMember = "IdProvide";
        }

        private void LoadIngredientIntoComboBox()
        {
            cbIngredient.DataSource = IngredientsBLL.GetListIngredients();
            cbIngredient.DisplayMember = "NameIngredient"; 
            cbIngredient.ValueMember = "IdIngredient"; 
        }

        private void LoadListImportBill()
        {
            dtgvCTHDN.DataSource = ImportBillBLL.GetListHoaDonNhap();
            dtgvCTHDN.Columns["MaHDN"].HeaderText = "Mã HĐN";
            dtgvCTHDN.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dtgvCTHDN.Columns["MaNCC"].HeaderText = "Mã NCC";
            dtgvCTHDN.Columns["TongTien"].HeaderText = "Tổng tiền";
            dtgvCTHDN.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }
        #endregion

        #region Events
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProvide.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn Nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm hóa đơn nhập trước
                int maHDN = ImportBillBLL.InsertImportBill(cbProvide.Text, DateTime.Now);
                if (maHDN == -1)
                {
                    MessageBox.Show("Thêm hóa đơn nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm các nguyên liệu vào chi tiết hóa đơn nhập
                foreach (DataGridViewRow row in dtgvCTHDN.Rows)
                {
                    bool isSuccess = ImportBillDetailBLL.InsertImportBillDetail(
                        maHDN,
                        row.Cells["NameIngredient"].Value.ToString(),
                        Convert.ToInt32(row.Cells["Count"].Value),
                        Convert.ToInt32(row.Cells["PriceIngredient"].Value),
                        row.Cells["Unit"].Value.ToString()
                    );

                    if (!isSuccess)
                    {
                        MessageBox.Show("Có lỗi khi thêm nguyên liệu: " + row.Cells["NameIngredient"].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Thêm hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListImportBill(); // Cập nhật lại danh sách hóa đơn nhập
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
        #endregion


    }
}

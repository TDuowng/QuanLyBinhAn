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
    public partial class frmIngredients : Form
    {
        public frmIngredients()
        {
            InitializeComponent();
            LoadListIngredients();
        }

        #region Methods
        private void LoadListIngredients()
        {
            dtgvIngredients.DataSource = IngredientsBLL.GetListIngredients();
            dtgvIngredients.Columns["IdIngredient"].HeaderText = "Mã nguyên liệu";
            dtgvIngredients.Columns["NameIngredient"].HeaderText = "Tên nguyên liệu";
            dtgvIngredients.Columns["PriceIngredient"].HeaderText = "Đơn giá";
            dtgvIngredients.Columns["PriceIngredient"].DefaultCellStyle.Format = "N0";
            dtgvIngredients.Columns["Count"].HeaderText = "SL Tồn";
            dtgvIngredients.Columns["Unit"].HeaderText = "ĐV Tính";
            dtgvIngredients.Columns["OverDate"].HeaderText = "Ngày hết hạn";
            dtgvIngredients.Columns["Note"].HeaderText = "Ghi chú";
            dtgvIngredients.RowTemplate.Height = 40;
            numCount.Value = IngredientsBLL.GetCountIngredients();

        }
        private void LocNguyenLieu()
        {
            bool conHang = rdoConHang.Checked;
            bool hetHang = rdoHetHang.Checked;
            bool tonKhoThap = rdoTonKhoThap.Checked;
            dtgvIngredients.DataSource = IngredientsBLL.LocNguyenLieu(conHang, hetHang, tonKhoThap);
        }

        private void ClearData()
        {
            txtIdIngredient.Text = "";
            txtName.Text = "";
            numPrice.Text = "";
            numCountTon.Text = "";
            cbUnit.Text = "";
            dtpkOverDate.Value = DateTime.Now;
            txtNote.Text = "";
            LoadListIngredients();
        }
        #endregion

        #region Events
        private void rdoConHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoConHang.Checked)
            {
                LocNguyenLieu();
            }
        }

        private void rdoHetHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHetHang.Checked)
            {
                LocNguyenLieu();
            }
        }

        private void rdoTonKhoThap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTonKhoThap.Checked)
            {
                LocNguyenLieu();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || numPrice.Text == "" || numCountTon.Text == "" || cbUnit.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                IngredientsDTO newIngredient = new IngredientsDTO
                {
                    NameIngredient = txtName.Text,
                    PriceIngredient = float.Parse(numPrice.Text),
                    Count = int.Parse(numCountTon.Text),
                    Unit = cbUnit.Text,
                    OverDate = dtpkOverDate.Value,
                    Note = txtNote.Text
                };
                if (IngredientsBLL.InsertIngredients(newIngredient))
                {
                    MessageBox.Show("Thêm nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListIngredients();
                }
                else
                {
                    MessageBox.Show("Thêm nguyên liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
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
            ClearData();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void cbProvide_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dtgvIngredients.Rows[e.RowIndex];
                txtIdIngredient.Text = row.Cells["IdIngredient"].Value.ToString();
                txtName.Text = row.Cells["NameIngredient"].Value.ToString();
                numPrice.Text = row.Cells["PriceIngredient"].Value.ToString();
                numCountTon.Text = row.Cells["Count"].Value.ToString();
                cbUnit.Text = row.Cells["Unit"].Value.ToString();
                dtpkOverDate.Value = (DateTime)row.Cells["OverDate"].Value;
                txtNote.Text = row.Cells["Note"].Value.ToString();
            }*/
        }
        #endregion


    }
}

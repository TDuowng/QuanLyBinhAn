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
    public partial class frmProvide : Form
    {
        public frmProvide()
        {
            InitializeComponent();
            LoadData();

            SetupAutoComplete();
        }

        #region Methos

        private void LoadData()
        {
            List<ProvideDTO> list = ProvideBLL.GetListProvide();
            dtgvProvide.DataSource = list;
            dtgvProvide.Columns["IdProvide"].HeaderText = "Mã NCC";
            dtgvProvide.Columns["NameProvide"].HeaderText = "Tên nhà cung cấp";
            dtgvProvide.Columns["Phone"].HeaderText = "SĐT  ";
            dtgvProvide.Columns["Address"].HeaderText = "Địa chỉ";
            dtgvProvide.Columns["Note"].HeaderText = "Ghi chú";
            dtgvProvide.Columns["Borrow"].HeaderText = "Nợ cần trả";
            dtgvProvide.Columns["Borrow"].DefaultCellStyle.Format = "N0";
            dtgvProvide.Columns["Total"].HeaderText = "Tổng mua";
            dtgvProvide.Columns["Total"].DefaultCellStyle.Format = "N0";
            dtgvProvide.RowTemplate.Height = 30;
            dtgvProvide.RowTemplate.Height = 40;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private void ClearData()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAdress.Text = "";
            txtNote.Text = "";
            numBorrow.Text = "";
            numTotal.Text = "";
        }

        private void SetupAutoComplete()
        {
            var provide = ProvideBLL.GetListProvide()
                                  .Select(i => i.NameProvide)
                                  .ToArray();

            // Cấu hình AutoComplete
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(provide);

            txtSearch.AutoCompleteCustomSource = collection;
        }
        #endregion

        #region Events
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPhone.Text == "" || txtAdress.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsValidPhoneNumber(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ProvideBLL.IsPhoneNumberExist(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                float borrow = string.IsNullOrEmpty(numBorrow.Text) ? 0 : float.Parse(numBorrow.Text);
                ProvideDTO provide = new ProvideDTO
                {
                    NameProvide = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAdress.Text,
                    Note = txtNote.Text,
                    Borrow = borrow,
                    Total = float.Parse(numTotal.Text)
                };

                // Add the new provide object to the database or list
                ProvideBLL.InsertProvide(provide);
                LoadData();
                MessageBox.Show($"Thêm nhà cung cấp '{provide.NameProvide}' thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPhone.Text == "" || txtAdress.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsValidPhoneNumber(txtPhone.Text.Trim()))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                float borrow = string.IsNullOrEmpty(numBorrow.Text) ? 0 : float.Parse(numBorrow.Text);
                ProvideDTO provide = new ProvideDTO
                {
                    IdProvide = int.Parse(txtID.Text),
                    NameProvide = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAdress.Text,
                    Note = txtNote.Text,
                    Borrow = borrow,
                    Total = float.Parse(numTotal.Text)
                };
                ProvideBLL.UpdateProvide(provide);
                LoadData();
                MessageBox.Show($"Cập nhật nhà cung cấp '{provide.NameProvide}' thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idProvide = int.Parse(txtID.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ProvideBLL.DeleteProvide(idProvide);
                    LoadData();
                    MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if(!string.IsNullOrEmpty(keyword))
            {
                List<ProvideDTO> list = ProvideBLL.SearchProvide(keyword);
                dtgvProvide.DataSource = list;
                dtgvProvide.Columns["IdProvide"].HeaderText = "Mã NCC";
                dtgvProvide.Columns["NameProvide"].HeaderText = "Tên nhà cung cấp";
                dtgvProvide.Columns["Phone"].HeaderText = "SĐT  ";
                dtgvProvide.Columns["Address"].HeaderText = "Địa chỉ";
                dtgvProvide.Columns["Note"].HeaderText = "Ghi chú";
                dtgvProvide.Columns["Borrow"].HeaderText = "Nợ cần trả";
                dtgvProvide.Columns["Total"].HeaderText = "Tổng mua";
                dtgvProvide.RowTemplate.Height = 40;
            }
            else
            {
                LoadData();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void dtgvProvide_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvProvide.Rows[e.RowIndex];
                txtID.Text = row.Cells["idProvide"].Value.ToString();
                txtName.Text = row.Cells["NameProvide"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAdress.Text = row.Cells["Address"].Value.ToString();
                txtNote.Text = row.Cells["Note"].Value.ToString();
                numBorrow.Text = row.Cells["Borrow"].Value.ToString();
                numTotal.Text = row.Cells["Total"].Value.ToString();
            }
        }

        #endregion


    }
}

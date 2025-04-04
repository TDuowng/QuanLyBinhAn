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
        private int curenImportBillId = -1;
        private string currentUserName;
        private int selectedImportBillId = -1;
        public frmImportMaterial(string userName)
        {
            InitializeComponent();
            LoadProvide();
            LoadIngredientIntoComboBox();
            LoadListImportBill();
            txtUserName.Text = userName;
            currentUserName = userName;
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
            var ingredients = IngredientsBLL.GetIngredientsWithUnitAndPrice();
            cbIngredient.DataSource = ingredients;
            cbIngredient.DisplayMember = "NameIngredient";
            cbIngredient.ValueMember = "IdIngredient";
        }

        private void LoadListImportBill()
        {
            List<ImportBillDTO> list = ImportBillBLL.GetListImportBill();
            dtgvImportBill.DataSource = list;

            dtgvImportBill.Columns["IdImportBill"].HeaderText = "Mã HĐN";
            dtgvImportBill.Columns["DateImport"].HeaderText = "Ngày nhập";
            dtgvImportBill.Columns["IdProvide"].HeaderText = "Mã nhà cung cấp";
            dtgvImportBill.Columns["IdProvide"].Visible = false;
            dtgvImportBill.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            dtgvImportBill.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";
            dtgvImportBill.Columns["NameProvide"].HeaderText = "Tên NCC";
            dtgvImportBill.Columns["Username"].HeaderText = "Người nhập";
            dtgvImportBill.Columns["DateImport"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvImportBill.RowTemplate.Height = 40;

            
        }

        private void ResetInput()
        {
            curenImportBillId = -1;
            txtIdImportBill.Text = string.Empty;
            dtpkDateImport.Value = DateTime.Now;
            cbProvide.SelectedIndex = -1;
            numPrice.Value = 0;
            txtUnit.Text = string.Empty;
            cbIngredient.SelectedIndex = -1;
        }

        private void LoadImportBillInfo(int idImportBill)
        {
            dtgvImportBillInfo.DataSource = ImportBillInfoBLL.GetListImportBillInfo(idImportBill);
        }
        #endregion

        #region Events

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim(); // Giả sử bạn có TextBox txtSearch để nhập từ khóa
            if (string.IsNullOrEmpty(keyword))
            {
                LoadListImportBill();
                return;
            }

            var list = ImportBillBLL.GetListImportBill()
                .Where(ib => ib.IdImportBill.ToString().Contains(keyword) ||
                             ib.NameProvide.ToLower().Contains(keyword.ToLower()) ||
                             ib.Username.ToLower().Contains(keyword.ToLower()))
                .ToList();

            dtgvImportBill.DataSource = list;
        }


        private void dtgvImportBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0) // Sửa thành >= 0
                {
                    DataGridViewRow selectedRow = dtgvImportBill.Rows[e.RowIndex];
                    txtIdImportBill.Text = selectedRow.Cells["IdImportBill"].Value.ToString();
                    dtpkDateImport.Text = selectedRow.Cells["DateImport"].Value.ToString();
                    cbProvide.Text = selectedRow.Cells["NameProvide"].Value.ToString();
                    txtUserName.Text = selectedRow.Cells["Username"].Value.ToString();

                    selectedImportBillId = int.Parse(txtIdImportBill.Text); // Cập nhật selectedImportBillId
                    LoadImportBillInfo(selectedImportBillId);
                }
            }

        }

        private void cbIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIngredient.SelectedValue != null)
            {
                // Lấy đối tượng IngredientsDTO được chọn
                var selectedIngredient = cbIngredient.SelectedItem as IngredientsDTO;
                if (selectedIngredient != null)
                {
                    numPrice.Text = selectedIngredient.PriceIngredient.ToString("N0");
                    txtUnit.Text = selectedIngredient.Unit;
                }
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbProvide.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProvide = (int)cbProvide.SelectedValue;
                curenImportBillId = ImportBillBLL.CreateEmptyImportBill(idProvide, txtUserName.Text);

                if (curenImportBillId != -1)
                {
                    MessageBox.Show($"Đã tạo hóa đơn nhập mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListImportBill();
                    ResetInput();
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtIdImportBill.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn nhập để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbProvide.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ImportBillDTO importBill = new ImportBillDTO
                {
                    IdImportBill = (int)Convert.ToInt32(txtIdImportBill.Text),
                    DateImport = dtpkDateImport.Value,
                    IdProvide = (int)cbProvide.SelectedValue,
                    TotalPrice = 0, // TotalPrice sẽ được trigger cập nhật
                    Username = currentUserName
                };

                if (ImportBillBLL.UpdateImportBill(importBill))
                {
                    MessageBox.Show("Cập nhật hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListImportBill();
                    ResetInput();
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idImportBill = (int)Convert.ToInt32(txtIdImportBill.Text);
                if (txtIdImportBill.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn nhập để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn nhập này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ImportBillBLL.DeleteImportBill(idImportBill))
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListImportBill();
                        ResetInput();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadListImportBill();
            ResetInput();
        }

        private void btnInsertBillInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdImportBill.Text))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn trước!");
                    return;
                }

                selectedImportBillId = int.Parse(txtIdImportBill.Text); // Cập nhật selectedImportBillId
                int idIngredient = (int)cbIngredient.SelectedValue;
                float price = float.Parse(numPrice.Text);
                int count = int.Parse(numCountImport.Text);

                var existingDetails = ImportBillBLL.GetImportBillDetails(selectedImportBillId); // Sửa thành GetImportBillDetails
                var existingDetail = existingDetails.Find(d => d.IdIngredient == idIngredient);
                Console.WriteLine($"DateImport: {dtpkDateImport.Value}");
                if (existingDetail != null)
                {
                    // Cập nhật số lượng nếu nguyên liệu đã tồn tại
                    existingDetail.Count += count;
                    ImportBillBLL.UpdateImportBill(new ImportBillDTO { IdImportBill = selectedImportBillId }, existingDetails);
                }
                else
                {
                    // Thêm mới chi tiết hóa đơn
                    var newDetail = new ImportBillInfoDTO
                    {
                        IdImportBill = selectedImportBillId,
                        IdIngredient = idIngredient,
                        Price = price,
                        Count = count
                    };
                    ImportBillBLL.InsertImportBill(new ImportBillDTO { IdImportBill = selectedImportBillId }, new List<ImportBillInfoDTO> { newDetail }); // Sửa thành AddImportBill
                }
                

                LoadImportBillInfo(selectedImportBillId);
                LoadListImportBill();
                MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnUpdateBillInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvImportBillInfo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết để sửa!");
                    return;
                }

                int idImportBillInfo = Convert.ToInt32(dtgvImportBillInfo.SelectedRows[0].Cells["IdImportBillInfo"].Value);
                int idIngredient = (int)cbIngredient.SelectedValue;
                float price = float.Parse(numPrice.Text); // Sửa lấy từ numPrice
                int count = int.Parse(numCountImport.Text);

                var updatedDetail = new ImportBillInfoDTO
                {
                    IdImportBillInfo = idImportBillInfo,
                    IdImportBill = selectedImportBillId,
                    IdIngredient = idIngredient,
                    Price = price,
                    Count = count
                };

                var details = ImportBillBLL.GetImportBillDetails(selectedImportBillId); // Sửa thành GetImportBillDetails
                details.RemoveAll(d => d.IdImportBillInfo == idImportBillInfo);
                details.Add(updatedDetail);
                ImportBillBLL.UpdateImportBill(new ImportBillDTO { IdImportBill = selectedImportBillId }, details);

                LoadImportBillInfo(selectedImportBillId);
                LoadListImportBill();
                MessageBox.Show("Sửa chi tiết hóa đơn thành công!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnDeleteBillInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvImportBillInfo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết hoá đơn để xóa!");
                    return;
                }

                int idImportBillInfo = Convert.ToInt32(dtgvImportBill.SelectedRows[0].Cells["IdImportBillInfo"].Value);
                var details = ImportBillInfoBLL.GetListImportBillInfo(selectedImportBillId);
                details.RemoveAll(d => d.IdImportBillInfo == idImportBillInfo);
                ImportBillBLL.UpdateImportBill(new ImportBillDTO { IdImportBill = selectedImportBillId }, details);

                LoadImportBillInfo(selectedImportBillId);
                LoadListImportBill();
                MessageBox.Show("Xóa chi tiết hóa đơn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnRefreshBillInfo_Click(object sender, EventArgs e)
        {
            if (selectedImportBillId > 0)
            {
                LoadImportBillInfo(selectedImportBillId);
            }
            cbIngredient.SelectedIndex = -1;
            numPrice.Value = 0;
            numCountImport.Value = 0;
        }

        #endregion


    }
}

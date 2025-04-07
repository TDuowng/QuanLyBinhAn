using BLL;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmImportIngredient : Form
    {
        private int curenImportBillId = -1;
        private string currentUserName;
        private int selectedImportBillId = -1;
        public frmImportIngredient(string userName)
        {
            InitializeComponent();
            LoadProvide();
            LoadIngredientIntoComboBox();
            LoadListImportBill();
            txtUserName.Text = userName;
            currentUserName = userName;

            SetupAutoComplete();

            dtpkDateImport.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
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
            dtgvImportBillInfo.Columns[0].HeaderText = "Mã CT HĐN";
            dtgvImportBillInfo.Columns[1].HeaderText = "Mã HĐN";
            dtgvImportBillInfo.Columns[1].Visible = false;
            dtgvImportBillInfo.Columns[2].HeaderText = "Mã nguyên liệu";
            dtgvImportBillInfo.Columns[2].Visible = false;
            dtgvImportBillInfo.Columns[3].HeaderText = "Tên nguyên liệu";
            dtgvImportBillInfo.Columns[4].HeaderText = "Đơn giá";
            dtgvImportBillInfo.Columns[4].DefaultCellStyle.Format = "N0";
            dtgvImportBillInfo.Columns[5].HeaderText = "Số lượng";
            dtgvImportBillInfo.Columns[5].DefaultCellStyle.Format = "N0";
            dtgvImportBillInfo.Columns[6].HeaderText = "Thành tiền";
            dtgvImportBillInfo.Columns[6].DefaultCellStyle.Format = "N0";

            dtgvImportBillInfo.RowTemplate.Height = 40;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadListImportBill(); // Load tất cả nếu không có từ khóa
                    return;
                }

                // Gọi phương thức từ BLL
                List<ImportBillDTO> searchResult = ImportBillBLL.SearchImportBillsByProvider(keyword);

                // Hiển thị kết quả
                dtgvImportBill.DataSource = searchResult;

                // Thông báo nếu không có kết quả
                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào cho nhà cung cấp: " + keyword,
                                  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}",
                              "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtgvImportBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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

        private void btnInsertBillInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdImportBill.Text))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn trước!");
                    return;
                }

                selectedImportBillId = int.Parse(txtIdImportBill.Text); 
                int idIngredient = (int)cbIngredient.SelectedValue;
                float price = float.Parse(numPrice.Text);
                int count = int.Parse(numCountImport.Text);

                var existingDetails = ImportBillBLL.GetImportBillDetails(selectedImportBillId);
                var existingDetail = existingDetails.Find(d => d.IdIngredient == idIngredient);

                if (existingDetail != null)
                {
                    // Cập nhật số lượng nếu nguyên liệu đã tồn tại
                    existingDetail.Count += count;
                    ImportBillInfoDAO.UpdateImportBillInfo(existingDetail); 
                }
                else
                {
                   
                    var newDetail = new ImportBillInfoDTO
                    {
                        IdImportBill = selectedImportBillId,
                        IdIngredient = idIngredient,
                        Price = price,
                        Count = count
                    };
                    ImportBillInfoDAO.InsertImportBillInfo(newDetail); 
                }


                LoadImportBillInfo(selectedImportBillId);
                LoadListImportBill();
                MessageBox.Show("Thêm chi tiết hóa đơn thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (string.IsNullOrEmpty(txtImportBillInfo.Text) ||
            dtgvImportBillInfo.Rows.Count == 0) // Thêm kiểm tra SelectedRows
                {
                    MessageBox.Show("Vui lòng chọn chi tiết để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtgvImportBillInfo.CurrentRow.Cells["IdImportBillInfo"].Value == null)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int idImportBillInfo = Convert.ToInt32(dtgvImportBillInfo.CurrentRow.Cells["IdImportBillInfo"].Value);
                int idIngredient = (int)cbIngredient.SelectedValue;
                float price = float.Parse(numPrice.Text); 
                int count = int.Parse(numCountImport.Text);

                var updatedDetail = new ImportBillInfoDTO
                {
                    IdImportBillInfo = idImportBillInfo,
                    IdImportBill = selectedImportBillId,
                    IdIngredient = idIngredient,
                    Price = price,
                    Count = count
                };

                ImportBillInfoDAO.UpdateImportBillInfo(updatedDetail); 

                LoadImportBillInfo(selectedImportBillId);
                LoadListImportBill();
                MessageBox.Show("Sửa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (dtgvImportBillInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                selectedImportBillId = int.Parse(txtIdImportBill.Text);
                int idImportBillInfo = Convert.ToInt32(dtgvImportBillInfo.CurrentRow.Cells["IdImportBillInfo"].Value);
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn nhập này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ImportBillInfoDAO.DeleteImportBillInfo(idImportBillInfo);
                    LoadImportBillInfo(selectedImportBillId);
                    LoadListImportBill();
                    MessageBox.Show("Xóa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
                
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
            LoadListImportBill();
            ResetInput();
        }

        private void dtgvImportBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvImportBill.Rows.Count) 
            {
                DataGridViewRow selectedRow = dtgvImportBillInfo.Rows[e.RowIndex];
                txtImportBillInfo.Text = selectedRow.Cells["IdImportBillInfo"].Value.ToString();
                cbIngredient.Text = selectedRow.Cells["NameIngredient"].Value.ToString();
                numCountImport.Text = selectedRow.Cells["Count"].Value.ToString();
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date;

                if (fromDate > toDate)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách hóa đơn theo khoảng ngày
                List<ImportBillDTO> filteredBills = ImportBillBLL.GetListImportBillByDateRange(fromDate, toDate);

                // Hiển thị lên DataGridView
                dtgvImportBill.DataSource = filteredBills;

                if (filteredBills.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào trong khoảng thời gian này!",
                                  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListImportBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertImportBill_Click(object sender, EventArgs e)
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

        private void btnUpdateImportBill_Click(object sender, EventArgs e)
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

        private void btnDeleteImportBill_Click(object sender, EventArgs e)
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

        #endregion


    }
}

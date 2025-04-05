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
    public partial class frmIngredients : Form
    {
        public frmIngredients()
        {
            InitializeComponent();
            LoadListIngredients();
            LoadUnits();
            LoadProvide();
            SetupAutoComplete();

            
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
            dtgvIngredients.Columns["OverDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvIngredients.Columns["Note"].HeaderText = "Ghi chú";
            dtgvIngredients.RowTemplate.Height = 40;
            numCount.Value = IngredientsBLL.GetCountIngredients();

        }


        private void LoadProvide()
        {
            cbProvide.DataSource = ProvideBLL.GetListProvide();
            cbProvide.DisplayMember = "NameProvide";
            cbProvide.ValueMember = "IdProvide";
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

        private void LoadUnits()
        {
            List<string> units = IngredientsBLL.GetAllUnit(); // Lấy danh sách đơn vị tính từ DB
            cbUnit.Items.Clear(); // Xóa danh sách cũ
            cbUnit.Items.AddRange(units.ToArray()); // Thêm lại danh sách mới
        }

        private void SetupAutoComplete()
        {
            // Lấy danh sách tên nguyên liệu để gợi ý
            var ingredients = IngredientsBLL.GetListIngredients()
                                  .Select(i => i.NameIngredient)
                                  .ToArray();

            // Cấu hình AutoComplete
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(ingredients);

            txtSearch.AutoCompleteCustomSource = collection;
        }

        private void FilterIngredients(int? filterType = null)
        {
            try
            {
                DataTable filteredData = IngredientsDAO.FilterIngredients(filterType);
                dtgvIngredients.DataSource = filteredData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}",
                              "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        private void rdoConHang_CheckedChanged(object sender, EventArgs e)
        {
            if (radConHang.Checked) FilterIngredients(1);
            dtgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void rdoHetHang_CheckedChanged(object sender, EventArgs e)
        {
            if (radHetHang.Checked) FilterIngredients(2);
            dtgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void rdoTonKhoThap_CheckedChanged(object sender, EventArgs e)
        {
            if (radTonKhoThap.Checked) FilterIngredients(3);
            dtgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IngredientsDTO updatedIngredient = new IngredientsDTO
                {
                    NameIngredient = txtName.Text,
                    PriceIngredient = (float)numPrice.Value,
                    Count = (int)numCountTon.Value,
                    Unit = cbUnit.Text,
                    OverDate = dtpkOverDate.Value,
                    Note = txtNote.Text
                };

                int newId = IngredientsBLL.InsertIngredients(updatedIngredient);
                if (newId > 0)
                {     
                    MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Nếu đơn vị tính chưa có trong combobox thì thêm vào
                    if (!cbUnit.Items.Contains(cbUnit.Text))
                    {
                        cbUnit.Items.Add(cbUnit.Text);
                    }

                    LoadListIngredients();
                }

                
                
                else
                {
                    MessageBox.Show("Thêm nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdIngredient.Text))
                {
                    MessageBox.Show("Vui lòng chọn nguyên liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IngredientsDTO updatedIngredient = new IngredientsDTO
                {
                    IdIngredient = int.Parse(txtIdIngredient.Text),
                    NameIngredient = txtName.Text,
                    PriceIngredient = (float)numPrice.Value,
                    Count = (int)numCountTon.Value,
                    Unit = cbUnit.Text,
                    OverDate = dtpkOverDate.Value,
                    Note = txtNote.Text
                };

                if (IngredientsBLL.UpdateIngredients(updatedIngredient))
                {
                    MessageBox.Show("Cập nhật nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListIngredients();
                }
                else
                {
                    MessageBox.Show("Cập nhật nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdIngredient.Text))
                {
                    MessageBox.Show("Vui lòng chọn nguyên liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                int idIngredient = int.Parse(txtIdIngredient.Text);

                if (IngredientsBLL.DeleteIngredients(idIngredient))
                {
                    MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Xóa nguyên liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            int months = (int)numMonthsAhead.Value;

            if (months <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tháng lớn hơn 0");
                return;
            }

            var ingredients = IngredientsBLL.GetExpiringIngredients(months);
            dtgvIngredients.DataSource = ingredients;
            dtgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (ingredients.Count == 0)
            {
                MessageBox.Show($"Không có nguyên liệu nào hết hạn trong {months} tháng tới");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void cbProvide_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbProvide.SelectedValue != null && cbProvide.SelectedValue is int)
                {
                    int providerId = (int)cbProvide.SelectedValue;
                    var ingredients = IngredientsBLL.GetIngredientsByProvider(providerId);
                    dtgvIngredients.DataSource = ingredients;
                    dtgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dtgvIngredients.Rows[e.RowIndex];

            txtIdIngredient.Text = row.Cells["IdIngredient"].Value.ToString();
            txtName.Text = row.Cells["NameIngredient"].Value.ToString();
            numPrice.Value = Convert.ToDecimal(row.Cells["PriceIngredient"].Value);
            numCountTon.Value = Convert.ToInt32(row.Cells["Count"].Value);
            cbUnit.Text = row.Cells["Unit"].Value.ToString();
            dtpkOverDate.Value = Convert.ToDateTime(row.Cells["OverDate"].Value);
            txtNote.Text = row.Cells["Note"].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                // Gọi phương thức tìm kiếm
                List<IngredientsDTO> searchResult = IngredientsBLL.SearchIngredients(keyword);

                // Hiển thị kết quả lên DataGridView
                dtgvIngredients.DataSource = searchResult;

                // Thông báo nếu không có kết quả
                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nguyên liệu phù hợp",
                                  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}",
                              "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}

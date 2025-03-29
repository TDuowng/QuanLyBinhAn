using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
            LoadFoodCategory();
            LoadFood();
            LoadCategoryIntoCombobox(cbCategory);
            
        }

        #region Method
        private void LoadFoodCategory()
        {
            List<CategoryDTO> categoryList = CategoryBLL.GetListCategory();
            dtgvCategory.DataSource = categoryList;
            dtgvCategory.Columns["ID"].HeaderText = "Mã loại thực đơn";
            dtgvCategory.Columns["Name"].HeaderText = "Tên loại thực đơn";
        }

        private void LoadFood()
        {
            List<FoodDTO> foodList = FoodBLL.GetListFood();
            dtgvFood.DataSource = foodList;
            dtgvFood.Columns["ID"].HeaderText = "Mã thực đơn";
            dtgvFood.Columns["Name"].HeaderText = "Tên thực đơn";
            dtgvFood.Columns["IdCategory"].Visible = false; // Hide the category ID column
            dtgvFood.Columns["CategoryName"].HeaderText = "Loại thực đơn"; // Display the category name
            dtgvFood.Columns["Price"].DefaultCellStyle.Format = "N0";
            dtgvFood.Columns["Image"].HeaderText = "Hình ảnh";
            dtgvFood.Columns["Price"].HeaderText = "Giá";
            dtgvFood.Columns["Image"].Visible = false;
            dtgvFood.RowTemplate.Height = 30;
            dtgvCategory.RowTemplate.Height = 30;
            dtgvCategory.RowHeadersWidth = 60;
            dtgvFood.RowHeadersWidth = 60;

        }


        private void LoadFoodByCategoryID(int categoryID)
        {
            List<FoodDTO> foodList = FoodBLL.GetListFoodByCategoryID(categoryID);
            dtgvFood.DataSource = foodList;
            dtgvFood.Columns["ID"].HeaderText = "Mã thực đơn";
            dtgvFood.Columns["Name"].HeaderText = "Tên thực đơn";
            dtgvFood.Columns["IdCategory"].Visible = false; // Hide the category ID column
            dtgvFood.Columns["CategoryName"].HeaderText = "Loại thực đơn"; // Display the category name
            dtgvFood.Columns["Price"].HeaderText = "Giá";
            dtgvFood.Columns["Price"].DefaultCellStyle.Format = "N0";
            dtgvFood.Columns["Image"].HeaderText = "Hình ảnh";
            dtgvFood.Columns["Image"].Visible = false;
            dtgvFood.RowTemplate.Height = 30;
            dtgvCategory.RowTemplate.Height = 30;
            dtgvCategory.RowHeadersWidth = 60;
            dtgvFood.RowHeadersWidth = 60;
        }

        private void LoadCategoryIntoCombobox(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = CategoryBLL.GetListCategory();
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        #endregion

        #region Event
        public static event Action FoodListUpdated;
        private void OnFoodListUpdated()
        {
            FoodListUpdated?.Invoke();
        }
        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameCategory.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string name = txtNameCategory.Text.Trim();

                // Kiểm tra tên có bị trùng không
                if (CategoryBLL.IsCategoryNameExists(name))
                {
                    MessageBox.Show("Tên loại thực đơn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Create a new CategoryDTO without an ID
                    CategoryDTO category = new CategoryDTO { Name = name };
                    if (CategoryBLL.InsertCategory(category))
                    {
                        MessageBox.Show("Thêm loại thực đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFoodCategory();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại thực đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvCategory.Rows[e.RowIndex];
                txtIDCategory.Text = row.Cells["ID"].Value.ToString();
                txtNameCategory.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameCategory.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtIDCategory.Text);
                string name = txtNameCategory.Text.Trim();

                // Kiểm tra tên có bị trùng không
                if (CategoryBLL.IsCategoryNameExists(name))
                {
                    MessageBox.Show("Tên loại thực đơn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    CategoryDTO category = new CategoryDTO(id, name);
                    if (CategoryBLL.UpdateCategory(category))
                    {
                        MessageBox.Show("Cập nhật loại thực đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFoodCategory();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại thực đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDCategory.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn loại thực đơn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtIDCategory.Text);

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại thực đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CategoryDTO category = new CategoryDTO(id, txtNameCategory.Text);
                    if (CategoryBLL.DeleteCategory(category))
                    {
                        MessageBox.Show("Xóa loại thực đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFoodCategory();
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại thực đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            dtgvCategory.ClearSelection();
            LoadFoodCategory();
            // Clear the text boxes
            txtIDCategory.Text = string.Empty;
            txtNameCategory.Text = string.Empty;
        }

        private void btnInsertFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameFood.Text == "" || numPrices.Text == "" || cbCategory.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ptbImageFood.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string name = txtNameFood.Text.Trim();
                int idCategory = Convert.ToInt32(cbCategory.SelectedValue);
                float price = float.Parse(numPrices.Text);
                byte[] image = null;

                if (ptbImageFood.Image != null)
                {
                    image = ImageToByteArray(ptbImageFood.Image);
                }

                if (FoodBLL.IsFoodNameExists(name))
                {
                    MessageBox.Show("Tên món ăn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FoodDTO food = new FoodDTO(0, name, idCategory, price, image);
                if (FoodBLL.InsertFood(food))
                {
                    MessageBox.Show("Thêm món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFood();
                    OnFoodListUpdated();
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameFood.Text == "" || numPrices.Text == "" || cbCategory.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ptbImageFood.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtIDFood.Text);
                string name = txtNameFood.Text.Trim();
                int idCategory = Convert.ToInt32(cbCategory.SelectedValue);
                float price = float.Parse(numPrices.Text);
                byte[] image = null;

                if (ptbImageFood.Image != null)
                {
                    image = ImageToByteArray(ptbImageFood.Image);
                }


                FoodDTO food = new FoodDTO(id, name, idCategory, price, image);
                if (FoodBLL.UpdateFood(food))
                {
                    MessageBox.Show("Cập nhật món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFood();
                    OnFoodListUpdated();
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDFood.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn món ăn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtIDFood.Text);

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (FoodBLL.DeleteFood(id))
                    {
                        MessageBox.Show("Xóa món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFood();
                    }
                    else
                    {
                        MessageBox.Show("Xóa món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshFood_Click(object sender, EventArgs e)
        {
            dtgvFood.ClearSelection();
            LoadFood();
            // Clear the text boxes
            txtIDFood.Text = string.Empty;
            txtNameFood.Text = string.Empty;
            cbCategory.Text = string.Empty;
            numPrices.Text = string.Empty;
            ptbImageFood.Image = null;
        }

        private void btnChooseImageFood_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ptbImageFood.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvFood.Rows[e.RowIndex];
                txtIDFood.Text = row.Cells["ID"].Value.ToString();
                txtNameFood.Text = row.Cells["Name"].Value.ToString();
                cbCategory.SelectedValue = row.Cells["IdCategory"].Value;
                numPrices.Text = row.Cells["Price"].Value.ToString();

                if (row.Cells["Image"].Value != DBNull.Value && row.Cells["Image"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["Image"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        ptbImageFood.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbImageFood.Image = null;
                }
            }
        }

        private void dtgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvCategory.Rows[e.RowIndex];
                int categoryID = Convert.ToInt32(row.Cells["ID"].Value);
                LoadFoodByCategoryID(categoryID);
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchFood.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                List<FoodDTO> foodList = FoodBLL.SearchFood(keyword);
                dtgvFood.DataSource = foodList;
                dtgvFood.Columns["ID"].HeaderText = "Mã thực đơn";
                dtgvFood.Columns["Name"].HeaderText = "Tên thực đơn";
                dtgvFood.Columns["IdCategory"].Visible = false; // Hide the category ID column
                dtgvFood.Columns["CategoryName"].HeaderText = "Loại thực đơn"; // Display the category name
                dtgvFood.Columns["Price"].HeaderText = "Giá";
                dtgvFood.Columns["Price"].DefaultCellStyle.Format = "N0";
                dtgvFood.Columns["Image"].HeaderText = "Hình ảnh";
                dtgvFood.Columns["Image"].Visible = false;
                dtgvFood.RowTemplate.Height = 30;
                dtgvCategory.RowHeadersWidth = 60;
                dtgvFood.RowHeadersWidth = 60;
            }
            else
            {
                LoadFood(); // Load all food items if the search term is empty
            }
        }
        #endregion


    }


}

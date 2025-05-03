using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRecipe : Form
    {
        private UcFood selectedFoodUc = null;
        private int selectedFoodId = -1; // ID của món ăn được chọn
        public BindingList<FoodDTO> FoodList { get; set; }
        public frmRecipe()
        {
            InitializeComponent();
            LoadFoodList();
            LoadIngredientIntoCombobox();
            LoadCategoryIntoCombobox();
            ConfigureQuantitiveGridView();

            // Cấu hình NumericUpDown để hỗ trợ số thập phân
            nmrQuantitive.DecimalPlaces = 2; // Số chữ số thập phân
            nmrQuantitive.Maximum = 1000.00m; 
            nmrQuantitive.Minimum = 0.00m; 
            nmrQuantitive.Increment = 0.1m; 
        }
        #region Methods
        private void LoadFoodList()
        {
            FoodList = FoodBLL.GetFoodList();
            LoadFoodIntoFlowPanel();
        }
        private void LoadFoodIntoFlowPanel()
        {
            flowFood.Controls.Clear();
            List<FoodDTO> foodList = FoodBLL.GetListFood();
            foreach (var food in foodList)
            {
                UcFood uc = new UcFood();
                uc.SetFoodData(food);
                uc.OnSelect += UcFood_OnSelect;
                flowFood.Controls.Add(uc);
            }


        }

        private void ConfigureQuantitiveGridView()
        {
            dgvQuantitive.Columns.Clear();
            dgvQuantitive.Columns.Add("TenNL", "Tên nguyên liệu");
            dgvQuantitive.Columns.Add("DinhLuong", "Định lượng");
            dgvQuantitive.Columns.Add("DVTinh", "Đơn vị tính");

            dgvQuantitive.Columns["DinhLuong"].DefaultCellStyle.Format = "N2"; // Định dạng 2 chữ số thập phân
            dgvQuantitive.RowTemplate.Height = 30;
        }

        private void LoadListQuantitative(int idFood)
        {
            dgvQuantitive.Rows.Clear();
            List<RecipeDTO> recipeList = RecipeBLL.GetListRecipeByFoodId(idFood);
            foreach (var recipe in recipeList)
            {
                string tenNL = IngredientsBLL.GetIngredientNameById(recipe.IdIngredient);
                string dvTinh = IngredientsBLL.GetUnitById(recipe.IdIngredient);
                dgvQuantitive.Rows.Add(tenNL, recipe.Quantitative, dvTinh);
            }
        }

        private void UcFood_OnSelect(object sender, EventArgs e)
        {
            UcFood uc = sender as UcFood;
            if (uc != null)
            {
                if (uc.Tag is FoodDTO food) // Kiểm tra Tag có dữ liệu
                {
                    // Bỏ chọn item cũ nếu có
                    if (selectedFoodUc != null && selectedFoodUc != uc)
                    {
                        selectedFoodUc.SetSelected(false);
                    }

                    // Chọn item mới
                    uc.SetSelected(true);
                    selectedFoodUc = uc;
                    selectedFoodId = food.ID;
                    LoadRecipeDetails(food.ID);
                    LoadListQuantitative(food.ID); // Load danh sách định lượng
                    // Cập nhật tên công thức
                    lblTitle.Text = "CÔNG THỨC NẤU " + food.Name.ToUpper();
                }
                else
                {
                    MessageBox.Show("Lỗi: UcFood không có dữ liệu FoodDTO!");
                }
            }


        }

        private void LoadIngredientIntoCombobox()
        {
            cboMainIngredient.DataSource = IngredientsBLL.GetListIngredients();
            cboMainIngredient.DisplayMember = "NameIngredient";
            cboMainIngredient.ValueMember = "IdIngredient";

            cboIngredient.DataSource = IngredientsBLL.GetListIngredients();
            cboIngredient.DisplayMember = "NameIngredient";
            cboIngredient.ValueMember = "IdIngredient";
        }

        private void LoadRecipeDetails(int foodId)
        {
            // Load công thức tương ứng
            var recipe = RecipeBLL.GetRecipeByFoodId(foodId);
            if (recipe != null)
            {
                // Hiển thị thông tin công thức
                txtIdCook.Text = recipe.IdCook.ToString(); // ID công thức
                cboMainIngredient.SelectedValue = recipe.IdIngredient;
                rikDescription.Text = recipe.Description; // Cách làm
            }
            else
            {
                // Nếu món chưa có công thức thì để trống các controls
                txtIdCook.Text = string.Empty;
                cboMainIngredient.SelectedIndex = -1;
                rikDescription.Text = string.Empty;
            }
        }

        private void ClearFormFields()
        {
            cboMainIngredient.SelectedIndex = -1;
            rikDescription.Text = string.Empty;
            txtUnit.Text = string.Empty;
            nmrQuantitive.Text = string.Empty;
            dgvQuantitive.Rows.Clear();

        }

        private void LoadCategoryIntoCombobox()
        {
            cboCategory.DataSource = CategoryBLL.GetListCategory();
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "ID";
        }
        #endregion

        #region Events
        private void btnInsertCook_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFoodUc == null || !(selectedFoodUc.Tag is FoodDTO food))
                {
                    MessageBox.Show("Vui lòng chọn món ăn trước khi thêm công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboMainIngredient.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(rikDescription.Text))
                {
                    MessageBox.Show("Vui lòng nhập các bước làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string recipeName = "CÔNG THỨC NẤU " + food.Name;
                int idFood = food.ID;
                int idIngredient = (int)cboMainIngredient.SelectedValue;
                string instructions = rikDescription.Text.Trim();
                float quantity = (float)nmrQuantitive.Value;

                RecipeDTO recipe = new RecipeDTO()
                {
                    IdDish = idFood,
                    IdIngredient = idIngredient,
                    NameCook = recipeName,
                    Quantitative = quantity,
                    Description = instructions,
                };

                if (!RecipeBLL.InsertRecipe(recipe))
                {
                    MessageBox.Show("Thêm công thức thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cập nhật lại thông tin hiển thị
                    LoadRecipeDetails(idFood);
                    LoadListQuantitative(idFood);
                }
                else
                {
                    MessageBox.Show("Thêm công thức thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCook_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFoodUc == null || !(selectedFoodUc.Tag is FoodDTO food))
                {
                    MessageBox.Show("Vui lòng chọn món ăn trước khi cập nhật công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var recipe = RecipeBLL.GetRecipeByFoodId(food.ID);
                if (recipe == null)
                {
                    MessageBox.Show("Món ăn này chưa có công thức. Vui lòng thêm công thức mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboMainIngredient.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn nguyên liệu chính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(rikDescription.Text))
                {
                    MessageBox.Show("Vui lòng nhập các bước làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((int)nmrQuantitive.Value == 0)
                {
                    MessageBox.Show("Vui lòng nhập định lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                recipe.IdIngredient = (int)cboMainIngredient.SelectedValue;
                recipe.Description = rikDescription.Text.Trim();
                recipe.Quantitative = (float)nmrQuantitive.Value;

                if (!RecipeBLL.UpdateRecipe(recipe))
                {
                    MessageBox.Show("Cập nhật công thức thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecipeDetails(food.ID);
                }
                else
                {
                    MessageBox.Show("Cập nhật công thức thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCook_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFoodUc == null || !(selectedFoodUc.Tag is FoodDTO food))
                {
                    MessageBox.Show("Vui lòng chọn món ăn trước khi xóa công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var recipe = RecipeBLL.GetRecipeByFoodId(food.ID);
                if (recipe == null)
                {
                    MessageBox.Show("Món ăn này chưa có công thức. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa công thức này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!RecipeBLL.DeleteRecipe(recipe.IdCook))
                    {
                        MessageBox.Show("Xóa công thức thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecipeDetails(food.ID);
                    }
                    else
                    {
                        MessageBox.Show("Xóa công thức thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshCook_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            LoadFoodIntoFlowPanel(); // Tải lại toàn bộ danh sách món ăn
            cboMainIngredient.SelectedIndex = -1;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (selectedFoodId == -1)
            //    {
            //        MessageBox.Show("Vui lòng chọn món ăn trước khi in công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    var recipe = RecipeBLL.GetRecipeByFoodId(selectedFoodId);
            //    if (recipe == null)
            //    {
            //        MessageBox.Show("Món ăn này chưa có công thức. Không thể in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    frmReportViewer reportViewer = new frmReportViewer();
            //    reportViewer.LoadReport(
            //        nameCook: recipe.NameCook,
            //        ingredientName: recipe.IngredientName,
            //        description: recipe.Description,
            //        quantitative: recipe.Quantitative.ToString(),
            //        reportPath: "D:\\QLTP\\GUI\\rptRecipe.rdlc"
            //        );
            //    reportViewer.ShowDialog();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSearchCook_Click(object sender, EventArgs e)
        {
            string keyword = txtSeachCook.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadFoodIntoFlowPanel(); // Tải lại toàn bộ danh sách nếu không có từ khóa
                return;
            }

            List<FoodDTO> filteredFoodList = FoodBLL.SearchFood(keyword);
            flowFood.Controls.Clear();
            foreach (var food in filteredFoodList)
            {
                UcFood uc = new UcFood();
                uc.SetFoodData(food);
                uc.OnSelect += UcFood_OnSelect;
                flowFood.Controls.Add(uc);
            }
        }
        private void cboIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIngredient.SelectedValue != null)
            {
                int idIngredient;
                // Kiểm tra và ép kiểu an toàn
                if (int.TryParse(cboIngredient.SelectedValue.ToString(), out idIngredient))
                {
                    List<FoodDTO> filteredFoodList = FoodBLL.FilterFoodByIngredient(idIngredient);
                    flowFood.Controls.Clear();
                    foreach (var food in filteredFoodList)
                    {
                        UcFood uc = new UcFood();
                        uc.SetFoodData(food);
                        uc.OnSelect += UcFood_OnSelect;
                        flowFood.Controls.Add(uc);
                    }
                }

            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue != null)
            {
                int idCategory;
                if (int.TryParse(cboCategory.SelectedValue.ToString(), out idCategory))
                {
                    List<FoodDTO> filteredFoodList = FoodBLL.GetListFoodByCategoryID(idCategory);
                    flowFood.Controls.Clear();
                    foreach (var food in filteredFoodList)
                    {
                        UcFood uc = new UcFood();
                        uc.SetFoodData(food);
                        uc.OnSelect += UcFood_OnSelect;
                        flowFood.Controls.Add(uc);
                    }
                }
            }
        }

        #endregion

        
        private void cboMainIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMainIngredient.SelectedValue != null)
            {
                var selectedIngredient = cboMainIngredient.SelectedItem as IngredientsDTO;
                if (selectedIngredient != null)
                {
                    txtUnit.Text = selectedIngredient.Unit;
                }
            }
        }

        private void dgvQuantitive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không nhấp vào header
            {
                DataGridViewRow row = dgvQuantitive.Rows[e.RowIndex];
                string tenNguyenLieu = row.Cells["TenNL"].Value?.ToString();
                float dinhLuong = float.Parse(row.Cells["DinhLuong"].Value?.ToString() ?? "0.0");
                string donViTinh = row.Cells["DVTinh"].Value?.ToString();

                // Tìm và chọn nguyên liệu trong cboIngredient
                foreach (IngredientsDTO ingredient in cboMainIngredient.Items)
                {
                    if (ingredient.NameIngredient == tenNguyenLieu)
                    {
                        cboMainIngredient.SelectedItem = ingredient;
                        break;
                    }
                }

                // Cập nhật nmrQuantitive
                nmrQuantitive.Value = (decimal)dinhLuong;

                // Cập nhật txtUnit
                txtUnit.Text = donViTinh;
            }
        }
    }
}

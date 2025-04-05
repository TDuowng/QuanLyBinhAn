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
    public partial class frmCook : Form
    {
        private UcFood selectedFoodUc = null;
        private int selectedFoodId = -1; // ID của món ăn được chọn
        public BindingList<FoodDTO> FoodList { get; set; }
        public frmCook()
        {
            InitializeComponent();
            LoadFoodList();
            LoadIngredientIntoCombobox();
            LoadCategoryIntoCombobox();
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
            var recipe = CookBLL.GetRecipeByFoodId(foodId);
            if (recipe != null)
            {
                // Hiển thị thông tin công thức
                txtIdCook.Text = recipe.IdCook.ToString(); // ID công thức
                cboMainIngredient.SelectedValue = recipe.IdIngredient;
                rikQuantitative.Text = recipe.Quantitative; // Định lượng
                rikDescription.Text = recipe.Description; // Cách làm
            }
            else
            {
                // Nếu món chưa có công thức thì để trống các controls
                txtIdCook.Text = string.Empty;
                cboMainIngredient.SelectedIndex = -1;
                rikQuantitative.Text = string.Empty;
                rikDescription.Text = string.Empty;
            }
        }

        private void ClearFormFields()
        {
            cboMainIngredient.SelectedIndex = -1;
            rikQuantitative.Text = string.Empty;
            rikDescription.Text = string.Empty;
            
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
                    MessageBox.Show("Vui lòng chọn nguyên liệu chính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(rikDescription.Text))
                {
                    MessageBox.Show("Vui lòng nhập các bước làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(rikQuantitative.Text))
                {
                    MessageBox.Show("Vui lòng nhập định lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string recipeName = "CÔNG THỨC NẤU " + food.Name;
                int idFood = food.ID;
                int idIngredient = (int)cboMainIngredient.SelectedValue;
                string quantity = rikQuantitative.Text.Trim();
                string instructions = rikDescription.Text.Trim();

                CookDTO recipe = new CookDTO()
                {
                    IdDish = idFood,
                    IdIngredient = idIngredient,
                    NameCook = recipeName,
                    Quantitative = quantity,
                    Description = instructions,
                };

                if (!CookBLL.InsertRecipe(recipe))
                {
                    MessageBox.Show("Thêm công thức thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cập nhật lại thông tin hiển thị
                    LoadRecipeDetails(idFood);
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

                var recipe = CookBLL.GetRecipeByFoodId(food.ID);
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

                if (string.IsNullOrWhiteSpace(rikQuantitative.Text))
                {
                    MessageBox.Show("Vui lòng nhập định lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                recipe.IdIngredient = (int)cboMainIngredient.SelectedValue;
                recipe.Description = rikDescription.Text.Trim();
                recipe.Quantitative = rikQuantitative.Text.Trim();

                if (!CookBLL.UpdateRecipe(recipe))
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
                var recipe = CookBLL.GetRecipeByFoodId(food.ID);
                if (recipe == null)
                {
                    MessageBox.Show("Món ăn này chưa có công thức. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa công thức này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!CookBLL.DeleteRecipe(recipe.IdCook))
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


    }
}

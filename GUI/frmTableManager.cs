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

namespace GUI
{
    public partial class frmTableManager : Form
    {
        public BindingList<FoodDTO> FoodList { get; set; }
        public frmTableManager()
        {
            InitializeComponent();
            customizeDesign();
            LoadFoodList();
            frmFood.FoodListUpdated += LoadFoodList;
        }
        #region Methods
        private void LoadFoodList()
        {
            FoodList = FoodBLL.GetFoodList();
            LoadFoodIntoFlowPanel();
        }
        private void LoadFoodByCategory(int categoryId)
        {
            FoodList = new BindingList<FoodDTO>(FoodBLL.GetListFoodByCategoryID(categoryId));
            LoadFoodIntoFlowPanel();
        }
        private void LoadFoodIntoFlowPanel()
        {
            flowFood.Controls.Clear();
            foreach (var food in FoodList)
            {
                UcFood uc = new UcFood();
                uc.SetFoodData(food.Name, food.Price, food.Image);
                flowFood.Controls.Add(uc);
            }
        }

        private void LoadCategoryButtons()
        {
            List<CategoryDTO> categories = CategoryBLL.GetListCategory(); // Lấy danh sách loại thực đơn từ database
            flowCategory.Controls.Clear(); // Xóa các Button cũ

            foreach (var category in categories)
            {
                Button btn = new Button();
                btn.Text = category.Name; // Hiển thị tên loại thực đơn
                btn.Tag = category.ID; // Gán ID danh mục vào Tag
                btn.Width = 238;
                btn.Height = 51;
                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat; // Ẩn viền button
                btn.FlatAppearance.BorderSize = 0; // Loại bỏ border
                btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                btn.TextAlign = ContentAlignment.MiddleLeft; // Chữ căn trái
                btn.Padding = new Padding(30, 0, 0, 0); // Khoảng cách giữa chữ và viền bên trái

                // Gán sự kiện Click
                btn.Click += BtnCategory_Click;

                // Thêm hiệu ứng hover (di chuột vào button)
                btn.MouseEnter += (s, e) => { btn.BackColor = Color.LightGray; };
                btn.MouseLeave += (s, e) => { btn.BackColor = Color.White; };

                flowCategory.Controls.Add(btn); // Thêm Button vào giao diện
            }
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;


            if (btn != null)
            {
                int categoryId = (int)btn.Tag; // Lấy ID danh mục từ Tag
                LoadFoodByCategory(categoryId); // Gọi hàm hiển thị món ăn
            }
        }

        private void btnCategoryToggle_Click(object sender, EventArgs e)
        {
            showCategory(flowCategory);
        }

        private void customizeDesign()
        {
            flowCategory.Visible = false;
            flowTable.Visible = false;

        }
        private void hideSubMenu()
        {
            if (flowCategory.Visible == true)
                flowCategory.Visible = false;
            if (flowTable.Visible == true)
                flowTable.Visible = false;
        }
        public static Image ByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                throw new ArgumentException("Dữ liệu ảnh trống hoặc null!");

            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while converting byte array to image: " + ex.Message);
                return null;
            }
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
        private void showTable(Panel customer)
        {
            if (customer.Visible == false)
            {
                hideSubMenu();
                customer.Visible = true;
            }
            else
                customer.Visible = false;
        }
        #endregion

        #region Event
        private void btnCategory_Click(object sender, EventArgs e)
        {
            showCategory(flowCategory);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            showTable(flowTable);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Form form = new frmAdmin();
            form.Show();


        }
        #endregion

        private void frmTableManager_Load(object sender, EventArgs e)
        {
            LoadCategoryButtons();
        }
    }
}

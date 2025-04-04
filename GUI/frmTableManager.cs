using BLL;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTableManager : Form, IDropTarget, ISynchronizeInvoke, IWin32Window, IBindableComponent, IComponent, IDisposable, IContainerControl
    {
        private string currentUserName;
        private int userType;
        private List<int> userPermissions;
        private int selectedTableId = -1;
        private UcTable selectedTableUc = null;
        public BindingList<TableDTO> TableList { get; set; }

        private DataGridViewRow selectedFoodRow = null;
        public frmTableManager(string userName, int type, List<int> permissions)
        {
            InitializeComponent();
            LoadTableList();
            frmTable.TableListUpdated += LoadTableList;

            this.currentUserName = userName;
            this.userType = type;
            this.userPermissions = permissions;
            ApplyPermissions();
            LoadCategoryComboBox();
            SetupSidebar();
            LoadAllFoods();

            LoadTargetTableComboBox();

            dgvFood.SelectionChanged += DgvFood_SelectionChanged;
        }

        private void DgvFood_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                selectedFoodRow = dgvFood.SelectedRows[0];
            }
            else
            {
                selectedFoodRow = null;
            }
        }



        #region Methods

        private void SetupSidebar()
        {
            btnTable.Click += BtnTable_Click;
        }

        
        private void BtnTable_Click(object sender, EventArgs e)
        {
            LoadTables();
        }
        private void LoadTables()
        {
            List<TableDTO> tableList = TableBLL.GetListTable();
            flowTable.Controls.Clear();
            foreach (TableDTO table in tableList)
            {
                UcTable uc = new UcTable();
                uc.SetTableData(table.TableName, table.Status);
                uc.Tag = table;

                uc.OnSelect += UcTable_Click;
                flowTable.Controls.Add(uc);
            }
        }
        private void LoadAllFoods()
        {
            List<FoodDTO> foodList = FoodBLL.GetListFood();

            dgvFood.DataSource = foodList.Select(f => new
            {
                f.ID,
                f.Name,
                f.Price
            }).ToList();

            // Đặt tên cột cho DataGridView
            if (dgvFood.Columns.Contains("ID"))
                dgvFood.Columns["ID"].HeaderText = "Mã món";
            if (dgvFood.Columns.Contains("Name"))
                dgvFood.Columns["Name"].HeaderText = "Tên món";
            if (dgvFood.Columns.Contains("Price"))
                dgvFood.Columns["Price"].HeaderText = "Đơn giá";
                dgvFood.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvFood.RowTemplate.Height = 40;

            selectedFoodRow = null;
            dgvFood.ClearSelection();
        }

        private void LoadTargetTableComboBox()
        {
            cboTargetTable.Items.Clear();
            if (TableList != null)
            {
                foreach (var table in TableList)
                {
                    cboTargetTable.Items.Add(new KeyValuePair<int, string>(table.IdTable, table.TableName));
                }
            }
            cboTargetTable.DisplayMember = "Value";
            cboTargetTable.ValueMember = "Key";
            cboTargetTable.SelectedIndex = -1;
        }

        private void LoadCategoryComboBox()
        {
            cboCategory.Items.Clear();
            List<CategoryDTO> categories = CategoryBLL.GetListCategory();

            // Thêm một item "Tất cả" vào đầu danh sách
            CategoryDTO allCategory = new CategoryDTO { ID = -1, Name = "Tất cả" };
            categories.Insert(0, allCategory);

            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "ID";
            cboCategory.SelectedIndex = 0; // Chọn mục "Tất cả" mặc định
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == -1) return;

            int categoryId = (int)cboCategory.SelectedValue;

            if (categoryId == -1) // Nếu chọn "Tất cả"
            {
                LoadAllFoods();
            }
            else // Nếu chọn một loại cụ thể
            {
                List<FoodDTO> foodList = FoodBLL.GetListFoodByCategoryID(categoryId);

                dgvFood.DataSource = foodList.Select(f => new
                {
                    f.ID,
                    f.Name,
                    f.Price
                }).ToList();

                // Đặt tên cột cho DataGridView
                if (dgvFood.Columns.Contains("ID"))
                    dgvFood.Columns["ID"].HeaderText = "Mã món";
                if (dgvFood.Columns.Contains("Name"))
                    dgvFood.Columns["Name"].HeaderText = "Tên món";
                if (dgvFood.Columns.Contains("Price"))
                    dgvFood.Columns["Price"].HeaderText = "Đơn giá";
                dgvFood.RowTemplate.Height = 40;

                selectedFoodRow = null;
                dgvFood.ClearSelection();
            }
        }

        private void ApplyPermissions()
        {

            btnAdmin.Visible = (userType == 0 || userPermissions.Count > 0); // Admin hoặc User có quyền mới thấy nút
        }

        private void LoadTableList()
        {
            TableList = TableBLL.GetTableList();
            LoadTableIntoFlowPanel();
        }

        private void LoadTableIntoFlowPanel()
        {
            flowTable.Controls.Clear();
            foreach (var table in TableList)
            {
                UcTable uc = new UcTable();
                uc.SetTableData(table.TableName, table.Status);
                uc.Tag = table;
                uc.OnSelect += UcTable_Click;
                flowTable.Controls.Add(uc);
            }
        }

        private void UcTable_Click(object sender, EventArgs e)
        {
            UcTable uc = sender as UcTable;
            if (uc != null)
            {
                if (uc.Tag is TableDTO table)  // Kiểm tra Tag có dữ liệu không
                {
                    if (selectedTableUc != null && selectedTableUc != uc)
                    {
                        selectedTableUc.SetSelected(false);
                    }

                    uc.SetSelected(true);
                    selectedTableUc = uc;

                    selectedTableId = table.IdTable;  // Gán đúng MaBan
                    lsvBill.Tag = table;

                    ShowBill(selectedTableId);
                }
                else
                {
                    MessageBox.Show("Lỗi: UcTable không có TableDTO!");
                }
            }
        }

        private void ShowBill(int tableId)
        {
            lsvBill.Items.Clear();
            int billId = BillBLL.GetUncheckBillIDByTableID(tableId);
            float totalPrice = 0;

            if (billId != -1)
            {
                List<BillDetailDTO> billDetails = BillDetailBLL.GetBillDetailsByBillId(billId);
                foreach (BillDetailDTO detail in billDetails)
                {
                    FoodDTO food = FoodBLL.GetListFood().FirstOrDefault(f => f.ID == detail.FoodId);
                    if (food != null)
                    {
                        ListViewItem item = new ListViewItem(food.Name);
                        item.SubItems.Add(detail.Quantity.ToString());
                        item.SubItems.Add(food.Price.ToString("N0"));
                        item.SubItems.Add((food.Price * detail.Quantity).ToString("N0"));
                        totalPrice += food.Price * detail.Quantity;
                        lsvBill.Items.Add(item);
                    }
                }
            }

            lblTotal.Text = totalPrice.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            UpdateFinalPrice();
        }

        private void UpdateFinalPrice()
        {
            string totalText = lblTotal.Text.Replace(" VNĐ", "").Trim();
            float totalPrice = float.Parse(totalText.Replace(".", ""), CultureInfo.GetCultureInfo("vi-VN"));

            int discount = (int)nmrDiscount.Value;

            // Tính số tiền giảm giá
            float discountAmount = totalPrice * discount / 100;

            // Hiển thị số tiền giảm giá
            lblDiscountAmount.Text = discountAmount.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";

            // Tính giá cuối cùng
            float finalPrice = totalPrice - discountAmount;
            lblFinalPrice.Text = finalPrice.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
        }


        private void UpdateTableStatus()
        {
            if (selectedTableUc != null)
            {
                TableDTO table = selectedTableUc.Tag as TableDTO;
                string newStatus = BillBLL.GetUncheckBillIDByTableID(selectedTableId) != -1 ? "Có người" : "Bàn trống";
                table.Status = newStatus;
                selectedTableUc.SetTableData(table.TableName, newStatus);
                selectedTableUc.SetSelected(true);
            }
        }

        #endregion

        private void LoadBillInfo(int tableId)
        {
            
        }


        #region Event


        private void btnTable_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }
        private void frmTableManager_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (userType == 0 || userPermissions.Count > 0) // Admin hoặc có ít nhất 1 quyền
            {
                frmAdmin adminForm = new frmAdmin(currentUserName, userType, userPermissions);
                adminForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào quản lý!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (selectedTableId == -1)
            {
                MessageBox.Show("Hãy chọn bàn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBill = BillBLL.GetUncheckBillIDByTableID(selectedTableId);
            if (idBill != -1)
            {
                float totalPrice = BillBLL.CalculateTotalPrice(idBill);
                int discount = (int)nmrDiscount.Value;
                float finalPrice = totalPrice - (totalPrice * discount / 100);

                TableDTO table = selectedTableUc.Tag as TableDTO;
                if (MessageBox.Show($"Bạn có chắc muốn thanh toán hóa đơn cho {table.TableName}?\nTổng tiền: {finalPrice:N0} VNĐ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillBLL.CheckOut(idBill, discount, finalPrice, "Thanh toán từ btnCheckout");
                    ShowBill(selectedTableId);
                    selectedTableUc.SetTableData(table.TableName, "Bàn trống");
                    selectedTableUc.SetSelected(false);
                    selectedTableId = -1;
                    selectedTableUc = null;
                    nmrDiscount.Value = 0;
                }
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (selectedTableId == -1)
            {
                MessageBox.Show("Hãy chọn bàn trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedFoodRow == null)
            {
                MessageBox.Show("Hãy chọn một món từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)nmrQuantity.Value;
            // Lấy món được chọn từ DataGridView
            int foodId = (int)selectedFoodRow.Cells["ID"].Value;
            FoodDTO food = FoodBLL.GetListFood().FirstOrDefault(f => f.ID == foodId);

            if (food == null)
            {
                MessageBox.Show("Không tìm thấy món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idBill = BillBLL.GetUncheckBillIDByTableID(selectedTableId);
            if (idBill == -1)
            {
                BillBLL.InsertBill(selectedTableId, currentUserName, "Thêm món từ DataGridView");
                idBill = BillBLL.GetUncheckBillIDByTableID(selectedTableId);
            }

            BillDetailBLL.InsertOrUpdateBillDetail(idBill, food.ID, quantity);
            ShowBill(selectedTableId);
            UpdateTableStatus();
            nmrQuantity.Value = 0;

            selectedFoodRow = null;
            dgvFood.ClearSelection();
        }

        private void nmrDiscount_ValueChanged(object sender, EventArgs e)
        {
            UpdateFinalPrice();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (selectedTableId == -1)
            {
                MessageBox.Show("Hãy chọn bàn nguồn trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTargetTable.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn bàn đích để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetTableId = ((KeyValuePair<int, string>)cboTargetTable.SelectedItem).Key;
            TableDTO sourceTable = TableList.FirstOrDefault(t => t.IdTable == selectedTableId);
            TableDTO targetTable = TableList.FirstOrDefault(t => t.IdTable == targetTableId);

            if (sourceTable == null || targetTable == null)
            {
                MessageBox.Show("Bàn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn chuyển {sourceTable.TableName} qua {targetTable.TableName} không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableBLL.SwitchTable(selectedTableId, targetTableId, currentUserName);
                LoadTableList();
                if (lsvBill.Tag != null)
                    ShowBill(selectedTableId);
            }
        }

        private void btnMergeTables_Click(object sender, EventArgs e)
        {
            if (selectedTableId == -1)
            {
                MessageBox.Show("Hãy chọn bàn nguồn trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTargetTable.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn bàn đích để gộp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetTableId = ((KeyValuePair<int, string>)cboTargetTable.SelectedItem).Key;
            TableDTO sourceTable = TableList.FirstOrDefault(t => t.IdTable == selectedTableId);
            TableDTO targetTable = TableList.FirstOrDefault(t => t.IdTable == targetTableId);

            if (sourceTable == null || targetTable == null)
            {
                MessageBox.Show("Bàn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedTableId == targetTableId)
            {
                MessageBox.Show("Không thể gộp bàn giống nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn gộp bàn {sourceTable.TableName} vào bàn {targetTable.TableName}?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableBLL.MergerTables(selectedTableId, targetTableId, currentUserName);
                LoadTableList();
                if (lsvBill.Tag != null)
                    ShowBill(selectedTableId);
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                List<FoodDTO> foodList = FoodBLL.SearchFood(keyword);
                dgvFood.DataSource = foodList;
                dgvFood.Columns["ID"].HeaderText = "Mã thực đơn";
                dgvFood.Columns["Name"].HeaderText = "Tên thực đơn";
                dgvFood.Columns["IdCategory"].Visible = false; 
                dgvFood.Columns["CategoryName"].HeaderText = "Loại thực đơn";
                dgvFood.Columns["CategoryName"].Visible = false;
                dgvFood.Columns["Price"].HeaderText = "Đơn giá";
                dgvFood.Columns["Price"].DefaultCellStyle.Format = "N0";
                dgvFood.Columns["Image"].HeaderText = "Hình ảnh";
                dgvFood.Columns["Image"].Visible = false;
                dgvFood.RowTemplate.Height = 40;
            }
            else
            {
                LoadAllFoods(); // Load all food items if the search term is empty
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword f = new frmChangePassword(currentUserName);
            f.ShowDialog();
        }
    }
}

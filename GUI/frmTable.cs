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
    public partial class frmTable : Form
    {
        public BindingList<TableDTO> TableList { get; set; }
        public frmTable()
        {
            InitializeComponent();
            LoadListTable();
            LoadStatus();
            LoadTableList();
            frmTable.TableListUpdated += LoadTableList;
        }

        #region Methods
        private void LoadListTable()
        {
            dtgvTable.DataSource = TableBLL.GetListTable();
            dtgvTable.Columns["idTable"].HeaderText = "Mã bàn";
            dtgvTable.Columns["TableName"].HeaderText = "Tên bàn";
            dtgvTable.Columns["Status"].HeaderText = "Trạng thái";
            dtgvTable.Columns["Floor"].HeaderText = "Tầng";
            dtgvTable.RowTemplate.Height = 40;
        }

        private void LoadStatus()
        {
            List<string> listStatus = new List<string> { "Bàn trống", "Có người", "Sửa chữa" };
            cbStatus.DataSource = listStatus;
            cbStatus.SelectedIndex = -1;
        }

        private void ClearData()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtSearch.Text = "";
            cbStatus.Text = "";
            LoadListTable();
            LoadTableList();
        }

        private void SelectStatus()
        {
            string status = "";
            if (radTrong.Checked) status = "Bàn trống";
            else if (radConguoi.Checked) status = "Có người";
            else if (radRepair.Checked) status = "Sửa chữa";

            dtgvTable.DataSource = TableBLL.GetTableByStatus(status);
        }

        private void SelectFloor()
        {
            int floor = (int)numLocTang.Value;
            dtgvTable.DataSource = TableBLL.GetTableByFloor(floor);
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
                uc.OnSelect += UcTable_OnSelect;
                flowTable.Controls.Add(uc);
            }
        }

        private void UcTable_OnSelect(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region Events
        public static event Action TableListUpdated;
        private void OnTableListUpdated()
        {
            TableListUpdated?.Invoke();
        }
        private void dtgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvTable.Rows[e.RowIndex];
                txtID.Text = row.Cells["idTable"].Value.ToString();
                txtName.Text = row.Cells["TableName"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();
                numFloor.Text = row.Cells["Floor"].Value != null ? row.Cells["Floor"].Value.ToString() : "";
            } 
                
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string tablename = txtName.Text;
                string status = cbStatus.Text;
                int? floor = (int)numFloor.Value;
                if (txtName.Text == "" || cbStatus.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TableDTO table = new TableDTO
                    {
                        TableName = tablename,
                        Status = status,
                        Floor = floor
                    };
                    if (TableBLL.IsTableNameExists(tablename))
                    {
                        MessageBox.Show("Bàn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (TableBLL.InsertTable(table))
                    {
                        MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListTable();
                        OnTableListUpdated();
                    }
                    else
                    {
                        MessageBox.Show("Thêm bàn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cbStatus.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtID.Text);
                string tableName = txtName.Text;
                string status = cbStatus.Text;
                int floor = (int)numFloor.Value;

                TableDTO table = new TableDTO
                {
                    IdTable = id,
                    TableName = tableName,
                    Status = status,
                    Floor = floor
                };

                if (TableBLL.UpdateTable(table))
                {
                    MessageBox.Show("Cập nhật bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListTable();
                    OnTableListUpdated();
                }
                else
                {
                    MessageBox.Show("Cập nhật bàn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
    {
        if (string.IsNullOrEmpty(txtID.Text))
        {
            MessageBox.Show("Vui lòng chọn bàn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int id = int.Parse(txtID.Text);

        DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bàn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (TableBLL.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Xóa bàn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void radTrong_CheckedChanged(object sender, EventArgs e)
        {
            if (radTrong.Checked) SelectStatus();
        }

        private void radConguoi_CheckedChanged(object sender, EventArgs e)
        {
            if (radConguoi.Checked) SelectStatus();
        }

        private void radRepair_CheckedChanged(object sender, EventArgs e)
        {
            if (radRepair.Checked) SelectStatus();
        }

        private void numLocTang_ValueChanged(object sender, EventArgs e)
        {
            SelectFloor();
        }
        #endregion


    }
}

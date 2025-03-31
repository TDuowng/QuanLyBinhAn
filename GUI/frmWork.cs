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
    public partial class frmWork : Form
    {
        public frmWork()
        {
            InitializeComponent();
            LoadListWork();
        }

        #region Methods
        private void LoadListWork()
        {
            List<WorkDTO> workList = WorkBLL.GetListWork();
            dtgvWork.DataSource = workList;
            dtgvWork.Columns["idWork"].HeaderText = "Mã ca";
            dtgvWork.Columns["NameWork"].HeaderText = "Tên ca";
            dtgvWork.Columns["DateIn"].HeaderText = "Giờ bắt đầu";
            dtgvWork.Columns["DateOut"].HeaderText = "Giờ kết thúc";
            dtgvWork.Columns["DateIn"].DefaultCellStyle.Format = "HH:mm";
            dtgvWork.Columns["DateOut"].DefaultCellStyle.Format = "HH:mm";
            dtgvWork.Columns["NumberHour"].HeaderText = "Số giờ làm";
            dtgvWork.Columns["Salary"].HeaderText = "Mức lương";
            dtgvWork.RowTemplate.Height = 30;
        }

        private void CountHour()
        {
            try
            {
                // Lấy giá trị từ DateTimePicker
                DateTime gioBatDau = dtpkDateIn.Value;
                DateTime gioKetThuc = dtpkDateOut.Value;

                // Đảm bảo giờ kết thúc lớn hơn giờ bắt đầu
                if (gioKetThuc <= gioBatDau)
                {
                    MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính số giờ làm
                TimeSpan thoiGianLam = gioKetThuc - gioBatDau;

                // Gán vào NumericUpDown
                numCountHour.Value = (decimal)thoiGianLam.TotalHours;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearText()
        {
            txtIdWord.Text = "";
            txtNameWork.Text = "";
            dtpkDateIn.Text = "";
            dtpkDateOut.Text = "";
            numCountHour.Text = "";
            numSalary.Text = "";
        }
        #endregion

        #region Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertWork_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameWork.Text == "" || dtpkDateIn.Text == "" || dtpkDateOut.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime gioBatDau = DateTime.Parse(dtpkDateIn.Text);
                DateTime gioKetThuc = DateTime.Parse(dtpkDateOut.Text);
                double soGioLam = (gioKetThuc - gioBatDau).TotalHours;

                WorkDTO work = new WorkDTO(0, txtNameWork.Text, gioBatDau, gioKetThuc, soGioLam, float.Parse(numSalary.Text));
                if (WorkBLL.InsertWork(work))
                {
                    MessageBox.Show("Thêm ca làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListWork();
                }
                else
                {
                    MessageBox.Show("Thêm ca làm việc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateWork_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameWork.Text == "" || dtpkDateIn.Text == "" || dtpkDateOut.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime gioBatDau = dtpkDateIn.Value;
                DateTime gioKetThuc = dtpkDateOut.Value;
                double soGioLam = (gioKetThuc - gioBatDau).TotalHours;

                WorkDTO work = new WorkDTO (
                    int.Parse(txtIdWord.Text),
                    txtNameWork.Text,
                    gioBatDau,
                    gioKetThuc,
                    soGioLam,
                    float.Parse(numSalary.Text));
                
                if (WorkBLL.UpdateWork(work))
                {
                    MessageBox.Show("Cập nhật ca làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListWork();
                }
                else
                {
                    MessageBox.Show("Cập nhật ca làm việc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteWork_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdWord.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (WorkBLL.DeleteWork(int.Parse(txtIdWord.Text)))
                {
                    MessageBox.Show("Xóa ca làm việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListWork();
                }
                else
                {
                    MessageBox.Show("Xóa ca làm việc thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void dtpkDateIn_ValueChanged(object sender, EventArgs e)
        {
            CountHour();
        }

        private void dtpkDateOut_ValueChanged(object sender, EventArgs e)
        {
            CountHour();
        }

        private void dtgvWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvWork.Rows.Count)
            {
                DataGridViewRow row = dtgvWork.Rows[e.RowIndex];
                txtIdWord.Text = row.Cells["idWork"].Value.ToString();
                txtNameWork.Text = row.Cells["NameWork"].Value.ToString();
                dtpkDateIn.Text = row.Cells["DateIn"].Value.ToString();
                dtpkDateOut.Text = row.Cells["DateOut"].Value.ToString();
                numCountHour.Text = row.Cells["NumberHour"].Value.ToString();
                numSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }
        #endregion


    }
}

using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmReport : Form
    {
        int currentPage = 1;
        int totalPages = 0;
        int pageSize = 14;
        DateTime checkIn;
        DateTime checkOut;

        public frmReport()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            CalculateTotalPages();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            dtpkFromDate.CustomFormat = "dd/MM/yyyy";
            dtpkToDate.CustomFormat = "dd/MM/yyyy";
            dtpkDateRevenue.CustomFormat = "dd/MM/yyyy";
            dtgvBill.ScrollBars = ScrollBars.None;
            LoadRevenueByDayChart();
            txtPage.Text = $"{currentPage}/{totalPages}";

            LoadRevenueByDate(DateTime.Today);

            // Đăng ký sự kiện khi thay đổi ngày ở DateTimePicker doanh thu
            dtpkDateRevenue.ValueChanged += DtpkDateRevenue_ValueChanged;
        }


        #region Methods
        private void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        private void DtpkDateRevenue_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenueByDate(dtpkDateRevenue.Value);
        }
        private void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource =BillBLL .GetListBillByDate(checkIn, checkOut);
            FormatBillGridView();
        }
        private void FormatBillGridView()
        {
            dtgvBill.RowTemplate.Height = 40;

            if (dtgvBill.Columns.Contains("Ngày vào"))
                dtgvBill.Columns["Ngày vào"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            if (dtgvBill.Columns.Contains("Ngày ra"))
                dtgvBill.Columns["Ngày ra"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            if (dtgvBill.Columns.Contains("Tổng tiền"))
                dtgvBill.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";
        }
        private void LoadDataByPage()
        {
            checkIn = dtpkFromDate.Value.Date;
            // Thêm thời gian cuối ngày cho checkOut để bao gồm cả ngày được chọn
            checkOut = dtpkToDate.Value.Date.AddDays(1).AddSeconds(-1);

            DataTable data = BLL.BillBLL.GetListBillByDateAndPage(checkIn, checkOut, currentPage, pageSize);
            dtgvBill.DataSource = data;
            FormatBillGridView();

            txtPage.Text = $"{currentPage}/{totalPages}";
            UpdateButtonState();

        }

        private void CalculateTotalPages()
        {
            checkIn = dtpkFromDate.Value.Date;
            // Thêm thời gian cuối ngày cho checkOut để bao gồm cả ngày được chọn
            checkOut = dtpkToDate.Value.Date.AddDays(1).AddSeconds(-1);

            int totalRows = BLL.BillBLL.GetTotalBillRows(checkIn, checkOut);
            totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
            if (totalPages == 0) totalPages = 1; // Để tránh lỗi khi không có dữ liệu

            // Đảm bảo currentPage hợp lệ
            if (currentPage > totalPages)
                currentPage = totalPages;
        }


        private void UpdateButtonState()
        {
            btnFirst.Enabled = currentPage > 1;
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        private void LoadRevenueByDate(DateTime date)
        {
            // Lấy doanh thu từ BLL
            decimal revenue = BillBLL.GetRevenueByDate(date);

            // Hiển thị doanh thu với định dạng tiền tệ
            txtRevenue.Text = revenue.ToString("N0") + " VNĐ";
        }

        private void LoadRevenueByDayChart()
        {
            try
            {
                // Lấy năm và tháng hiện tại
                int currentYear = DateTime.Now.Year; // 2025
                int currentMonth = DateTime.Now.Month; // 4 (tháng 4)

                // Lấy dữ liệu doanh thu theo ngày
                DataTable revenueData = SalesBLL.GetRevenueByDay(currentYear, currentMonth);

                // Xóa các series cũ (nếu có)
                chartRevenueByDay.Series.Clear();

                // Tạo series cho biểu đồ đường
                Series series = new Series("Doanh thu")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3, // Độ dày của đường
                    Color = Color.DarkRed // Màu sắc của đường
                };

                // Lấy ngày hiện tại để giới hạn dữ liệu
                int currentDay = DateTime.Now.Day; // 7 (ngày 7)

                // Thêm dữ liệu vào series
                for (int day = 1; day <= currentDay; day++)
                {
                    // Tìm doanh thu của ngày hiện tại trong dữ liệu
                    DataRow[] rows = revenueData.Select($"Day = {day}");
                    double revenue = 0;
                    if (rows.Length > 0)
                    {
                        revenue = Convert.ToDouble(rows[0]["TotalRevenue"]);
                    }

                    // Thêm điểm dữ liệu vào series
                    DataPoint point = new DataPoint();
                    point.SetValueXY(day, revenue);
                    point.Label = revenue.ToString("N0"); // Hiển thị nhãn trên điểm
                    series.Points.Add(point);
                }

                // Thêm series vào Chart
                chartRevenueByDay.Series.Add(series);

                // Định dạng biểu đồ
                chartRevenueByDay.ChartAreas[0].AxisX.Title = "Ngày";
                chartRevenueByDay.ChartAreas[0].AxisY.Title = "Doanh thu (triệu)";
                chartRevenueByDay.ChartAreas[0].AxisX.Interval = 1; // Đảm bảo hiển thị từng ngày
                chartRevenueByDay.ChartAreas[0].AxisX.Minimum = 1; // Bắt đầu từ ngày 1
                chartRevenueByDay.ChartAreas[0].AxisX.Maximum = currentDay; // Kết thúc ở ngày hiện tại

                // Đặt tiêu đề cho biểu đồ
                chartRevenueByDay.Titles.Clear();
                chartRevenueByDay.Titles.Add(new Title(
                    $"Doanh thu bán hàng theo ngày - Tháng {currentMonth}/{currentYear}",
                    Docking.Top,
                    new Font("Arial", 12, FontStyle.Bold),
                    Color.Black));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            currentPage = 1; // Reset về trang đầu tiên khi tìm kiếm mới
            CalculateTotalPages(); // Tính lại số trang dựa trên khoảng thời gian mới
            LoadDataByPage(); // Sử dụng phân trang thay vì LoadListBillByDate
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadDataByPage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDataByPage();
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDataByPage();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadDataByPage();
        }
        private void dtpkDateRevenue_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenueByDate(dtpkDateRevenue.Value.Date);
        }
        private void btnPrintList_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DateTime checkIn = dtpkFromDate.Value;
            //    DateTime checkOut = dtpkToDate.Value.Date.AddDays(1).AddSeconds(-1);

            //    // Lấy danh sách hóa đơn
            //    DataTable listBill = BillBLL.GetListBillByDate(checkIn, checkOut);

            //    // Kiểm tra nếu danh sách rỗng
            //    if (listBill.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Không có hóa đơn nào để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Tạo form báo cáo và hiển thị
            //    frmReportViewer reportViewer = new frmReportViewer();
            //    reportViewer.LoadBillReport(checkIn, checkOut);
            //    reportViewer.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        #endregion


    }
}

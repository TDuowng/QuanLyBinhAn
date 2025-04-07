using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
            LoadCombobox();
            LoadDashboardData();
            LoadRevenueChart();
            LoadInvoicesByDayChart();
            SetDefaultDate();
        }

        #region Methods
        private void SetDefaultDate()
        {
            // Lấy ngày hiện tại
            DateTime today = DateTime.Now; // 07/04/2025

            // Gán giá trị cho ComboBox
            cmbDay.SelectedItem = today.Day.ToString();
            cmbMonth.SelectedItem = today.Month.ToString();
            cmbYear.SelectedItem = today.Year.ToString();
        }
        private void LoadDashboardData()
        {
            try
            {
                // Lấy thông tin tổng quan cho tháng hiện tại
                DataTable statsData = SalesBLL.GetMonthlyDashboardStats();
                if (statsData != null && statsData.Rows.Count > 0)
                {
                    DataRow row = statsData.Rows[0];
                    lblTotalInvoices.Text = row["TotalInvoices"].ToString();
                    lblTotalRevenue.Text = Convert.ToDouble(row["TotalRevenue"]).ToString("N0") + " triệu";
                    lblTotalExpenses.Text = Convert.ToDouble(row["TotalExpenses"]).ToString("N0") + " triệu";
                    lblActualRevenue.Text = Convert.ToDouble(row["ActualRevenue"]).ToString("N0") + " triệu";
                }
                else
                {
                    lblTotalInvoices.Text = "0";
                    lblTotalRevenue.Text = "0 triệu";
                    lblTotalExpenses.Text = "0 triệu";
                    lblActualRevenue.Text = "0 triệu";
                }

                LoadChartData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTotalInvoices.Text = "0";
                lblTotalRevenue.Text = "0 triệu";
                lblTotalExpenses.Text = "0 triệu";
                lblActualRevenue.Text = "0 triệu";
            }
        }
        private void LoadCombobox()
        {
            cmbDay.Items.Add("Tất cả"); // Để chọn toàn bộ ngày (khi lọc theo tháng hoặc năm)
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day.ToString());
            }
            cmbDay.SelectedIndex = 0; // Mặc định chọn "Tất cả"

            // Khởi tạo ComboBox cho tháng
            cmbMonth.Items.Add("Tất cả"); // Để chọn toàn bộ tháng (khi lọc theo năm)
            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month.ToString());
            }
            cmbMonth.SelectedIndex = 0; // Mặc định chọn "Tất cả"

            // Khởi tạo ComboBox cho năm
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 5; year <= currentYear + 1; year++) // Từ 5 năm trước đến 1 năm sau
            {
                cmbYear.Items.Add(year.ToString());
            }
            cmbYear.SelectedIndex = cmbYear.Items.Count - 2; // Mặc định chọn năm hiện tại
        }


        private void LoadChartData()
        {
            try
            {
                string filterType = "";
                DateTime? day = null;
                int? month = null;
                int? year = null;
                string title = "Top 5 món bán chạy";

                // Kiểm tra và lấy giá trị từ ComboBox
                if (cmbYear.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                year = Convert.ToInt32(cmbYear.SelectedItem);

                if (cmbMonth.SelectedItem.ToString() != "Tất cả")
                {
                    month = Convert.ToInt32(cmbMonth.SelectedItem);
                    if (cmbDay.SelectedItem.ToString() != "Tất cả")
                    {
                        // Lọc theo ngày cụ thể
                        int selectedDay = Convert.ToInt32(cmbDay.SelectedItem);
                        try
                        {
                            day = new DateTime(year.Value, month.Value, selectedDay);
                            filterType = "Day";
                            title = $"Top 5 món bán chạy - {day.Value:dd/MM/yyyy}";
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("Ngày không hợp lệ (ví dụ: 30/02 không tồn tại)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        // Lọc theo tháng
                        filterType = "Month";
                        title = $"Top 5 món bán chạy - Tháng {month}/{year}";
                    }
                }
                else
                {
                    // Lọc theo năm
                    filterType = "Year";
                    title = $"Top 5 món bán chạy - Năm {year}";
                }

                // Lấy dữ liệu top 5 món bán chạy
                DataTable topItemsData = SalesBLL.GetTop5BestSellingItems(filterType, day, month, year);

                // Xóa các series cũ (nếu có)
                chartTopItems.Series.Clear();

                if (topItemsData != null && topItemsData.Rows.Count > 0)
                {
                    // Tạo series cho biểu đồ tròn
                    Series series = new Series("Top 5 món bán chạy")
                    {
                        ChartType = SeriesChartType.Pie
                    };

                    foreach (DataRow row in topItemsData.Rows)
                    {
                        string productName = row["ProductName"].ToString();
                        int quantitySold = Convert.ToInt32(row["QuantitySold"]);
                        DataPoint point = new DataPoint();
                        point.SetValueXY(productName, quantitySold);
                        point.Label = ""; // Không hiển thị nhãn trên biểu đồ
                        point.LegendText = productName; // Giữ lại tên món trong legend
                        series.Points.Add(point);
                    }

                    // Thêm series vào Chart
                    chartTopItems.Series.Add(series);

                    // Định dạng biểu đồ
                    chartTopItems.ChartAreas[0].Area3DStyle.Enable3D = false;
                    chartTopItems.Legends[0].Enabled = true;
                    chartTopItems.Legends[0].Docking = Docking.Left; // Đặt legend bên trái
                    series.Palette = ChartColorPalette.BrightPastel; // Sử dụng bảng màu sáng
                }

                // Đặt tiêu đề cho biểu đồ
                chartTopItems.Titles.Clear();
                chartTopItems.Titles.Add(new Title(
                    title,
                    Docking.Top,
                    new Font("Arial", 12, FontStyle.Bold),
                    Color.Black));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRevenueChart()
        {
            try
            {
                // Lấy năm hiện tại
                int currentYear = DateTime.Now.Year; // 2025

                // Lấy dữ liệu doanh thu theo tháng
                DataTable revenueData = SalesBLL.GetRevenueByMonth(currentYear);

                // Xóa các series cũ (nếu có)
                chartRevenueByMonth.Series.Clear();

                // Tạo series cho biểu đồ cột
                Series series = new Series("Doanh thu")
                {
                    ChartType = SeriesChartType.Column
                };

                // Lấy tháng hiện tại để giới hạn dữ liệu
                int currentMonth = DateTime.Now.Month; // 4 (tháng 4)

                // Thêm dữ liệu vào series
                for (int month = 1; month <= currentMonth; month++)
                {
                    // Tìm doanh thu của tháng hiện tại trong dữ liệu
                    DataRow[] rows = revenueData.Select($"Month = {month}");
                    double revenue = 0;
                    if (rows.Length > 0)
                    {
                        revenue = Convert.ToDouble(rows[0]["TotalRevenue"]);
                    }

                    // Thêm điểm dữ liệu vào series
                    DataPoint point = new DataPoint();
                    point.SetValueXY(month, revenue);
                    point.Label = revenue.ToString("N0") + " triệu"; // Hiển thị nhãn trên cột
                    series.Points.Add(point);
                }

                // Thêm series vào Chart
                chartRevenueByMonth.Series.Add(series);

                // Định dạng biểu đồ
                chartRevenueByMonth.ChartAreas[0].AxisX.Title = "Tháng";
                chartRevenueByMonth.ChartAreas[0].AxisY.Title = "Doanh thu (triệu)";
                chartRevenueByMonth.ChartAreas[0].AxisX.Interval = 1; // Đảm bảo hiển thị từng tháng
                chartRevenueByMonth.ChartAreas[0].AxisX.Minimum = 1; // Bắt đầu từ tháng 1
                chartRevenueByMonth.ChartAreas[0].AxisX.Maximum = currentMonth; // Kết thúc ở tháng hiện tại

                // Đặt tiêu đề cho biểu đồ
                chartRevenueByMonth.Titles.Clear();
                chartRevenueByMonth.Titles.Add(new Title(
                    $"Doanh thu bán hàng theo tháng - {currentYear}",
                    Docking.Top,
                    new Font("Arial", 12, FontStyle.Bold),
                    Color.Black));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvoicesByDayChart()
        {
            try
            {
                // Lấy năm và tháng hiện tại
                int currentYear = DateTime.Now.Year; // 2025
                int currentMonth = DateTime.Now.Month; // 4 (tháng 4)

                // Lấy dữ liệu số lượng hóa đơn theo ngày
                DataTable invoiceData = SalesBLL.GetInvoicesByDay(currentYear, currentMonth);

                // Xóa các series cũ (nếu có)
                chartInvoicesByDay.Series.Clear();

                // Tạo series cho biểu đồ đường
                Series series = new Series("Số lượng hóa đơn")
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
                    // Tìm số lượng hóa đơn của ngày hiện tại trong dữ liệu
                    DataRow[] rows = invoiceData.Select($"Day = {day}");
                    int invoiceCount = 0;
                    if (rows.Length > 0)
                    {
                        invoiceCount = Convert.ToInt32(rows[0]["InvoiceCount"]);
                    }

                    // Thêm điểm dữ liệu vào series
                    DataPoint point = new DataPoint();
                    point.SetValueXY(day, invoiceCount);
                    point.Label = invoiceCount.ToString(); // Hiển thị nhãn trên điểm
                    series.Points.Add(point);
                }

                // Thêm series vào Chart
                chartInvoicesByDay.Series.Add(series);

                // Định dạng biểu đồ
                chartInvoicesByDay.ChartAreas[0].AxisX.Title = "Ngày";
                chartInvoicesByDay.ChartAreas[0].AxisY.Title = "Số lượng hóa đơn";
                chartInvoicesByDay.ChartAreas[0].AxisX.Interval = 1; // Đảm bảo hiển thị từng ngày
                chartInvoicesByDay.ChartAreas[0].AxisX.Minimum = 1; // Bắt đầu từ ngày 1
                chartInvoicesByDay.ChartAreas[0].AxisX.Maximum = currentDay; // Kết thúc ở ngày hiện tại

                // Đặt tiêu đề cho biểu đồ
                chartInvoicesByDay.Titles.Clear();
                chartInvoicesByDay.Titles.Add(new Title(
                    $"Số lượng hóa đơn theo ngày - Tháng {currentMonth}/{currentYear}",
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
        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            LoadChartData(); // Cập nhật biểu đồ khi nhấn nút
            LoadRevenueChart(); // Cập nhật biểu đồ doanh thu theo tháng
            LoadInvoicesByDayChart(); // Cập nhật biểu đồ số lượng hóa đơn theo ngày
        }
        #endregion


    }
}

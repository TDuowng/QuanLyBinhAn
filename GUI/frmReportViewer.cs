using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
            this.rptViewer.RefreshReport();

            rptViewer.ZoomPercent = 100;
            //rptViewer.ZoomMode = ZoomMode.PageWidth;



        }

        public void LoadReport(string nameCook, string ingredientName, string quantitative, string description, string reportPath)
        {
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.ReportPath = reportPath;
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("RecipeData", new List<RecipeDTO> { new RecipeDTO(nameCook, ingredientName, quantitative, description) }));
            rptViewer.RefreshReport();
            this.Size = new Size(920, 925);

        }

        public void LoadEmployeeReport(List<EmployeeDTO> employee, string reportPath)
        {
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.ReportPath = reportPath;
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("EmployeeData", employee));
            rptViewer.RefreshReport();

            this.Size = new Size(1050, 925);

        }

        public void LoadProvideReport(List<ProvideDTO> provideList, string reportPath)
        {
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.ReportPath = reportPath;
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("ProvideData", provideList));
            rptViewer.RefreshReport();

            this.Size = new Size(970, 925);
        }

        public void LoadIngredientReport(List<IngredientsDTO> ingredients, string reportPath)
        {
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.ReportPath = reportPath;
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("IngredientsData", ingredients));
            rptViewer.RefreshReport();

            this.Size = new Size(1050, 925);
        }

        public void LoadPayrollReport(DataTable payrollData, string reportPath)
        {
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.ReportPath = reportPath;
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("PayRollData", payrollData));
            rptViewer.RefreshReport();
        }

        public void LoadRevenueReport(DataTable revenueData, string reportPath)
        {
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.ReportPath = reportPath;
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("RevenueData", revenueData));
            rptViewer.RefreshReport();
        }
        public void LoadBillReport(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                // Lấy dữ liệu từ stored procedure
                DataTable billData = BillBLL.GetListBillByDate(checkIn, checkOut);

                // Xóa dữ liệu cũ trong ReportViewer
                rptViewer.LocalReport.DataSources.Clear();

                // Tạo ReportDataSource
                rptViewer.ProcessingMode = ProcessingMode.Local;
                ReportDataSource rds = new ReportDataSource("BillDataSet", billData);
                rptViewer.LocalReport.DataSources.Add(rds);

                // Đặt đường dẫn đến file RDLC
                rptViewer.LocalReport.ReportPath = @"D:\QLTP\GUI\rptReport.rdlc";

                // Truyền tham số CheckIn và CheckOut vào báo cáo
                ReportParameter[] parameters = new ReportParameter[]
                {
                    new ReportParameter("CheckIn", checkIn.ToString("dd/MM/yyyy")),
                    new ReportParameter("CheckOut", checkOut.ToString("dd/MM/yyyy"))
                };
                rptViewer.LocalReport.SetParameters(parameters);

                // Hiển thị ReportViewer
                rptViewer.Visible = true;
                rptViewer.RefreshReport();

                // Điều chỉnh kích thước form
                this.Size = new Size(1050, 925);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowBillReportFromProc(int billId)
        {
            try
            {
                // Lấy dữ liệu từ stored procedure
                DataTable billInfo = BillBLL.GetBillInfoForReport(billId);
                DataTable billDetails = BillBLL.GetBillDetailsForReport(billId);

                if (billInfo.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thiết lập báo cáo
                rptViewer.ProcessingMode = ProcessingMode.Local;
                rptViewer.LocalReport.ReportPath =  @"D:\QLTP\GUI\rptBill.rdlc";

                // Lấy dữ liệu từ DataTable
                DataRow row = billInfo.Rows[0];

                // Thiết lập parameters
                rptViewer.LocalReport.SetParameters(new ReportParameter("MaHD", billId.ToString()));
                rptViewer.LocalReport.SetParameters(new ReportParameter("Ngay",
                    row["NgayRa"] != DBNull.Value ?
                    Convert.ToDateTime(row["NgayRa"]).ToString("dd/MM/yyyy") :
                    DateTime.Now.ToString("dd/MM/yyyy")));
                rptViewer.LocalReport.SetParameters(new ReportParameter("Ban", row["TenBan"].ToString()));
                rptViewer.LocalReport.SetParameters(new ReportParameter("ThuNgan", row["UserName"].ToString()));
                rptViewer.LocalReport.SetParameters(new ReportParameter("GioVao",
                    row["NgayVao"] != DBNull.Value ?
                    Convert.ToDateTime(row["NgayVao"]).ToString("HH:mm") : ""));
                rptViewer.LocalReport.SetParameters(new ReportParameter("GioRa",
                    row["NgayRa"] != DBNull.Value ?
                    Convert.ToDateTime(row["NgayRa"]).ToString("HH:mm") :
                    DateTime.Now.ToString("HH:mm")));

                // Tính tổng tiền từ chi tiết
                float tongTien = 0;
                foreach (DataRow detailRow in billDetails.Rows)
                {
                    tongTien += Convert.ToSingle(detailRow["ThanhTien"]);
                }

                int discount = row["GiamGia"] != DBNull.Value ? Convert.ToInt32(row["GiamGia"]) : 0;
                float finalPrice = row["ThanhTien"] != DBNull.Value ? Convert.ToSingle(row["ThanhTien"]) : tongTien;

                rptViewer.LocalReport.SetParameters(new ReportParameter("TongTien", tongTien.ToString("N0")+" VNĐ"));
                rptViewer.LocalReport.SetParameters(new ReportParameter("KhuyenMai", discount.ToString() + "%"));
                rptViewer.LocalReport.SetParameters(new ReportParameter("ThanhToan", finalPrice.ToString("N0") + " VNĐ"));

                // Tạo data source cho chi tiết hóa đơn
                ReportDataSource rds = new ReportDataSource("BillDetailsData", billDetails);
                rptViewer.LocalReport.DataSources.Clear();
                rptViewer.LocalReport.DataSources.Add(rds);

                rptViewer.RefreshReport();

                this.Size = new Size(550, 981);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

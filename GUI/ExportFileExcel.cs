using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace GUI
{
    public class ExportFileExcel
    {
        public static void ExportProvideToExcel(DataTable dtProvide, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage ep = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet sheet = ep.Workbook.Worksheets.Add("Danh sách nhà cung cấp");
                // Đặt tiêu đề cho các cột
                sheet.Cells["A1:G1"].Merge = true;
                sheet.Cells["A1"].Value = "DANH SÁCH NGUYÊN LIỆU";

                sheet.Cells["A2:G2"].Merge = true;

                using (var range = sheet.Cells["A1"])
                {
                    range.Style.Font.Size = 15;
                    range.Style.Font.Name = "Time New Roman";
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }

                string[] headers = new string[] { "Mã NCC", "Tên nhà cung cấp", "Số điện thoại", "Địa chỉ", "Ghi chú", "Nợ cần trả", "Tổng mua" };
                for (int i = 0; i < headers.Length; i++)
                {
                    sheet.Cells[4, i + 1].Value = headers[i];
                }
                // Style cho header
                using (var range = sheet.Cells["A4:G4"])
                {
                    range.Style.Font.Size = 13;
                    range.Style.Font.Name = "Time New Roman";
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(255, 192, 192));
                    range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                //Set style cho tiêu đề
                using (var range = sheet.Cells["A1:G1"])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(255, 192, 192));
                    range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                //Fill dữ liẹu từ dòng 4
                int row = 5;
                foreach (DataRow dataRow in dtProvide.Rows)
                {
                    sheet.Cells[row, 1].Value = Convert.ToInt32(dataRow["IdProvide"]).ToString();
                    sheet.Cells[row, 2].Value = dataRow["NameProvide"].ToString();
                    sheet.Cells[row, 3].Value = dataRow["Phone"].ToString();
                    sheet.Cells[row, 4].Value = dataRow["Address"].ToString();
                    sheet.Cells[row, 5].Value = dataRow["Note"].ToString();
                    sheet.Cells[row, 6].Value = dataRow["Borrow"].ToString();
                    sheet.Cells[row, 7].Value = dataRow["Total"].ToString();

                    using (var range = sheet.Cells[$"A{row}:G{row}"])
                    {
                        range.Style.Font.Name = "Times New Roman";
                        range.Style.Font.Size = 12;
                        range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }

                    // Định dạng số tiền
                    if (dataRow["Borrow"] != DBNull.Value)
                    {
                        sheet.Cells[row, 6].Style.Numberformat.Format = "#,##0";
                    }
                    if (dataRow["Total"] != DBNull.Value)
                    {
                        sheet.Cells[row, 7].Style.Numberformat.Format = "#,##0";
                    }

                    // Định dạng số điện thoại
                    if (dataRow["Phone"] != DBNull.Value)
                    {
                        sheet.Cells[row, 3].Style.Numberformat.Format = "0000000000"; // Định dạng số điện thoại
                    }

                    // Style cho dữ liệu
                    using (var range = sheet.Cells[$"A{row}:G{row}"])
                    {
                        range.Style.Font.Name = "Times New Roman";
                        range.Style.Font.Size = 12;
                        range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }

                    row++;
                }
                sheet.Cells[sheet.Dimension.Address].AutoFitColumns(); // Tự động điều chỉnh chiều rộng cột

                // Căn giữa

                sheet.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Mã NCC
                sheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Tên NCC
                sheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Số điện thoại
                sheet.Column(5).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Địa chỉ
                sheet.Column(7).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Ghi chú
                sheet.Column(8).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Nợ cần trả
                sheet.Column(9).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Tổng mua

                //Lưu file
                FileInfo file = new FileInfo(path);
                ep.SaveAs(file);

            }
        }

        public static void ExportEmployeeToExcel(DataTable dtEmployee, string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage ep = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet sheet = ep.Workbook.Worksheets.Add("Danh sách nhân viên");
                // Đặt tiêu đề cho các cột
                sheet.Cells["A1:F1"].Merge = true;
                sheet.Cells["A1"].Value = "DANH SÁCH NHÂN VIÊN";

                sheet.Cells["A2:F2"].Merge = true;

                using (var range = sheet.Cells["A1"])
                {
                    range.Style.Font.Size = 15;
                    range.Style.Font.Name = "Time New Roman";
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }

                string[] headers = new string[] { "Mã nhân viên", "Tên nhân viên", "Giới tính", "Số điện thoại", "Chức vụ", "Loại nhân viên" };
                for (int i = 0; i < headers.Length; i++)
                {
                    sheet.Cells[4, i + 1].Value = headers[i];
                }
                // Style cho header
                using (var range = sheet.Cells["A4:F4"])
                {
                    range.Style.Font.Size = 12;
                    range.Style.Font.Name = "Time New Roman";
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(255, 192, 192));
                    range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                //Set style cho tiêu đề
                using (var range = sheet.Cells["A1:F1"])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(255, 192, 192));
                    range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                //Fill dữ liẹu từ dòng 4
                int row = 5;
                foreach (DataRow dataRow in dtEmployee.Rows)
                {
                    sheet.Cells[row, 1].Value = Convert.ToInt32(dataRow["idEmployee"]).ToString();
                    sheet.Cells[row, 2].Value = dataRow["Name"].ToString();
                    sheet.Cells[row, 3].Value = dataRow["Gender"].ToString();
                    sheet.Cells[row, 4].Value = dataRow["Phone"].ToString();
                    sheet.Cells[row, 5].Value = dataRow["Position"].ToString();
                    sheet.Cells[row, 6].Value = dataRow["TypeEmployee"].ToString();

                    using (var range = sheet.Cells[$"A{row}:F{row}"])
                    {
                        range.Style.Font.Name = "Times New Roman";
                        range.Style.Font.Size = 12;
                        range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }


                    // Định dạng số điện thoại
                    if (dataRow["Phone"] != DBNull.Value)
                    {
                        sheet.Cells[row, 5].Style.Numberformat.Format = "0000000000"; // Định dạng số điện thoại
                    }

                    // Style cho dữ liệu
                    using (var range = sheet.Cells[$"A{row}:F{row}"])
                    {
                        range.Style.Font.Name = "Times New Roman";
                        range.Style.Font.Size = 12;
                        range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }

                    row++;
                }
                sheet.Cells[sheet.Dimension.Address].AutoFitColumns(); // Tự động điều chỉnh chiều rộng cột

                // Căn giữa

                sheet.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; 
                sheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; 
                sheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; 
                sheet.Column(5).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; 
                sheet.Column(6).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; 

                //Lưu file
                FileInfo file = new FileInfo(path);
                ep.SaveAs(file);

            }
        }
    }
}

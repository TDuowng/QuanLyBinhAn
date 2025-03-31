using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportBillDAO
    {
        public static int InsertImportBill(string tenNCC, DateTime ngayNhap)
        {
            string query = "EXEC sp_ThemHoaDonNhap @TenNCC , @NgayNhap";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenNCC, ngayNhap });

            return result != null ? Convert.ToInt32(result) : -1; // Trả về mã hóa đơn nhập
        }

        public static List<ImportBillDTO> GetListHoaDonNhap()
        {
            string query = "SELECT \r\n    HoaDonNhap.MaHDN, \r\n    HoaDonNhap.NgayNhap, \r\n    HoaDonNhap.MaNCC, \r\n    ISNULL(SUM(CTHoaDonNhap.SLNhap * CTHoaDonNhap.DonGia), 0) AS TongTien\r\nFROM HoaDonNhap\r\nLEFT JOIN CTHoaDonNhap ON HoaDonNhap.MaHDN = CTHoaDonNhap.MaHDN\r\nGROUP BY HoaDonNhap.MaHDN, HoaDonNhap.NgayNhap, HoaDonNhap.MaNCC;";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<ImportBillDTO> list = new List<ImportBillDTO>();

            foreach (DataRow row in data.Rows)
            {
                ImportBillDTO hdn = new ImportBillDTO
                {
                    Id = Convert.ToInt32(row["MaHDN"]),
                    Datein = Convert.ToDateTime(row["NgayNhap"]),
                    IdProvide = Convert.ToInt32(row["MaNCC"]),
                    Toltal = Convert.ToSingle(row["TongTien"])
                };
                list.Add(hdn);
            }
            return list;
        }


    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportBillDetailDAO
    {
        public static bool InsertImportBillDetail(int maHDN, string tenNL, int soLuong, int donGia, string donViTinh)
        {
            string query = "EXEC sp_ThemChiTietHoaDonNhap @MaHDN , @TenNguyenLieu , @SoLuong , @DonGia , @DonViTinh";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHDN, tenNL, soLuong, donGia, donViTinh });

            return result > 0;
        }
    }
}

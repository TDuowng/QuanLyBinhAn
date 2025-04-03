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
        /// <summary>
        /// Thành công : bill ID
        /// Thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int GetUncheckBillIDByTableID(int tableId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MaHDB FROM HoaDonBan WHERE MaBan = @MaBan AND Trangthai = 0", new object[] { tableId });
            if (data.Rows.Count > 0)
            {
                // Chỉ lấy MaHDB thay vì tạo đối tượng ImportBillDTO
                return Convert.ToInt32(data.Rows[0]["MaHDB"]);
            }
            return -1;
        }
        public static void InsertBill(int tableId, string userName, string note = null)
        {
            string query = "INSERT INTO HoaDonBan ( NgayVao , MaBan , UserName , Trangthai , GiamGia , Ghichu ) " +
                           "VALUES ( @NgayVao , @MaBan , @UserName , 0 , 0 , @Ghichu )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { DateTime.Now , tableId , userName , note ?? (object)DBNull.Value });
        }

        public static void CheckOut(int billId, int discount, float totalPrice, string note = null)
        {
            string query = "UPDATE HoaDonBan SET NgayRa = @NgayRa , Trangthai = 1 , GiamGia = @GiamGia , ThanhTien = @ThanhTien , Ghichu = @Ghichu " +
                           "WHERE MaHDB = @MaHDB ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { DateTime.Now , discount , totalPrice , note ?? (object)DBNull.Value , billId });
        }

        public static ImportBillDTO GetBillById(int billId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDonBan WHERE MaHDB = @MaHDB " , new object[] { billId });
            if (data.Rows.Count > 0)
            {
                return new ImportBillDTO(data.Rows[0]);
            }
            return null;
        }

        

    }
}

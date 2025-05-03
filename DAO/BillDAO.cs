using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDAO
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

        public static BillDTO GetBillById(int billId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDonBan WHERE MaHDB = @MaHDB " , new object[] { billId });
            if (data.Rows.Count > 0)
            {
                return new BillDTO(data.Rows[0]);
            }
            return null;
        }
        public static DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = "EXEC USP_GetListBillByDate @CheckIn , @CheckOut";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { checkIn , checkOut });
        }


        public static DataTable GetListBillByDateAndPage(DateTime checkIn, DateTime checkOut, int curenPage, int pageSize)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate_Paging @CheckIn , @CheckOut , @PageNumber , @PageSize", new object[] { checkIn , checkOut , curenPage , pageSize });
        }

        public static int GetTotalBillRows(DateTime checkIn, DateTime checkOut)
        {
            string query = "EXEC USP_GetTotalBillRows @CheckIn , @CheckOut";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { checkIn , checkOut });
        }

        public static decimal GetRevenueByDate(DateTime date)
        {
            string query = "EXEC USP_GetRevenueByDate @Date";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { date.Date });

            // Xử lý trường hợp null (không có doanh thu trong ngày)
            if (result == DBNull.Value || result == null)
                return 0;

            return Convert.ToDecimal(result);
        }

        public static DataTable GetBillInfoByProc(int billId)
        {
            string query = "EXEC USP_GetInvoiceData @idBill";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { billId });
        }

        public static DataTable GetBillDetailsByProc(int billId)
        {
            string query = "EXEC USP_GetBillDetails @idBill";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { billId });
        }

        public static bool DeleteBill(int idBill)
        {
            string query = "EXEC USP_DeleteBill @MaHDB  ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill }) == 1)
            {
                return true;
            }
            return false;
        }

    }
}

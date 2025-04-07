using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class WorkShiftDAO
    {
        public static List<WorkShiftDTO> GetAllWorkShift()
        {
            string query = "SELECT p.MaPhien, p.MaCa, p.MaNV, nv.TenNV, c.TenCa,  p.NgayLam, p.GioCheckin, p.GioCheckout, p.SoGioThucTe, p.MucLuongCoBan, p.TongLuong, p.Thuong FROM PhienLamViec p INNER JOIN NhanVien nv ON p.MaNV = nv.MaNV INNER JOIN CaLamViec c ON p.MaCa = c.MaCa ORDER BY p.NgayLam DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<WorkShiftDTO> workShifts = new List<WorkShiftDTO>();
            foreach (DataRow row in data.Rows)
            {
                WorkShiftDTO workShift = new WorkShiftDTO(row);
                workShifts.Add(workShift);
            }
            return workShifts;
        }


        public static List<WorkShiftDTO> GetWorkShiftsByEmployeeID(int maNV)
        {
            List<WorkShiftDTO> list = new List<WorkShiftDTO>();
            string query = "SELECT p.MaPhien, p.MaCa, p.MaNV, c.TenCa, p.NgayLam, p.GioCheckin, p.GioCheckout, p.SoGioThucTe, p.MucLuongCoBan, p.TongLuong, p.Thuong FROM PhienLamViec p INNER JOIN NhanVien nv ON p.MaNV = nv.MaNV INNER JOIN CaLamViec c ON p.MaCa = c.MaCa WHERE p.MaNV = @MaNV ORDER BY p.NgayLam DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
            foreach (DataRow item in data.Rows)
            {
                WorkShiftDTO workshift = new WorkShiftDTO(item);
                list.Add(workshift);
            }
            return list;
        }



        public static List<WorkShiftDTO> GetWorkShiftByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<WorkShiftDTO> listPhienLamViec = new List<WorkShiftDTO>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NgayBatDau", fromDate),
                new SqlParameter("@NgayKetThuc", toDate)
            };

            DataTable data = DataProvider.Instance.ExecuteStoredProcedureWithReturn("sp_TimKiemPhienLamViec", parameters);

            foreach (DataRow row in data.Rows)
            {
                WorkShiftDTO phienLamViec = new WorkShiftDTO(row);
                listPhienLamViec.Add(phienLamViec);
            }

            return listPhienLamViec;
        }

        public static bool InsertWorkShift(WorkShiftDTO phienLamViec)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", phienLamViec.IdEmployee),
                new SqlParameter("@MaCa", phienLamViec.IdWork),
                new SqlParameter("@NgayLam", phienLamViec.DateWork),
                new SqlParameter("@GioCheckin", phienLamViec.CheckinHour),
                new SqlParameter("@GioCheckout", phienLamViec.CheckoutHour),
                new SqlParameter("@SoGioThucTe", (object)phienLamViec.NumberHour ?? DBNull.Value),
                new SqlParameter("@MucLuongCoBan", phienLamViec.Salary),
                new SqlParameter("@Thuong", (object)phienLamViec.Bonus ?? DBNull.Value)
            };

            int result = DataProvider.Instance.ExecuteStoredProcedure("sp_ThemPhienLamViec", parameters);
            return result > 0;
        }

        public static bool UpdateWorkShift(WorkShiftDTO phienLamViec)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhien", phienLamViec.IdWorkShift),
                new SqlParameter("@MaNV", phienLamViec.IdEmployee),
                new SqlParameter("@MaCa", phienLamViec.IdWork),
                new SqlParameter("@NgayLam", phienLamViec.DateWork),
                new SqlParameter("@GioCheckin", phienLamViec.CheckinHour),
                new SqlParameter("@GioCheckout", phienLamViec.CheckoutHour),
                new SqlParameter("@SoGioThucTe", (object)phienLamViec.NumberHour ?? DBNull.Value),
                new SqlParameter("@MucLuongCoBan", phienLamViec.Salary),
                new SqlParameter("@Thuong", (object)phienLamViec.Bonus ?? DBNull.Value)
            };

            int result = DataProvider.Instance.ExecuteStoredProcedure("sp_CapNhatPhienLamViec", parameters);
            return result > 0;
        }

        public static bool DeleteWorkShift(int maPhien)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhien", maPhien)
            };

            int result = DataProvider.Instance.ExecuteStoredProcedure("sp_XoaPhienLamViec", parameters);
            return result > 0;
        }

        public static float GetTongLuongAll()
        {
            string query = @"SELECT SUM(TongLuong) FROM PhienLamViec";
            object result = DataProvider.Instance.ExecuteScalar(query, null);

            if (result != DBNull.Value && result != null)
                return Convert.ToSingle(result);

            return 0;
        }


        public static float GetTongLuongByDateRange(DateTime fromDate, DateTime toDate)
        {
            string query = @"SELECT SUM(TongLuong) FROM PhienLamViec 
                             WHERE NgayLam BETWEEN @FromDate AND @ToDate";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { fromDate, toDate });

            if (result != DBNull.Value && result != null)
                return Convert.ToSingle(result);

            return 0;
        }

        public static List<WorkShiftDTO> GetWorkShiftsByEmployeeIDAndDateRange(int maNV, DateTime fromDate, DateTime toDate)
        {
            List<WorkShiftDTO> list = new List<WorkShiftDTO>();
            string query = @"SELECT p.MaPhien, p.MaCa, p.MaNV, c.TenCa, p.NgayLam, p.GioCheckin, p.GioCheckout, 
                     p.SoGioThucTe, p.MucLuongCoBan, p.TongLuong, p.Thuong 
                     FROM PhienLamViec p 
                     INNER JOIN NhanVien nv ON p.MaNV = nv.MaNV 
                     INNER JOIN CaLamViec c ON p.MaCa = c.MaCa 
                     WHERE p.MaNV = @MaNV AND p.NgayLam BETWEEN @FromDate AND @ToDate 
                     ORDER BY p.NgayLam DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV, fromDate, toDate });
            foreach (DataRow item in data.Rows)
            {
                WorkShiftDTO workshift = new WorkShiftDTO(item);
                list.Add(workshift);
            }
            return list;
        }

        public static float GetTongLuongByEmployeeIDAndDateRange(int maNV, DateTime fromDate, DateTime toDate)
        {
            string query = @"SELECT SUM(TongLuong) FROM PhienLamViec 
                     WHERE MaNV = @MaNV AND NgayLam BETWEEN @FromDate AND @ToDate";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV, fromDate, toDate });

            if (result != DBNull.Value && result != null)
                return Convert.ToSingle(result);

            return 0;
        }

        public static DataTable GetPayroll(int idEmployee, DateTime fromDate, DateTime toDate)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", idEmployee),
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            };

            return DataProvider.Instance.ExecuteStoredProcedureWithReturn("USP_GetPayroll", parameters);
        }


    }
}

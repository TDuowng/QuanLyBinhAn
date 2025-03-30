using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class WorkShiftDAO
    {
        public static bool InsertWorkShift(WorkShiftDTO workShift)
        {
            string query = "EXEC USP_InserWorkShift @MaNV , @MaCa , @NgayLam , @GioCheckin , @GioCheckout , @SoGioThucTe , @MucLuongCoBan , @Thuong ";
            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { workShift.IdEmployee, workShift.IdWork, workShift.DateWork, workShift.DateIn, workShift.DateOut, workShift.NumberHour, workShift.Salary , workShift.AWard}) == 1)
            {  
                return true;
            }
            return false;
        }

        public static bool UpdateWorkShift(WorkShiftDTO workShift)
        {
            string query = "EXEC USP_UpdateWorkShift @MaPhien , @MaNV , @MaCa , @NgayLam , @GioCheckin , @GioCheckout , @SoGioThucTe , @MucLuongCoBan ";
            if (DataProvider.Instance.ExecuteNonQuery(query, 
                new object[] { workShift.IdWorkshift, workShift.IdEmployee, workShift.IdWork, workShift.DateWork, workShift.DateIn, workShift.DateOut, workShift.NumberHour, workShift.Salary , workShift.AWard }) == 1)
            { 
                    return true; 
            }
            return false;
        }

        public static bool DeleteWorkShift(int idWorkShift)
        {
            string query = "EXEC USP_DeleteWorkShift @MaPhien ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idWorkShift }) == 1)
            {
                return true;
            }
            return false;
        }


        public static void CalculateSalary(int idEmployee)
        {
            string query = "EXEC USP_CalculateSalary @MaNV ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idEmployee });
        }

        public static DataTable LoadListWorkShift(int maNV)
        {
            string query = "EXEC USP_GetWorkShiftList @MaNV";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maNV, null });
        }
    }
}

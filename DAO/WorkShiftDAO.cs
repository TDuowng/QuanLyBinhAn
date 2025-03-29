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
            string query = "EXEC sp_InsertWorkShift @MaNV , @MaCa , @NgayLam , @GioCheckin , @GioCheckout , @SoGioThucTe , @MucLuongCoBan , @Thuong ";
            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { workShift.IdEmployee, workShift.IdWork, workShift.DateWork, workShift.DateIn, workShift.DateOut, workShift.NumberHour, workShift.Salary , workShift.AWard}) == 1)
            {  
                return true;
            }
            return false;
        }

        public static bool UpdateWorkShift(WorkShiftDTO workShift)
        {
            string query = "EXEC sp_UpdateWorkShift @MaPhien , @MaNV , @MaCa , @NgayLam , @GioCheckin , @GioCheckout , @SoGioThucTe , @MucLuongCoBan ";
            if (DataProvider.Instance.ExecuteNonQuery(query, 
                new object[] { workShift.IdWorkshift, workShift.IdEmployee, workShift.IdWork, workShift.DateWork, workShift.DateIn, workShift.DateOut, workShift.NumberHour, workShift.Salary , workShift.AWard }) == 1)
            { 
                    return true; 
            }
            return false;
        }

        public static bool DeleteWorkShift(int idWorkShift)
        {
            string query = "EXEC sp_Delete @MaPhien ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idWorkShift }) == 1)
            {
                return true;
            }
            return false;
        }
    }
}

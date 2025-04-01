using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WorkShiftBLL
    {
        public static List<WorkShiftDTO> GetAllWorkShift()
        {
            return WorkShiftDAO.GetAllWorkShift();
        }

        public static List<WorkShiftDTO> GetWorkShiftByIDEmployee(int idEmployee)
        {
            return WorkShiftDAO.GetWorkShiftsByEmployeeID(idEmployee);
        }

        public static List<WorkShiftDTO> GetWorkShiftByDateRange(DateTime fromDate, DateTime toDate)
        {
            return WorkShiftDAO.GetWorkShiftByDateRange(fromDate, toDate);
        }

        public static bool InsertWorkShift(WorkShiftDTO workShift)
        {
            return WorkShiftDAO.InsertWorkShift(workShift);
        }

        public static bool UpdateWorkShift(WorkShiftDTO workShift)
        {
            return WorkShiftDAO.UpdateWorkShift(workShift);
        }

        public static bool DeleteWorkShift(int idWorkShift)
        {
            return WorkShiftDAO.DeleteWorkShift(idWorkShift);
        }

        public static float GetTongLuongAll()
        {
            return WorkShiftDAO.GetTongLuongAll();
        }

        public static float GetTongLuongByDateRange(DateTime fromDate, DateTime toDate)
        {
            return WorkShiftDAO.GetTongLuongByDateRange(fromDate, toDate);
        }

        public static List<WorkShiftDTO> GetWorkShiftsByEmployeeIDAndDateRange(int maNV, DateTime fromDate, DateTime toDate)
        {
            return WorkShiftDAO.GetWorkShiftsByEmployeeIDAndDateRange(maNV, fromDate, toDate);
        }

        public static float GetTongLuongByEmployeeIDAndDateRange(int maNV, DateTime fromDate, DateTime toDate)
        {
            return WorkShiftDAO.GetTongLuongByEmployeeIDAndDateRange(maNV, fromDate, toDate);
        }


    }
}

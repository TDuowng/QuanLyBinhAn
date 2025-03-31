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
        public static bool InsertWorkShift(WorkShiftDTO workShift)
        {
            return DAO.WorkShiftDAO.InsertWorkShift(workShift);
        }
        public static bool UpdateWorkShift(WorkShiftDTO workShift)
        {
            return DAO.WorkShiftDAO.UpdateWorkShift(workShift);
        }
        public static bool DeleteWorkShift(int idWorkShift)
        {
            return DAO.WorkShiftDAO.DeleteWorkShift(idWorkShift);
        }
        public static void CalculateSalary(int idEmployee)
        {
            DAO.WorkShiftDAO.CalculateSalary(idEmployee);
        }
        public static DataTable LoadListWorkShift(int idEmloyee)
        {
            return DAO.WorkShiftDAO.LoadListWorkShift(idEmloyee);
        }

        
    }
}

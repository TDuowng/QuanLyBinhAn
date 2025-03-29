using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBLL
    {
        public static List<EmployeeDTO> GetListEmployee()
        {
            return EmployeeDAO.GetListEmployee();
        }
        public static bool InsertEmployee(EmployeeDTO employee)
        {
            return EmployeeDAO.InsertEmployee(employee);
        }

        public static bool UpdateEmployee(EmployeeDTO employee)
        {
            return EmployeeDAO.UpdateEmployee(employee);
        }

        public static bool DeleteEmployee(int idEmployee)
        {
            return EmployeeDAO.DeleteEmployee(idEmployee);
        }

        public static bool IsPhoneNumberExist(string phoneNumber)
        {
            return EmployeeDAO.IsPhoneNumberExist(phoneNumber);
        }

        public static List<string> GetListPositions()
        {
            return EmployeeDAO.GetListPositions();
        }

        public static List<EmployeeDTO> SearchEmployee(string name)
        {
            return EmployeeDAO.SearchEmployee(name);
        }
    } 
}

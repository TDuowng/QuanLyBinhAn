using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class EmployeeDAO
    {
        public static List<EmployeeDTO> GetListEmployee()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = "SELECT * FROM NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                EmployeeDTO employee = new EmployeeDTO(item);
                list.Add(employee);
            }
            return list;
        }

        public static bool InsertEmployee (EmployeeDTO employee)
        {
            string query = "EXEC USP_InsertEmployee @TenNV , @Gioitinh , @SdtNV , @Chucvu , @Anh , @LoaiNV  ";
            object imageParam = (employee.Image != null) ? employee.Image : (object)DBNull.Value;
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { employee.Name, employee.Gender, employee.Phone, employee.Position, imageParam, employee.TypeEmployee  }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateEmployee (EmployeeDTO employee)
        {
            string query = "EXEC USP_UpdateEmployee @MaNV , @TenNV , @Gioitinh , @SdtNV , @Chucvu , @Anh , @LoaiNV  ";
            object imageParam = (employee.Image != null) ? employee.Image : (object)DBNull.Value;
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { employee.IdEmployee, employee.Name, employee.Gender, employee.Phone, employee.Position, imageParam, employee.TypeEmployee }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteEmployee(int idEmployee)
        {
            string query = "EXEC USP_DeleteEmployee @MaNV ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idEmployee }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool IsPhoneNumberExist(string phoneNumber)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE SdtNV = @SdtNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { phoneNumber });
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public static List<string> GetListPositions()
        {
            List<string> list = new List<string>();
            string query = "SELECT DISTINCT Chucvu FROM NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(item["Chucvu"].ToString());
            }
            return list;
        }

        public static List<EmployeeDTO> SearchEmployee(string keyword)
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = "EXEC USP_SearchEmployee @Keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            foreach (DataRow item in data.Rows)
            {
                EmployeeDTO employee = new EmployeeDTO(item);
                list.Add(employee);
            }
            return list;
        }

        public static string GetTypeEmployee(int maNV)
        {
            string query = "SELECT LoaiNV FROM NhanVien WHERE MaNV = @maNV";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNV });

            return result != null ? result.ToString() : null;
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        public static List<AccountDTO> GetListAccount()
        {
            List<AccountDTO> list = new List<AccountDTO>();
            string query = "SELECT tk.UserName, tk.DisplayName, tk.PassWord, tk.Email, tk.Type, nv.MaNV " +
                          "FROM TaiKhoan tk LEFT JOIN NhanVien nv ON tk.MaNV = nv.MaNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                AccountDTO account = new AccountDTO(row);
                list.Add(account);
            }
            return list;
        }

        public static List<EmployeeDTO> GetListEmployeeWithoutAccount()
        {
            List<EmployeeDTO> list = EmployeeDAO.GetListEmployee();
            List<EmployeeDTO> result = new List<EmployeeDTO>();
            string query = "SELECT MaNV FROM TaiKhoan";
            DataTable accountData = DataProvider.Instance.ExecuteQuery(query);
            List<int> employeeIdsWithAccount = new List<int>();

            foreach (DataRow row in accountData.Rows)
            {
                employeeIdsWithAccount.Add((int)row["MaNV"]);
            }

            foreach (EmployeeDTO employee in list)
            {
                if (!employeeIdsWithAccount.Contains(employee.IdEmployee))
                {
                    result.Add(employee);
                }
            }
            return result;
        }

        public static bool InsertAccount(AccountDTO account)
        {
            string query = "EXEC USP_InsertAccount @UserName, @DisplayName, @Email, @Type, @MaNV";
            object[] parameters = new object[] { account.UserName, account.DisplayName, account.Email, account.Type, account.IdEmployee };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Sửa tài khoản (dùng thủ tục, không sửa PassWord)
        public static bool UpdateAccount(AccountDTO account)
        {
            string query = "EXEC USP_UpdateAccount @UserName, @DisplayName, @Email, @Type, @MaNV";
            object[] parameters = new object[] { account.UserName, account.DisplayName, account.Email, account.Type, account.IdEmployee };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Xóa tài khoản (dùng thủ tục)
        public static bool DeleteAccount(string userName)
        {
            string query = "EXEC USP_DeleteAccount @UserName";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName }) > 0;
        }

        // Kiểm tra đăng nhập
        public static bool Login(string userName, string passWord)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE UserName = @UserName AND PassWord = @PassWord";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { userName, passWord });
            return Convert.ToInt32(result) > 0;
        }
        // Lấy thông tin tài khoản sau khi đăng nhập
        public static AccountDTO GetAccountByUserName(string userName)
        {
            string query = "SELECT UserName, DisplayName, PassWord, Email, Type, MaNV FROM TaiKhoan WHERE UserName = @UserName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            if (data.Rows.Count > 0)
            {
                return new AccountDTO(data.Rows[0]);
            }
            return null;
        }



        // Đổi mật khẩu (dùng thủ tục)
        public static bool ChangePassword(string userName, string oldPassWord, string newPassWord)
        {
            string query = "EXEC USP_ChangePassword @UserName, @OldPassWord, @NewPassWord";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { userName, oldPassWord, newPassWord });
            return Convert.ToInt32(result) > 0;
        }

        // Kiểm tra UserName đã tồn tại chưa
        public static bool IsUserNameExist(string userName)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE UserName = @UserName";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
            return Convert.ToInt32(result) > 0;
        }

        public static List<ModuleDTO> GetModulesByUserName(string userName)
        {
            List<ModuleDTO> list = new List<ModuleDTO>();
            string query = "SELECT m.MaModule, m.TenModule " +
                          "FROM Module m " +
                          "JOIN PhanQuyen pq ON m.MaModule = pq.MaModule " +
                          "WHERE pq.UserName = @UserName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                ModuleDTO module = new ModuleDTO(item);
                list.Add(module);
            }
            return list;
        }

        // Thêm quyền cho tài khoản
        public static bool AddPermission(string userName, int maModule)
        {
            string query = "INSERT INTO PhanQuyen (UserName, MaModule) VALUES (@UserName, @MaModule)";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, maModule }) > 0;
        }

        // Xóa quyền của tài khoản
        public static bool RemovePermission(string userName, int maModule)
        {
            string query = "DELETE FROM PhanQuyen WHERE UserName = @UserName AND MaModule = @MaModule";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, maModule }) > 0;
        }

        public static string GetPasswordByEmail(string email)
        {
            string query = "SELECT PassWord FROM TaiKhoan WHERE Email = @Email";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { email });

            return result != null ? result.ToString() : "Không tìm thấy tài khoản!";
        }

        public static List<int> GetPermissionsByUserName(string userName)
        {
            List<int> list = new List<int>();
            string query = "SELECT MaModule FROM PhanQuyen WHERE UserName = @UserName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            foreach (DataRow row in data.Rows)
            {
                list.Add((int)row["MaModule"]);
            }
            return list;
        }

        



    }
}

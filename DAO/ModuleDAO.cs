using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ModuleDAO
    {
        public static List<ModuleDTO> GetListModule()
        {
            List<ModuleDTO> list = new List<ModuleDTO>();
            string query = "SELECT * FROM Module";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ModuleDTO account = new ModuleDTO(row);
                list.Add(account);
            }
            return list;
        }

        public static bool GrantPermission(string userName, int moduleId)
        {
            // Kiểm tra xem quyền đã tồn tại chưa
            string checkQuery = "SELECT COUNT(*) FROM PhanQuyen WHERE UserName = @UserName AND MaModule = @MaModule";
            object result = DataProvider.Instance.ExecuteScalar(checkQuery, new object[] { userName, moduleId });
            if (Convert.ToInt32(result) > 0)
            {
                return false; // Quyền đã tồn tại
            }

            // Thêm quyền nếu chưa có
            string query = "INSERT INTO PhanQuyen ( UserName , MaModule ) VALUES ( @UserName , @MaModule )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, moduleId }) > 0;
        }

        public static bool RevokePermission(string userName, int moduleId)
        {
            string query = "DELETE FROM PhanQuyen WHERE UserName = @UserName AND MaModule = @MaModule ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, moduleId }) > 0;
        }

    }
}

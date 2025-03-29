using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoryDAO
    {
        public static List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            string query = "SELECT * FROM LoaiThucDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CategoryDTO category = new CategoryDTO(item);
                list.Add(category);
            }
            return list;
        }

        public static bool InsertCategory(CategoryDTO category)
        {
            string query = "EXEC USP_InsertCategory @TenLoaiTD";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { category.Name }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateCategory(CategoryDTO category)
        {
            string query = "EXEC USP_UpdateCategory @MaLoaiTD , @TenLoaiTD ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { category.ID, category.Name }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteCategory(CategoryDTO category)
        {
            string query = "EXEC USP_DeleteCategory @MaLoaiTD  ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { category.ID }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool CheckCategoryNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM LoaiThucDon WHERE TenLoaiTD = @TenLoaiTD";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { name });

            int count = Convert.ToInt32(result); // Chuyển đổi kết quả về kiểu int

            return count > 0;
        }

        public CategoryDTO GetCategoryByID(int id)
        {
            CategoryDTO category = null;
            string query = "SELECT * FROM LoaiThucDon WHERE MaLoaiTD = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new CategoryDTO(item);
                return category;
            }
            return category;
        }
    }
}

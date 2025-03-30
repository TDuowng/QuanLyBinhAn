using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;



namespace DAO
{
    public class FoodDAO
    {

        public static List<FoodDTO> GetListFoodByCategoryID(int categoryID)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            string query = "SELECT td.MaTD, td.TenTD, td.MaLoaiTD, td.DonGia, td.Anh, ltd.TenLoaiTD " +
                           "FROM ThucDon td " +
                           "JOIN LoaiThucDon ltd ON td.MaLoaiTD = ltd.MaLoaiTD " +
                           "WHERE td.MaLoaiTD = @MaLoaiTD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { categoryID });
            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }
            return list;
        }

        public static List<FoodDTO> GetListFood()
        {
            List<FoodDTO> list = new List<FoodDTO>();
            string query = "SELECT td.MaTD, td.TenTD, td.MaLoaiTD, td.DonGia, td.Anh, ltd.TenLoaiTD " +
                           "FROM ThucDon td " +
                           "JOIN LoaiThucDon ltd ON td.MaLoaiTD = ltd.MaLoaiTD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }
            return list;
        }

        public static bool InsertFood(FoodDTO food)
        {
            string query = "EXEC USP_InsertFood @TenTD , @MaLoaiTD , @DonGia , @Anh";
            object imageParam = food.Image ?? (object)DBNull.Value;
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { food.Name, food.IdCategory, food.Price, imageParam }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateFood(FoodDTO food)
        {
            string query = "EXEC USP_UpdateFood @MaTD , @TenTD , @MaLoaiTD , @DonGia , @Anh";
            object imageParam = food.Image ?? (object)DBNull.Value;
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { food.ID, food.Name, food.IdCategory, food.Price, imageParam }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteFood(int id)
        {
            string query = "EXEC USP_DeleteFood @MaTD";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool CheckFoodNameExists(string name)
        {
            string query = "SELECT COUNT(*) FROM ThucDon WHERE TenTD = @TenTD";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { name });
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public static List<FoodDTO> SearchFood(string keyword)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            string query = "EXEC USP_SearchFood @Keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }
            return list;
        }

        public static BindingList<FoodDTO> GetFoodListInToFlow()
        {
            BindingList<FoodDTO> list = new BindingList<FoodDTO>();
            string query = "SELECT TenTD, DonGia, Anh FROM ThucDon"; 

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                string name = row["TenTD"].ToString();
                float price = (float)Convert.ToDecimal(row["DonGia"]);
                byte[] imgData = row["Anh"] as byte[]; // Trả về byte[]

                list.Add(new FoodDTO
                {
                    Name = name,
                    Price = price,
                    Image = imgData 
                });
            }

            return list;
        }

        public static List<FoodDTO> GetFoodByCategoryID(int categoryID)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            string query = "SELECT * FROM Food WHERE CategoryID = @CategoryID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { categoryID });

            foreach (DataRow row in data.Rows)
            {
                FoodDTO food = new FoodDTO
                {
                    ID = (int)row["ID"],
                    Name = row["Name"].ToString(),
                    Price = (float)row["Price"],
                    Image = row["Image"] != DBNull.Value ? (byte[])row["Image"] : null
                };
                list.Add(food);
            }
            return list;
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class IngredientsDAO
    {
        public static List<IngredientsDTO> GetListIngredients()
        {
            List<IngredientsDTO> list = new List<IngredientsDTO>();
            string query = "SELECT * FROM NguyenLieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                IngredientsDTO ingredients = new IngredientsDTO(item);
                list.Add(ingredients);
            }
            return list;
        }

        public static bool InsertIngredients( IngredientsDTO ingredients)
        {
            string query = "EXEC USP_InsertIngredients @TenNL , @DGNhap , @SLTon , @DVTinh , @Ngayquahan , @Ghichu , @Trangthai ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { ingredients.NameIngredient , ingredients.PriceIngredient , ingredients.Count , ingredients.Unit , ingredients.OverDate , ingredients.Note }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateIngredients(IngredientsDTO ingredients)
        {
            string query = "EXEC USP_UpdateIngredients @MaNL , @TenNL , @DGNhap , @SLTon , @DVTinh , @Ngayquahan , @Ghichu , @Trangthai ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { ingredients.IdIngredient , ingredients.NameIngredient, ingredients.PriceIngredient, ingredients.Count, ingredients.Unit, ingredients.OverDate, ingredients.Note }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteIngredients(int id)
        {
            string query = "EXEC USP_DeleteIngredients @MaNL ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) == 1)
            {
                return true;
            }
            return false;
        }

        public static DataTable LocNguyenLieu(bool conHang, bool hetHang, bool tonKhoThap)
        {
            string query = "EXEC USP_LocNguyenLieu @ConHang , @HetHang , @TonKhoThap ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { conHang, hetHang, tonKhoThap });
        }

        public static int GetTotalStock()
        {
            string query = "SELECT SUM(SLTon) FROM NguyenLieu";
            object result = DataProvider.Instance.ExecuteScalar(query, null);

            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

    }
}

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

        public static int InsertIngredients(IngredientsDTO ingredient)
        {
            string query = "EXEC USP_InsertIngredient @TenNL , @DGNhap , @SLTon , @DVTinh , @Ngayquahan , @Ghichu";
            object result = DataProvider.Instance.ExecuteScalar(query,
                new object[] { ingredient.NameIngredient, ingredient.PriceIngredient, ingredient.Count,
        ingredient.Unit, ingredient.OverDate, ingredient.Note });

            return (result != null) ? Convert.ToInt32(result) : -1;
        }

        public static bool UpdateIngredients(IngredientsDTO ingredients)
        {
            string query = "EXEC USP_UpdateIngredient @MaNL , @TenNL , @DGNhap , @SLTon , @DVTinh , @Ngayquahan , @Ghichu  ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { ingredients.IdIngredient , ingredients.NameIngredient, ingredients.PriceIngredient, ingredients.Count, ingredients.Unit, ingredients.OverDate, ingredients.Note }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteIngredients(int id)
        {
            string query = "EXEC USP_DeleteIngredient @MaNL ";
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
            return Convert.ToInt32(result);
        }

        public static List<string> GetAllUnits()
        {
            List<string> units = new List<string>();
            string query = "SELECT DISTINCT DVTinh FROM NguyenLieu WHERE DVTinh IS NOT NULL AND DVTinh <> ''";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                units.Add(row["DVTinh"].ToString());
            }

            return units;
        }

        public static List<IngredientsDTO> GetIngredientsWithUnitAndPrice()
        {
            List<IngredientsDTO> list = new List<IngredientsDTO>();
            string query = "SELECT MaNL, TenNL, DGNhap, DVTinh FROM NguyenLieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                IngredientsDTO ingredient = new IngredientsDTO
                {
                    IdIngredient = (int)item["MaNL"],
                    NameIngredient = item["TenNL"].ToString(),
                    PriceIngredient = (float)Convert.ToDouble(item["DGNhap"].ToString()),
                    Unit = item["DVTinh"].ToString()
                };
                list.Add(ingredient);
            }
            return list;
        }

        public static List<IngredientsDTO> SearchIngredients(string keyword)
        {
            List<IngredientsDTO> list = new List<IngredientsDTO>();

            string query = "EXEC USP_SearchIngredients @Keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,
                new object[] { keyword });

            foreach (DataRow item in data.Rows)
            {
                IngredientsDTO ingredient = new IngredientsDTO(item);
                list.Add(ingredient);
            }
            return list;
        }

        public static DataTable FilterIngredients(int? filterType = null)
        {
            string query = "EXEC USP_LocNguyenLieu @FilterType";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { filterType.HasValue ? (object)filterType.Value : DBNull.Value });
        }

        public static List<IngredientsDTO> GetIngredientsByProvider(int providerId)
        {
            List<IngredientsDTO> list = new List<IngredientsDTO>();

            string query = "EXEC USP_GetIngredientsByProvider @ProviderId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { providerId });

            foreach (DataRow item in data.Rows)
            {
                IngredientsDTO ingredient = new IngredientsDTO(item);
                list.Add(ingredient);
            }
            return list;
        }

        public static List<IngredientsDTO> GetExpiringIngredients(int monthsAhead)
        {
            List<IngredientsDTO> list = new List<IngredientsDTO>();
            string query = "EXEC USP_GetExpiredIngredients @MonthsAhead";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { monthsAhead });

            foreach (DataRow row in data.Rows)
            {
                list.Add(new IngredientsDTO(row));
            }
            return list;
        }


    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RecipeDAO
    {

        public static List<RecipeDTO> GetListRecipeByFoodId(int foodId)
        {
            List<RecipeDTO> list = new List<RecipeDTO>();
            string query = "SELECT ct.*, nl.TenNL FROM CongThucNau ct JOIN NguyenLieu nl ON ct.MaNL = nl.MaNL WHERE ct.MaTD = @MaTD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { foodId });
            foreach (DataRow item in data.Rows)
            {
                RecipeDTO recipe = new RecipeDTO(item);
                list.Add(recipe);
            }
            return list;
        }

        public static bool InsertRecipe(RecipeDTO recipe)
        {
            string query = "USP_InsertCook  @MaTD , @MaNL , @TenCT , @DinhLuong , @CachLam ";
            if(DataProvider.Instance.ExecuteNonQuery(query, new object[] { recipe.IdDish , recipe.IdIngredient , recipe.NameCook , recipe.Quantitative , recipe.Description }) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateRecipe(RecipeDTO recipe)
        {
            string query = "USP_UpdateCook @MaCT , @MaTD , @MaNL , @TenCT , @DinhLuong , @CachLam ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { recipe.IdCook, recipe.IdDish, recipe.IdIngredient, recipe.NameCook, recipe.Quantitative, recipe.Description }) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteRecipe(int id)
        {
            string query = "USP_DeleteCook @MaCT";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0)
            {
                return true;
            }
            return false;
        }

        public static RecipeDTO GetRecipeByFoodId(int foodId)
        {
            string query = "USP_GetRecipeByFoodId @MaTD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { foodId });
            if (data.Rows.Count > 0)
            {
                return new RecipeDTO(data.Rows[0]);
            }
            return null;
        }

        public static bool CheckIngredientExists(int idDish, int idIngredient)
        {
            string query = "SELECT COUNT(*) FROM CongThucNau WHERE MaTD = @MaTD AND MaNL = @MaNL";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { idDish , idIngredient }) > 0;
        }

        public static bool InsertQuantitative(RecipeDTO quantitative)
        {
            string query = "EXEC USP_InsertQuantitative @MaTD , @MaNL , @DinhLuong , @TenCT , @CachLam ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { quantitative.IdDish, quantitative.IdIngredient, quantitative.Quantitative, quantitative.NameCook, quantitative.Description });
            return Convert.ToInt32(result) == 1;
        }




    }
}

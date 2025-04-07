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


    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CookDAO
    {
        public static bool InsertRecipe(CookDTO recipe)
        {
            string query = "USP_InsertCook  @MaTD , @MaNL , @TenCT , @DinhLuong , @CachLam ";
            if(DataProvider.Instance.ExecuteNonQuery(query, new object[] { recipe.IdDish , recipe.IdIngredient , recipe.NameCook , recipe.Quantitative , recipe.Description }) > 0)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateRecipe(CookDTO recipe)
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

        public static CookDTO GetRecipeByFoodId(int foodId)
        {
            string query = "USP_GetRecipeByFoodId @MaTD";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { foodId });
            if (data.Rows.Count > 0)
            {
                return new CookDTO(data.Rows[0]);
            }
            return null;
        }


    }
}

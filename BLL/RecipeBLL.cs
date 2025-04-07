using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RecipeBLL
    {
        public static bool InsertRecipe(DTO.RecipeDTO recipe)
        {
            return RecipeDAO.InsertRecipe(recipe);
        }

        public static bool UpdateRecipe(DTO.RecipeDTO recipe)
        {
            return RecipeDAO.UpdateRecipe(recipe);
        }

        public static bool DeleteRecipe(int id)
        {
            return RecipeDAO.DeleteRecipe(id);
        }

        public static RecipeDTO GetRecipeByFoodId(int foodId)
        {
            return RecipeDAO.GetRecipeByFoodId(foodId);
        }
    }
}

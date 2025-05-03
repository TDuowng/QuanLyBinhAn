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

        public static List<RecipeDTO> GetListRecipeByFoodId(int foodId)
        {
            return RecipeDAO.GetListRecipeByFoodId(foodId);
        }
        public static bool InsertRecipe(RecipeDTO recipe)
        {
            return RecipeDAO.InsertRecipe(recipe);
        }

        public static bool UpdateRecipe(RecipeDTO recipe)
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

        public static bool CheckIngredientExists(int idDish, int idIngredient)
        {
            return RecipeDAO.CheckIngredientExists(idDish, idIngredient);
        }

        public static bool InsertQuantitative(RecipeDTO quantitative)
        {
            return RecipeDAO.InsertQuantitative(quantitative);
        }
    }
}

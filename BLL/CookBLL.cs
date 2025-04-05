using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CookBLL
    {
        public static bool InsertRecipe(DTO.CookDTO recipe)
        {
            return CookDAO.InsertRecipe(recipe);
        }

        public static bool UpdateRecipe(DTO.CookDTO recipe)
        {
            return CookDAO.UpdateRecipe(recipe);
        }

        public static bool DeleteRecipe(int id)
        {
            return CookDAO.DeleteRecipe(id);
        }

        public static CookDTO GetRecipeByFoodId(int foodId)
        {
            return CookDAO.GetRecipeByFoodId(foodId);
        }
    }
}

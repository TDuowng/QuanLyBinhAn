using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodBLL
    {
        public static List<FoodDTO> GetListFoodByCategoryID(int categoryID)
        {
            return FoodDAO.GetListFoodByCategoryID(categoryID);
        }

        public static List<FoodDTO> GetListFood()
        {
            return FoodDAO.GetListFood();
        }

        public static bool InsertFood(FoodDTO food)
        {
            return FoodDAO.InsertFood(food);
        }

        public static bool UpdateFood(FoodDTO food)
        {
            return FoodDAO.UpdateFood(food);
        }

        public static bool DeleteFood(int food)
        {
            return FoodDAO.DeleteFood(food);
        }

        public static bool IsFoodNameExists(string name)
        {
            return FoodDAO.CheckFoodNameExists(name);
        }

        public static List<FoodDTO> SearchFood(string keyword)
        {
            return FoodDAO.SearchFood(keyword);
        }

        public static BindingList<FoodDTO> GetFoodList()
        {
            return FoodDAO.GetFoodListInToFlow();
        }

        public static List<FoodDTO> FilterFoodByIngredient(int idIngredient)
        {
            return FoodDAO.FilterFoodByIngredient(idIngredient);
        }

    }
}

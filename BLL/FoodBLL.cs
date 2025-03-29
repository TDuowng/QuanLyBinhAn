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
            return DAO.FoodDAO.GetListFoodByCategoryID(categoryID);
        }

        public static List<FoodDTO> GetListFood()
        {
            return DAO.FoodDAO.GetListFood();
        }

        public static bool InsertFood(FoodDTO food)
        {
            return DAO.FoodDAO.InsertFood(food);
        }

        public static bool UpdateFood(FoodDTO food)
        {
            return DAO.FoodDAO.UpdateFood(food);
        }

        public static bool DeleteFood(int food)
        {
            return DAO.FoodDAO.DeleteFood(food);
        }

        public static bool IsFoodNameExists(string name)
        {
            return DAO.FoodDAO.CheckFoodNameExists(name);
        }

        public static List<FoodDTO> SearchFood(string keyword)
        {
            return FoodDAO.SearchFood(keyword);
        }

        public static BindingList<FoodDTO> GetFoodList()
        {
            return FoodDAO.GetFoodListInToFlow();
        }

    }
}

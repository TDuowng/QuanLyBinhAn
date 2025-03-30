using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IngredientsBLL
    {
        public static List<IngredientsDTO> GetListIngredients()
        {
            return IngredientsDAO.GetListIngredients();
        }

        public static bool InsertIngredients(IngredientsDTO ingredients)
        {
            return IngredientsDAO.InsertIngredients(ingredients);
        }

        public static bool UpdateIngredients(IngredientsDTO ingredients)
        {
            return IngredientsDAO.UpdateIngredients(ingredients);
        }

        public static bool DeleteIngredients(int id)
        {
            return IngredientsDAO.DeleteIngredients(id);
        }

        public static System.Data.DataTable LocNguyenLieu(bool conHang, bool hetHang, bool tonKhoThap)
        {
            return IngredientsDAO.LocNguyenLieu(conHang, hetHang, tonKhoThap);
        }

        public static int GetCountIngredients()
        {
            return IngredientsDAO.GetListIngredients().Count;
        }
    }
}

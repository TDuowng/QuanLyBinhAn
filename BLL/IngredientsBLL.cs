using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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

        public static int InsertIngredients(IngredientsDTO ingredients)
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
            return IngredientsDAO.GetTotalStock();
        }

        public static List<string> GetAllUnit()
        {
            return IngredientsDAO.GetAllUnits();
        }

        public static List<IngredientsDTO> GetIngredientsWithUnitAndPrice()
        {
            return IngredientsDAO.GetIngredientsWithUnitAndPrice();
        }

        public static List<IngredientsDTO> SearchIngredients(string keyword)
        {
            return IngredientsDAO.SearchIngredients(keyword);
        }

        public static DataTable FilterIngredients(int filterType)
        {
            return IngredientsDAO.FilterIngredients(filterType);
        }

        public static List<IngredientsDTO> GetIngredientsByProvider(int providerId)
        {
            return IngredientsDAO.GetIngredientsByProvider(providerId);
        }

        public static List<IngredientsDTO> GetExpiringIngredients(int monthsAhead)
        {
            return IngredientsDAO.GetExpiringIngredients(monthsAhead);
        }

    }
}

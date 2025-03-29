using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL
    {
        public static List<CategoryDTO> GetListCategory()
        {
            return CategoryDAO.GetListCategory();
        }

        public static bool InsertCategory(CategoryDTO category)
        {
            return CategoryDAO.InsertCategory(category);
        }
        public static bool IsCategoryNameExists(string name)
        {
            return CategoryDAO.CheckCategoryNameExists(name);
        }
        public static bool UpdateCategory(CategoryDTO category)
        {
            return CategoryDAO.UpdateCategory(category);
        }

        public static bool DeleteCategory(CategoryDTO category)
        {
            return CategoryDAO.DeleteCategory(category);
        }


    }
}

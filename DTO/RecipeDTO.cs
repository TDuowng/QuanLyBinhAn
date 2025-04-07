using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class RecipeDTO
    {
        private int idCook;
        private int idDish;
        private int idIngredient;
        private string nameCook;
        private string quantitative;
        private string description;

        public string IngredientName { get; set; }

        public RecipeDTO(int idCook, int idDish, int idIngredient, string nameCook, string quantitative, string description)
        {
            this.IdCook = idCook;
            this.IdDish = idDish;
            this.IdIngredient = idIngredient;
            this.NameCook = nameCook;
            this.Quantitative = quantitative;
            this.Description = description;
        }

        public RecipeDTO() { }

        public RecipeDTO(string nameCook, string ingredientName, string quantitative, string description)
        {
            this.NameCook = nameCook;
            this.IngredientName = ingredientName; // Cần thêm property này nếu chưa có
            this.Quantitative = quantitative;
            this.Description = description;
        }

        public RecipeDTO(DataRow row)
        {
            this.IdCook = (int)row["MaCT"];
            this.IdDish = (int)row["MaTD"];
            this.IdIngredient = (int)row["MaNL"];
            this.NameCook = row["TenCT"].ToString();
            this.Quantitative = row["DinhLuong"].ToString();
            this.Description = row["CachLam"].ToString();
            this.IngredientName = row["TenNL"].ToString();
        }
       
        public int IdCook { get => idCook; set => idCook = value; }
        public int IdDish { get => idDish; set => idDish = value; }
        public int IdIngredient { get => idIngredient; set => idIngredient = value; }
        public string NameCook { get => nameCook; set => nameCook = value; }
        public string Quantitative { get => quantitative; set => quantitative = value; }
        public string Description { get => description; set => description = value; }

    }
}

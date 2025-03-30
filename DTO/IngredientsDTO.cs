using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class IngredientsDTO
    {
        private int idIngredient;
        private string nameIngredient;
        private float priceIngredient;
        private int count;
        private string unit;
        private DateTime overDate;
        private string note;
        public IngredientsDTO(int idIngredient, string nameIngredient, float priceIngredient, int count, string unit, DateTime overDate, string note)
        {
            this.IdIngredient = idIngredient;
            this.NameIngredient = nameIngredient;
            this.PriceIngredient = priceIngredient;
            this.Count = count;
            this.Unit = unit;
            this.OverDate = overDate;
            this.Note = note;
        }

        public IngredientsDTO(DataRow row)
        {
            this.IdIngredient = (int)row["MaNL"];
            this.NameIngredient = row["TenNL"].ToString();
            this.PriceIngredient = (float)Convert.ToDouble(row["DGNhap"].ToString());
            this.Count = (int)row["SLTon"];
            this.Unit = row["DVTinh"].ToString();
            this.OverDate = (DateTime)row["Ngayquahan"];
            this.Note = row["Ghichu"].ToString();
        }

        public IngredientsDTO() { }

        public int IdIngredient { get => idIngredient; set => idIngredient = value; }
        public string NameIngredient { get => nameIngredient; set => nameIngredient = value; }
        public float PriceIngredient { get => priceIngredient; set => priceIngredient = value; }
        public int Count { get => count; set => count = value; }
        public string Unit { get => unit; set => unit = value; }
        public DateTime OverDate { get => overDate; set => overDate = value; }
        public string Note { get => note; set => note = value; }
    }
}

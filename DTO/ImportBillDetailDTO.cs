using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportBillDetailDTO
    {
        private int id;
        private string nameIngredient;
        private int count;
        private float price;
        private string unit;

        public ImportBillDetailDTO(int id, string nameIngredient, int count, float price, string unit)
        {
            this.Id = id;
            this.NameIngredient = nameIngredient;
            this.Count = count;
            this.Price = price;
            this.Unit = unit;
        }

        public int Id { get => id; set => id = value; }
        public string NameIngredient { get => nameIngredient; set => nameIngredient = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodDTO
    {
        private int iD;
        private string name;
        private int idCategory;
        private float price;
        private byte[] image;
        private string categoryName;
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
        public byte[] Image { get => image; set => image = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public FoodDTO() { }

        public FoodDTO(int id, string name, int idCategory, float price, byte[] image)
        {
            this.ID = id;
            this.Name = name;
            this.IdCategory = idCategory;
            this.Price = price;
            this.Image = image;
            this.CategoryName = categoryName;
        }

        public FoodDTO (DataRow dataRow)
        {
            this.ID = Convert.ToInt32(dataRow["MaTD"]);
            this.Name = dataRow["TenTD"].ToString();
            this.IdCategory = Convert.ToInt32(dataRow["MaLoaiTD"]);
            this.Price = Convert.ToSingle(dataRow["DonGia"]);
            this.Image = dataRow["Anh"] == DBNull.Value ? null : (byte[])dataRow["Anh"];
            this.CategoryName = dataRow["TenLoaiTD"].ToString();

        }
    }
}

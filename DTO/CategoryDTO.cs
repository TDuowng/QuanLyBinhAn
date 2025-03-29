using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {
        private int iD;
        private string name;

        public int ID { get; set; }
        public string Name { get; set; }

        public CategoryDTO() { }
        public CategoryDTO(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public CategoryDTO(DataRow row)
        {
            this.ID = Convert.ToInt32(row["MaLoaiTD"]);
            this.Name = row["TenLoaiTD"].ToString();
        }
    }
}

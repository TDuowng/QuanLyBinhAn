using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProvideDTO
    {
        private int idProvide;
        private string nameProvide;
        private string phone;
        private string address;
        private string note;
        private float borrow;
        private float total;

        public ProvideDTO(int idProvide, string nameProvide, string phone, string address, string note, float borrow, float total)
        {
            this.IdProvide = idProvide;
            this.NameProvide = nameProvide;
            this.Phone = phone;
            this.Address = address;
            this.Note = note;
            this.Borrow = borrow;
            this.Total = total;
        }

        public ProvideDTO() { }

        public ProvideDTO(DataRow row) 
        {
            this.IdProvide = (int)row["MaNCC"];
            this.NameProvide = row["TenNCC"].ToString();
            this.Phone = row["SdtNCC"].ToString();
            this.Address = row["DiaChiNCC"].ToString();
            this.Note = row["Ghichu"].ToString();
            this.Borrow = (float)Convert.ToDouble(row["Nocantra"].ToString());
            this.Total = (float)Convert.ToDouble(row["TongMua"].ToString());
        }

        public int IdProvide { get => idProvide; set => idProvide = value; }
        public string NameProvide { get => nameProvide; set => nameProvide = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Note { get => note; set => note = value; }
        public float Borrow { get => borrow; set => borrow = value; }
        public float Total { get => total; set => total = value; }
    }
}

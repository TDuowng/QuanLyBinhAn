using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        private int idEmployee;
        private string name;
        private string gender;
        private string phone;
        private string position;
        private byte[] image;
        private string typeEmployee;

        public EmployeeDTO(int idEmployee, string name, string gender, string phone, string position, byte[] image, string typeEmployee)
        {
            this.IdEmployee = idEmployee;
            this.Name = name;
            this.Gender = gender;
            this.Phone = phone;
            this.Position = position;
            this.Image = image;
        }

        public EmployeeDTO() { }

        public EmployeeDTO(DataRow row)
        {
            this.IdEmployee = (int)row["MaNV"];
            this.Name = row["TenNV"].ToString();
            this.Gender = row["GioiTinh"].ToString();
            this.Phone = row["SdtNV"].ToString().Trim();
            this.Position = row["ChucVu"].ToString();
            this.Image = row["Anh"] == DBNull.Value ? null : (byte[])row["Anh"];
            this.TypeEmployee = row["LoaiNV"].ToString();

        }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Position { get => position; set => position = value; }
        public byte[] Image { get => image; set => image = value; }
        public string TypeEmployee { get => typeEmployee; set => typeEmployee = value; }


    }
}

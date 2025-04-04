using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportBillDTO
    {
        private int idImportBill;
        private DateTime dateImport;
        private int idProvide;
        private float totalPrice;
        private string nameProvide;
        private string username;

        public ImportBillDTO(int idImportBill, DateTime dateImport, int idProvide, float totalPrice, string nameProvide, string username)
        {
            this.idImportBill = idImportBill;
            this.dateImport = dateImport;
            this.idProvide = idProvide;
            this.totalPrice = totalPrice;
            this.nameProvide = nameProvide;
            this.Username = username;
        }

        public ImportBillDTO() { }

        public ImportBillDTO(DataRow row)
        {
            this.idImportBill = (int)row["MaHDN"];
            this.dateImport = (DateTime)row["NgayNhap"];
            this.idProvide = (int)row["MaNCC"];
            this.totalPrice = row["TongTien"] != DBNull.Value ? Convert.ToSingle(row["TongTien"]) : 0;
            this.NameProvide = row["TenNCC"].ToString();
            this.Username = row["NguoiNhap"].ToString();
        }

        public int IdImportBill { get => idImportBill; set => idImportBill = value; }
        public DateTime DateImport { get => dateImport; set => dateImport = value; }
        public int IdProvide { get => idProvide; set => idProvide = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string NameProvide { get => nameProvide; set => nameProvide = value; }
        public string Username { get => username; set => username = value; }
    }
}

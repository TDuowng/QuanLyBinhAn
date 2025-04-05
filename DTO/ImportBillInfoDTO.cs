using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportBillInfoDTO
    {
        private int idImportBillInfo;
        private int idImportBill;
        private int idIngredient;
        private float price;
        private int count;
        private string nameIngredient;
        private float totalPrice;
        public ImportBillInfoDTO(int idImportBillInfo, int idImportBill, int idIngredient, float price, int count, string nameIngredient)
        {
            this.IdImportBillInfo = idImportBillInfo;
            this.IdImportBill = idImportBill;
            this.IdIngredient = idIngredient;
            this.Price = price;
            this.Count = count;
            this.NameIngredient = nameIngredient;
        }

        public ImportBillInfoDTO() { }

        public ImportBillInfoDTO(DataRow dataRow)
        {
            this.IdImportBillInfo = (int)dataRow["MaCTHDN"];
            this.IdImportBill = (int)dataRow["MAHDN"];
            this.IdIngredient = (int)dataRow["MaNL"];
            this.NameIngredient = dataRow["TenNL"].ToString();
            this.Price = (float)Convert.ToDouble(dataRow["DonGia"].ToString());
            this.Count = (int)dataRow["SLNhap"];
            this.TotalPrice = (float)Convert.ToDouble(dataRow["ThanhTien"].ToString());
        }



        public int IdImportBillInfo { get => idImportBillInfo; set => idImportBillInfo = value; }
        public int IdImportBill { get => idImportBill; set => idImportBill = value; }
        public int IdIngredient { get => idIngredient; set => idIngredient = value; }
        public string NameIngredient { get => nameIngredient; set => nameIngredient = value; }
        public float Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}

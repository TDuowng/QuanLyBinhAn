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
        private float totalPrice => Price * Count;
        public ImportBillInfoDTO(int idImportBillInfo, int idImportBill, int idIngredient, float price, int count, string nameIngredient)
        {
            this.idImportBillInfo = idImportBillInfo;
            this.idImportBill = idImportBill;
            this.idIngredient = idIngredient;
            this.price = price;
            this.count = count;
            this.nameIngredient = nameIngredient;
        }

        public ImportBillInfoDTO() { }

        public ImportBillInfoDTO(DataRow dataRow)
        {
            this.idImportBillInfo = (int)dataRow["IdImportBillInfo"];
            this.idImportBill = (int)dataRow["IdImportBill"];
            this.idIngredient = (int)dataRow["IdIngredient"];
            this.price = (float)Convert.ToDouble(dataRow["Price"].ToString());
            this.count = (int)dataRow["Count"];
            this.nameIngredient = dataRow["NameIngredient"].ToString();
        }



        public int IdImportBillInfo { get => idImportBillInfo; set => idImportBillInfo = value; }
        public int IdImportBill { get => idImportBill; set => idImportBill = value; }
        public int IdIngredient { get => idIngredient; set => idIngredient = value; }
        public float Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public string NameIngredient { get => nameIngredient; set => nameIngredient = value; }

        
        
    }
}

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImportBillBLL
    {
        public static int GetUncheckBillIDByTableID(int tableId)
        {
            return ImportBillDAO.GetUncheckBillIDByTableID(tableId);
        }

        public static void InsertBill(int tableId, string userName, string note = null)
        {
            ImportBillDAO.InsertBill(tableId, userName, note);
        }

        public static void CheckOut(int billId, int discount, float totalPrice, string note = null)
        {
            ImportBillDAO.CheckOut(billId, discount, totalPrice, note);
        }

        public static ImportBillDTO GetBillById(int billId)
        {
            return ImportBillDAO.GetBillById(billId);
        }

        public static float CalculateTotalPrice(int billId)
        {
            var details = ImportBillDetailDAO.GetBillDetailsByBillId(billId);
            float total = 0;
            foreach (var detail in details)
            {
                var food = FoodBLL.GetListFood().FirstOrDefault(f => f.ID == detail.FoodId);
                if (food != null)
                {
                    total += food.Price * detail.Quantity;
                }
            }
            return total;
        }
    }
}

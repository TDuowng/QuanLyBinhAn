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
    public class BillBLL
    {
        public static int GetUncheckBillIDByTableID(int tableId)
        {
            return BillDAO.GetUncheckBillIDByTableID(tableId);
        }

        public static void InsertBill(int tableId, string userName, string note = null)
        {
            BillDAO.InsertBill(tableId, userName, note);
        }

        public static void CheckOut(int billId, int discount, float totalPrice, string note = null)
        {
            BillDAO.CheckOut(billId, discount, totalPrice, note);
        }

        public static BillDTO GetBillById(int billId)
        {
            return BillDAO.GetBillById(billId);
        }

        public static float CalculateTotalPrice(int billId)
        {
            var details = BillInfoDAO.GetBillDetailsByBillId(billId);
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

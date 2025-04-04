using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillDetailBLL
    {

            public static List<BillDetailDTO> GetBillDetailsByBillId(int billId)
            {
                return BillInfoDAO.GetBillDetailsByBillId(billId);
            }

            public static bool InsertBillDetail(BillDetailDTO detail)
            {
                return BillInfoDAO.InsertBillDetail(detail);
            }

        public static bool InsertOrUpdateBillDetail(int billId, int foodId, int quantity)
        {
            return BillInfoDAO.InsertOrUpdateBillDetail(billId, foodId, quantity);
        }
    }
}

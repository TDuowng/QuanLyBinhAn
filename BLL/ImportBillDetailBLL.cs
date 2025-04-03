using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImportBillDetailBLL
    {

            public static List<ImportBillDetailDTO> GetBillDetailsByBillId(int billId)
            {
                return ImportBillDetailDAO.GetBillDetailsByBillId(billId);
            }

            public static bool InsertBillDetail(ImportBillDetailDTO detail)
            {
                return ImportBillDetailDAO.InsertBillDetail(detail);
            }

        public static bool InsertOrUpdateBillDetail(int billId, int foodId, int quantity)
        {
            return ImportBillDetailDAO.InsertOrUpdateBillDetail(billId, foodId, quantity);
        }
    }
}

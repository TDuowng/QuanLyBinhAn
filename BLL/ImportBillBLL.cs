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
        public static List<ImportBillDTO> GetListHoaDonNhap()
        {
            // Replace this with the actual data retrieval logic
            return ImportBillDAO.GetListHoaDonNhap();
        }

        public static int InsertImportBill(string tenNCC, DateTime ngayNhap)
        {
            return ImportBillDAO.InsertImportBill(tenNCC, ngayNhap);
        }
    }
}

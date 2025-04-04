using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImportBillInfoBLL
    {
        public static List<ImportBillInfoDTO> GetListImportBillInfo(int idImportBill)
        {
            return DAO.ImportBillInfoDAO.GetListImportBillInfo(idImportBill);
        }

        public static bool InsertImportBillInfo(ImportBillInfoDTO importBillInfo)
        {
            return DAO.ImportBillInfoDAO.InsertImportBillInfo(importBillInfo);
        }

        public static bool UpdateImportBillInfo(ImportBillInfoDTO importBillInfo)
        {
            return DAO.ImportBillInfoDAO.UpdateImportBillInfo(importBillInfo);
        }

        public static bool DeleteImportBillInfo(int idImportBillInfo)
        {
            return DAO.ImportBillInfoDAO.DeleteImportBillInfo(idImportBillInfo);
        }

    }
}

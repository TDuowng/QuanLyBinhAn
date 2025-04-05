using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImportBillBLL
    {
        public static List<ImportBillDTO> GetListImportBill()
        {
            return ImportBillDAO.GetListImportBill();
        }

        public static int CreateEmptyImportBill(int idProvide, string currentUserName)
        {
            ImportBillDTO importBill = new ImportBillDTO
            {
                DateImport = DateTime.Now,
                IdProvide = idProvide,
                TotalPrice = 0,
                Username = currentUserName
            };
            return ImportBillDAO.InsertImportBill(importBill);
        }

        public static bool InsertImportBill(ImportBillDTO importBill, List<ImportBillInfoDTO> details)
        {
            int newId = DAO.ImportBillDAO.InsertImportBill(importBill);
            if(newId == -1) return false;
            foreach (var detail in details)
            {
                detail.IdImportBill = newId;
                if (!DAO.ImportBillInfoDAO.InsertImportBillInfo(detail))
                {
                    return false; // Nếu có lỗi trong việc thêm chi tiết, trả về false
                }
            }
            importBill.IdImportBill = newId; // Cập nhật ID cho hóa đơn nhập
            importBill.TotalPrice = details.Sum(d => d.Price * d.Count); // Tính tổng giá trị hóa đơn nhập
            return ImportBillDAO.UpdateImportBill(importBill); // Cập nhật hóa đơn nhập với tổng giá trị
        }
        public static bool UpdateImportBill(ImportBillDTO importBill)
        {
            return ImportBillDAO.UpdateImportBill(importBill);
        }

        public static bool DeleteImportBill(int idImportBill)
        {
            return ImportBillDAO.DeleteImportBill(idImportBill);
        }

        public static List<ImportBillInfoDTO> GetImportBillDetails(int idImportBill)
        {
            return ImportBillInfoDAO.GetListImportBillInfo(idImportBill);
        }

        public static List<ImportBillDTO> GetListImportBillByDateRange(DateTime fromDate, DateTime toDate)
        {
            return ImportBillDAO.GetListImportBillByDateRange(fromDate, toDate);
        }

        public static List<ImportBillDTO> SearchImportBillsByProvider(string providerName)
        {
            if (string.IsNullOrWhiteSpace(providerName))
                return new List<ImportBillDTO>();

            return ImportBillDAO.SearchByProviderName(providerName);
        }



    }
}

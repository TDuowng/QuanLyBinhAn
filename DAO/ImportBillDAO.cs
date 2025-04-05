using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportBillDAO
    {
        public static List<ImportBillDTO> GetListImportBill()
        {
            string query = "SELECT hdn.*, ncc.TenNCC FROM HoaDonNhap hdn INNER JOIN NhaCungCap ncc ON hdn.MaNCC = ncc.MaNCC";
            List<ImportBillDTO> listImportBill = new List<ImportBillDTO>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                ImportBillDTO importBill = new ImportBillDTO(row);
                listImportBill.Add(importBill);
            }
            return listImportBill;
        }

        public static int InsertImportBill(ImportBillDTO importBill)
        {
            string query = "EXEC USP_InsertImportBill @DateImport , @IdProvide , @TotalPrice , @NguoiNhap";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { importBill.DateImport , importBill.IdProvide , 0 , importBill.Username });
            return (result != null) ? Convert.ToInt32(result) : -1;
        }

        public static bool UpdateImportBill(ImportBillDTO importBill)
        {
            string query = "EXEC USP_UpdateImportBill @IdImportBill , @DateImport , @IdProvide , @TotalPrice";
            if(DataProvider.Instance.ExecuteNonQuery(query, new object[] { importBill.DateImport , importBill.IdProvide , importBill.TotalPrice , importBill.IdImportBill }) == 1)
            {
                return true;
            }
            return false;

        }

        public static bool DeleteImportBill(int idImportBill)
        {
            string query = "EXEC USP_DeleteImportBill @IdImportBill";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idImportBill }) == 1)
            {
                return true;
            }
            return false;
        }

        public static List<ImportBillDTO> GetListImportBillByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<ImportBillDTO> listImportBill = new List<ImportBillDTO>();
            string query = "EXEC USP_GetImportBillByDateRange @FromDate , @ToDate";

            // Thêm 1 ngày vào toDate để bao gồm cả ngày kết thúc
            DateTime endDate = toDate.AddDays(1);

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query,
                new object[] { fromDate , endDate });

            foreach (DataRow row in dataTable.Rows)
            {
                ImportBillDTO importBill = new ImportBillDTO(row);
                listImportBill.Add(importBill);
            }
            return listImportBill;
        }

        public static List<ImportBillDTO> SearchByProviderName(string providerName)
        {
            List<ImportBillDTO> list = new List<ImportBillDTO>();

            string query = "EXEC USP_SearchImportBillByProvider @ProviderName";

            DataTable data = DataProvider.Instance.ExecuteQuery(query,
                new object[] { providerName });

            foreach (DataRow item in data.Rows)
            {
                ImportBillDTO bill = new ImportBillDTO(item);
                list.Add(bill);
            }

            return list;
        }



    }
}

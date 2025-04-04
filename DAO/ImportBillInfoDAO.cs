using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportBillInfoDAO
    {
        public static List<ImportBillInfoDTO> GetListImportBillInfo(int idImportBill)
        {
            string query = "SELECT cthdn.*, nl.TenNL FROM CTHoaDonNhap cthdn JOIN NguyenLieu nl ON cthdn.MaNL = nl.MaNL WHERE cthdn.MaHDN = @MaHDN";
            List<ImportBillInfoDTO> listImportBillInfo = new List<ImportBillInfoDTO>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { idImportBill });
            foreach (DataRow row in dataTable.Rows)
            {
                ImportBillInfoDTO importBillInfo = new ImportBillInfoDTO(row);
                listImportBillInfo.Add(importBillInfo);
            }
            return listImportBillInfo;
        }

        public static bool InsertImportBillInfo(ImportBillInfoDTO importBillInfo)
        {
            string query = "EXEC USP_InsertImportBillInfo @IdImportBill , @IdIngredient , @Price , @Count";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { importBillInfo.IdImportBill , importBillInfo.IdIngredient , importBillInfo.Price , importBillInfo.Count }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateImportBillInfo(ImportBillInfoDTO importBillInfo)
        {
            string query = "EXEC USP_UpdateImportBillInfo @IdImportBillInfo , @IdImportBill , @IdIngredient , @Price , @Count";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { importBillInfo.IdImportBillInfo , importBillInfo.IdImportBill , importBillInfo.IdIngredient , importBillInfo.Price , importBillInfo.Count }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteImportBillInfo(int idImportBillInfo)
        {
            string query = "EXEC USP_DeleteImportBillInfo @IdImportBillInfo";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idImportBillInfo }) == 1)
            {
                return true;
            }
            return false;
        }
    }
}

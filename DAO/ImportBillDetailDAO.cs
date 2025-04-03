using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportBillDetailDAO
    {
        public static List<ImportBillDetailDTO> GetBillDetailsByBillId(int billId)
        {
            List<ImportBillDetailDTO> list = new List<ImportBillDetailDTO>();
            string query = "SELECT * FROM CTHoaDonBan WHERE MaHDB = @MaHDB ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { billId });
            foreach (DataRow row in data.Rows)
            {
                list.Add(new ImportBillDetailDTO(row));
            }
            return list;
        }

        public static bool InsertBillDetail(ImportBillDetailDTO detail)
        {
            string query = "INSERT INTO CTHoaDonBan ( MaHDB , MaTD , SoLuong ) VALUES ( @MaHDB , @MaTD , @SoLuong )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { detail.BillId , detail.FoodId , detail.Quantity });
            return result > 0;
        }

        public static bool InsertOrUpdateBillDetail(int billId, int foodId, int quantity)
        {
            string query = "EXEC USP_InsertOrUpdateBillDetail @MaHDB , @MaTD , @SoLuong ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { billId , foodId , quantity });
            return result >= 0; // >= 0 vì DELETE không trả về số dòng ảnh hưởng trong một số trường hợp
        }
    }
}

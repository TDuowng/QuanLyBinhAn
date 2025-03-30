using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProvideDAO
    {
        public static List<ProvideDTO> GetListProvide()
        {
            List<ProvideDTO> list = new List<ProvideDTO>();
            string query = "SELECT * FROM NhaCungCap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProvideDTO provide = new ProvideDTO(item);
                list.Add(provide);
            }
            return list;
        }

        public static bool InsertProvide(ProvideDTO provide)
        {
            string query = "EXEC USP_InsertProvide @TenNCC , @SdtNCC , @DiaChiNCC , @Ghichu , @NoCanTra , @TongMua ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { provide.NameProvide, provide.Phone, provide.Address, provide.Note, provide.Borrow, provide.Total }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateProvide(ProvideDTO provide)
        {
            string query = "EXEC USP_UpdateProvide @MaNCC , @TenNCC , @SdtNCC , @DiaChiNCC , @Ghichu , @NoCanTra , @TongMua ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { provide.IdProvide, provide.NameProvide, provide.Phone, provide.Address, provide.Note, provide.Borrow, provide.Total }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteProvide(int idProvide)
        {
            string query = "EXEC USP_DeleteProvide @MaNCC ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idProvide }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool IsPhoneNumberExist(string phoneNumber)
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap WHERE SdtNCC = @SdtNCC";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { phoneNumber });
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public static List<ProvideDTO> SearchProvide(string keyword)
        {
            List<ProvideDTO> list = new List<ProvideDTO>();
            string query = "EXEC USP_SearchProvide @Keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            foreach (DataRow item in data.Rows)
            {
                ProvideDTO provide = new ProvideDTO(item);
                list.Add(provide);
            }
            return list;
        }
    }
}

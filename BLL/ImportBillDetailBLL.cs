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
        public static bool InsertImportBillDetail(int maHDN, string tenNL, int soLuong, int donGia, string donViTinh)
        {
            return ImportBillDetailDAO.InsertImportBillDetail(maHDN, tenNL, soLuong, donGia, donViTinh);
        }
    }
}

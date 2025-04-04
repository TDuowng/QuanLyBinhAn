using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        private int id;
        private DateTime? dateIn;
        private DateTime? dateOut;
        private int tableId;
        private string userName;
        private int status;
        private int discount;
        private string note;
        private float totalPrice;

        public BillDTO(int id, DateTime? dateIn, DateTime? dateOut, int tableId, string userName, int status, int discount, string note, float totalPrice)
        {
            this.id = id;
            this.dateIn = dateIn;
            this.dateOut = dateOut;
            this.tableId = tableId;
            this.userName = userName;
            this.status = status;
            this.discount = discount;
            this.note = note;
            this.totalPrice = totalPrice;
        }

        public BillDTO() { }

        public BillDTO(DataRow row)
        {
            this.Id = (int)row["MaHDB"];
            this.DateIn = row["NgayVao"] != DBNull.Value ? (DateTime)row["NgayVao"] : DateTime.MinValue;
            this.DateOut = row["NgayRa"] != DBNull.Value ? (DateTime?)row["NgayRa"] : null;
            this.TableId = (int)row["MaBan"];
            this.UserName = row["UserName"].ToString();
            this.Status = (int)row["Trangthai"];
            this.Note = row["Ghichu"] != DBNull.Value ? row["Ghichu"].ToString() : null;
            this.Discount = row["GiamGia"] != DBNull.Value ? (int)row["GiamGia"] : 0;
            this.TotalPrice = row["ThanhTien"] != DBNull.Value ? Convert.ToSingle(row["ThanhTien"]) : 0;
        }

        public int Id { get => id; set => id = value; }
        public DateTime? DateIn { get => dateIn; set => dateIn = value; }
        public DateTime? DateOut { get => dateOut; set => dateOut = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public string UserName { get => userName; set => userName = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
        public string Note { get => note; set => note = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}

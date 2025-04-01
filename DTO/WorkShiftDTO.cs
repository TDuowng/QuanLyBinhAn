using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkShiftDTO
    {
        private int idWorkShift;
        private int idEmployee;
        private string nameEmployee;
        private int idWork;
        private string nameWork;
        private DateTime dateWork;
        private DateTime checkinHour;
        private DateTime checkoutHour;
        private float? numberHour;
        private float salary;
        private float? bonus;
        private float total;

        public WorkShiftDTO(int idWorkShift, int idEmployee, string nameEmployee, int idWork, string nameWork, DateTime dateWork, DateTime checkinHour, DateTime checkoutHour, float? numberHour, float salary, float? bonus, float total)
        {
            this.idWorkShift = idWorkShift;
            this.idEmployee = idEmployee;
            this.nameEmployee = nameEmployee;
            this.idWork = idWork;
            this.nameWork = nameWork;
            this.dateWork = dateWork;
            this.checkinHour = checkinHour;
            this.checkoutHour = checkoutHour;
            this.numberHour = numberHour;
            this.salary = salary;
            this.bonus = bonus;
            this.total = total;
        }

        public WorkShiftDTO() { }

        public WorkShiftDTO(DataRow row)
        {
            IdWorkShift = (int)row["MaPhien"];
            IdEmployee = (int)row["MaNV"];
            IdWork = (int)row["MaCa"];
            NameEmployee = row.Table.Columns.Contains("TenNV") ? row["TenNV"].ToString() : string.Empty; // Kiểm tra cột TenNV
            NameWork = row["TenCa"].ToString();
            DateWork = Convert.ToDateTime(row["NgayLam"]);
            CheckinHour = (DateTime)(row["GioCheckin"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["GioCheckin"]) : null);
            CheckoutHour = (DateTime)(row["GioCheckout"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["GioCheckout"]) : null);
            NumberHour = row["SoGioThucTe"] != DBNull.Value ? (float?)Convert.ToSingle(row["SoGioThucTe"]) : null;
            Salary = Convert.ToSingle(row["MucLuongCoBan"]);
            Bonus = row["Thuong"] != DBNull.Value ? (float?)Convert.ToSingle(row["Thuong"]) : null;
            Total = row.Table.Columns.Contains("TongLuong") && row["TongLuong"] != DBNull.Value ? Convert.ToSingle(row["TongLuong"]) : 0; // Gán 0 nếu null

        }

        public int IdWorkShift { get => idWorkShift; set => idWorkShift = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int IdWork { get => idWork; set => idWork = value; }
        public string NameEmployee { get => nameEmployee; set => nameEmployee = value; }
        public string NameWork { get => nameWork; set => nameWork = value; }
        public DateTime DateWork { get => dateWork; set => dateWork = value; }
        public DateTime CheckinHour { get => checkinHour; set => checkinHour = value; }
        public DateTime CheckoutHour { get => checkoutHour; set => checkoutHour = value; }
        public float? NumberHour { get => numberHour; set => numberHour = value; }
        public float Salary { get => salary; set => salary = value; }
        public float? Bonus { get => bonus; set => bonus = value; }
        public float Total { get => total; set => total = value; }
        
    }
}


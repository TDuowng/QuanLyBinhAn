using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkDTO
    {
        private int idWork;
        private string nameWork;
        private DateTime dateIn;
        private DateTime dateOut;
        private double numberHour;
        private float salary;

        public WorkDTO(DataRow row)
        {
            this.IdWork = (int)row["MaCa"];
            this.NameWork = row["TenCa"].ToString();
            this.DateIn = Convert.ToDateTime(row["GioBatDau"]);  
            this.DateOut = Convert.ToDateTime(row["GioKetThuc"]); 
            this.NumberHour = (this.DateOut - this.DateIn).TotalHours;
            this.Salary = (float)Convert.ToDouble(row["MucLuong"]);
        }

        public WorkDTO() { }

        public WorkDTO(int idWork, string nameWork, DateTime dateIn, DateTime dateOut, double numberHour, float salary)
        {
            this.idWork = idWork;
            this.nameWork = nameWork;
            this.dateIn = dateIn;
            this.dateOut = dateOut;
            this.numberHour = numberHour;
            this.salary = salary;
        }

        public int IdWork { get => idWork; set => idWork = value; }
        public string NameWork { get => nameWork; set => nameWork = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime DateOut { get => dateOut; set => dateOut = value; }
        public double NumberHour { get => numberHour; set => numberHour = value; }
        public float Salary { get => salary; set => salary = value; }
    }
}

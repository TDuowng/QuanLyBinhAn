using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkShiftDTO
    {
        private int idWorkshift;
        private int idEmployee;
        private int idWork;
        private DateTime dateWork;
        private DateTime dateIn;
        private DateTime dateOut;
        private double numberHour;
        private double salary;
        private double aWard;

        public WorkShiftDTO(int idWorkshift, int idEmployee, int idWork, DateTime dateWork, DateTime dateIn, DateTime dateOut, double numberHour, double salary, double aWard)
        {
            this.IdWorkshift = idWorkshift;
            this.IdEmployee = idEmployee;
            this.IdWork = idWork;
            this.DateWork = dateWork;
            this.DateIn = dateIn;
            this.DateOut = dateOut;
            this.NumberHour = (this.DateOut - this.DateIn).TotalHours;
            this.salary = salary;
            this.AWard = aWard;
        }

        public int IdWorkshift { get => idWorkshift; set => idWorkshift = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int IdWork { get => idWork; set => idWork = value; }
        public DateTime DateWork { get => dateWork; set => dateWork = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime DateOut { get => dateOut; set => dateOut = value; }
        public double NumberHour { get => numberHour; set => numberHour = value; }
        public double Salary { get => salary; set => salary = value; }
        public double AWard { get => aWard; set => aWard = value; }
    }
}

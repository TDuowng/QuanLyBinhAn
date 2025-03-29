using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class WorkDAO
    {
        public static List<WorkDTO> GetListWork()
        {
            List<WorkDTO> list = new List<WorkDTO>();
            string query = "SELECT * FROM CaLamViec";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                WorkDTO work = new WorkDTO(item);
                list.Add(work);
            }
            return list;
        }

        public static bool InsertWork(WorkDTO work)
        {
            string query = "EXEC USP_InsertWork @TenCa , @GioBatDau , @GioKetThuc , @SoGio , @MucLuong ";
            if (DataProvider.Instance.ExecuteNonQuery(query,
                new object[] { work.NameWork, work.DateIn, work.DateOut, work.NumberHour, work.Salary }) == 1) // Thêm work.TotalHours
            {
                return true;
            }
            return false;
        }

        public static bool UpdateWork(WorkDTO work)
        {
            string query = "EXEC USP_UpdateWork @MaCa , @TenCa , @GioBatDau , @GioKetThuc , @SoGio , @MucLuong ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { work.IdWork, work.NameWork, work.DateIn, work.DateOut, work.NumberHour , work.Salary }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool DeleteWork(int idWork)
        {
            string query = "EXEC USP_DeleteWork @MaCa ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { idWork }) == 1)
            {
                return true;
            }
            return false;
        }

        public static List<WorkDTO> GetHourByWork(int maCa)
        {
            string query = "SELECT GioBatDau, GioKetThuc, SoGio FROM CaLamViec WHERE MaCa = " + maCa;
            List<WorkDTO> list = new List<WorkDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                WorkDTO work = new WorkDTO
                {
                    DateIn = Convert.ToDateTime(item["GioBatDau"]),
                    DateOut = Convert.ToDateTime(item["GioKetThuc"]),
                    NumberHour = Convert.ToInt32(item["SoGio"])
                };
                list.Add(work);
            }
            return list;
        }

    }
}

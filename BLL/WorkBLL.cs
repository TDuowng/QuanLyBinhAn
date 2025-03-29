using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WorkBLL
    {
        public static List<WorkDTO> GetListWork()
        {
            return DAO.WorkDAO.GetListWork();
        }

        public static bool InsertWork(WorkDTO work)
        {
            return DAO.WorkDAO.InsertWork(work);
        }

        public static bool UpdateWork(WorkDTO work)
        {
            return DAO.WorkDAO.UpdateWork(work);
        }
        public static bool DeleteWork(int idWork)
        {
            return DAO.WorkDAO.DeleteWork(idWork);
        }

        public static List<WorkDTO> GetHourByWork(int idWork)
        {
            return DAO.WorkDAO.GetHourByWork(idWork);
        }
    }
}

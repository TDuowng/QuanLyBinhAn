using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ModuleBLL
    {
        public static List<ModuleDTO> GetListModule()
        {
            return ModuleDAO.GetListModule();
        }

        public static bool GrantPermission(string userName, int moduleId)
        {
            return ModuleDAO.GrantPermission(userName, moduleId);
        }

        public static void RevokePermission(string userName, int moduleId)
        {
            ModuleDAO.RevokePermission(userName, moduleId);
        }

    }
}

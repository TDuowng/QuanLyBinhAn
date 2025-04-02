using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ModuleDTO
    {
        private int idModule;
        private string nameModule;

        public ModuleDTO(int idModule, string nameModule)
        {
            this.IdModule = idModule;
            this.NameModule = nameModule;
        }

        public ModuleDTO(DataRow row)
        {
            this.IdModule = (int)row["MaModule"];
            this.NameModule = row["TenModule"].ToString();
        }

        public int IdModule { get => idModule; set => idModule = value; }
        public string NameModule { get => nameModule; set => nameModule = value; }
    }

    public class PermissionDTO
    {
        private string userName;
        private int maModule;

        public PermissionDTO(string userName, int maModule)
        {
            this.UserName = userName;
            this.MaModule = maModule;
        }

        public PermissionDTO(System.Data.DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.MaModule = (int)row["MaModule"];
        }

        public string UserName { get => userName; set => userName = value; }
        public int MaModule { get => maModule; set => maModule = value; }
    }
}

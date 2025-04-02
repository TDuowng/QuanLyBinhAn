using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        private string userName;
        private string displayName;
        private string password;
        private string email;
        private int type;
        private int idEmployee;
        private string nameEmployee;
        public string TypeName
        {
            get => Type == 0 ? "Admin" : "User";
        }

        public AccountDTO(string userName, string displayName, string password, string email, int type, int idEmployee)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.Email = email;
            this.Type = type;
            this.IdEmployee = idEmployee;
            
        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Password = row["PassWord"].ToString(); // Khớp với truy vấn
            this.Email = row["Email"] == DBNull.Value ? null : row["Email"].ToString().Trim();
            this.Type = row["Type"] != DBNull.Value ? Convert.ToInt32(row["Type"]) : 0;
            this.IdEmployee = row["MaNV"] != DBNull.Value ? Convert.ToInt32(row["MaNV"]) : 0;
        }

        public AccountDTO() { }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Type { get => type; set => type = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string NameEmployee { get => nameEmployee; set => nameEmployee = value; }
    }
}

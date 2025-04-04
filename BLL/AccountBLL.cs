using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        private static string errorMessage;
        public static List<AccountDTO> GetListAccount()
        {
            return AccountDAO.GetListAccount();
        }

        public static List<EmployeeDTO> GetListEmployeeWithoutAccount()
        {
            return AccountDAO.GetListEmployeeWithoutAccount();
        }

        public static bool InsertAccount(AccountDTO account)
        {
            return AccountDAO.InsertAccount(account);
        }

        public static bool UpdateAccount(AccountDTO account)
        {
            return AccountDAO.UpdateAccount(account);
        }

        public static bool DeleteAccount(string userName)
        {
            return AccountDAO.DeleteAccount(userName);
        }

        public static bool Login(string userName, string passWord, out List<int> permissions)
        {
            permissions = new List<int>();
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                errorMessage = "Tên đăng nhập và mật khẩu không được để trống!";
                return false;
            }

            if (!AccountDAO.IsUserNameExist(userName))
            {
                errorMessage = "Tên đăng nhập không tồn tại!";
                return false;
            }

            if (!AccountDAO.Login(userName, passWord))
            {
                errorMessage = "Mật khẩu không đúng!";
                return false;
            }

            permissions = AccountDAO.GetPermissionsByUserName(userName);
            return true;
        }
        public static AccountDTO GetAccountByUserName(string userName)
        {
            return AccountDAO.GetAccountByUserName(userName);
        }

        public static bool ChangePassword(string userName, string oldPassWord, string newPassWord)
        {
            return AccountDAO.ChangePassword(userName, oldPassWord, newPassWord);
        }

        public static bool IsUserNameExist(string userName)
        {
            return AccountDAO.IsUserNameExist(userName);
        }

        

        public static bool AddPermission(string userName, int maModule)
        {
            return AccountDAO.AddPermission(userName, maModule);
        }

        public static bool RemovePermission(string userName, int maModule)
        {
            return AccountDAO.RemovePermission(userName, maModule);
        }

        public static string RetrievePassword(string email)
        {
            return AccountDAO.GetPasswordByEmail(email);
        }

        public static List<int> GetPermissionsByUserName(string userName)
        {
            return AccountDAO.GetPermissionsByUserName(userName);
        }

        public static List<AccountDTO> SearchAccount(string keyword)
        {
            return AccountDAO.SearchAccount(keyword);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;
using DAO;

namespace TestProjectQLTP
{
    [TestFixture]
    public class TestCase
    {

        #region TestAccount

        [Test]
        public void InsertAccount()
        {
            string userName = "testuser_" + Guid.NewGuid().ToString();
            string displayName = "Test User";
            string passWord = "123456";
            string email = "testuser@gmail.com";
            int type = 1;
            int idEmployee = 0;

            var employee = AccountBLL.GetListEmployeeWithoutAccount();
            if (employee.Count > 0)
            {
                idEmployee = employee[0].IdEmployee;

            }
            else
            {
                Assert.Inconclusive("Không còn nhân viên nào chưa có tài khoản để test");

            }

            var account = new AccountDTO(userName, displayName, passWord, email, type, idEmployee);

            bool result = AccountBLL.InsertAccount(account);

            Assert.That(result, Is.True, "InsertAccount should return true for valid input");

            AccountBLL.DeleteAccount(userName);
        }

        [Test]
        public void UpdateAccount()
        {
            // Arrange: Tạo mới một tài khoản để test
            string userName = "testuser_" + Guid.NewGuid().ToString();
            string displayName = "Test User";
            string passWord = "123456";
            string email = "testuser@gmail.com";
            int type = 1;
            int idEmployee = 0;

            var employee = AccountBLL.GetListEmployeeWithoutAccount();
            if (employee.Count > 0)
            {
                idEmployee = employee[0].IdEmployee;
            }
            else
            {
                Assert.Inconclusive("Không còn nhân viên nào chưa có tài khoản để test");
            }

            var account = new AccountDTO(userName, displayName, passWord, email, type, idEmployee);
            bool insertResult = AccountBLL.InsertAccount(account);
            Assert.That(insertResult, Is.True, "InsertAccount should return true for valid input");

            // Act: Sửa thông tin tài khoản vừa tạo
            string newDisplayName = "Updated User";
            string newEmail = "updateduser@gmail.com";
            int newType = 0; // Admin

            var updatedAccount = new AccountDTO(userName, newDisplayName, passWord, newEmail, newType, idEmployee);
            bool updateResult = AccountBLL.UpdateAccount(updatedAccount);

            // Assert: Kiểm tra kết quả cập nhật
            Assert.That(updateResult, Is.True, "UpdateAccount should return true for valid input");

            // Kiểm tra lại thông tin đã được cập nhật chưa
            var accountFromDb = AccountBLL.GetAccountByUserName(userName);
            Assert.That(accountFromDb, Is.Not.Null, "Account should exist after update");
            Assert.That(accountFromDb.DisplayName, Is.EqualTo(newDisplayName), "DisplayName should be updated");
            Assert.That(accountFromDb.Email, Is.EqualTo(newEmail), "Email should be updated");
            Assert.That(accountFromDb.Type, Is.EqualTo(newType), "Type should be updated");

            // Cleanup: Xóa tài khoản test
            AccountBLL.DeleteAccount(userName);
        }

        [Test]
        public void DeleteAccount()
        {
            // Arrange: Tạo mới một tài khoản để test việc xóa
            string userName = "testuser_" + Guid.NewGuid().ToString();
            string displayName = "Test User";
            string passWord = "123456";
            string email = "testuser@gmail.com";
            int type = 1;
            int idEmployee = 0;

            var employee = AccountBLL.GetListEmployeeWithoutAccount();
            if (employee.Count > 0)
            {
                idEmployee = employee[0].IdEmployee;
            }
            else
            {
                Assert.Inconclusive("Không còn nhân viên nào chưa có tài khoản để test");
            }

            var account = new AccountDTO(userName, displayName, passWord, email, type, idEmployee);
            bool insertResult = AccountBLL.InsertAccount(account);
            Assert.That(insertResult, Is.True, "InsertAccount should return true for valid input");

            // Act: Xóa tài khoản vừa tạo
            bool deleteResult = AccountBLL.DeleteAccount(userName);

            // Assert: Kiểm tra kết quả xóa
            Assert.That(deleteResult, Is.True, "DeleteAccount should return true for valid input");

            // Kiểm tra tài khoản đã bị xóa khỏi hệ thống
            var accountFromDb = AccountBLL.GetAccountByUserName(userName);
            Assert.That(accountFromDb, Is.Null, "Account should not exist after deletion");
        }
        #endregion

        
    }
}

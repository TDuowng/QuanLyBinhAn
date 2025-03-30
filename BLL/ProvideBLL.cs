using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProvideBLL
    {
        public static List<ProvideDTO> GetListProvide()
        {
            return ProvideDAO.GetListProvide();
        }

        public static bool InsertProvide(ProvideDTO provide)
        {
            return ProvideDAO.InsertProvide(provide);
        }

        public static bool UpdateProvide(ProvideDTO provide)
        {
            return ProvideDAO.UpdateProvide(provide);
        }

        public static bool DeleteProvide(int idProvide)
        {
            return ProvideDAO.DeleteProvide(idProvide);
        }

        public static bool IsPhoneNumberExist(string phoneNumber)
        {
            return ProvideDAO.IsPhoneNumberExist(phoneNumber);
        }
        public static List<ProvideDTO> SearchProvide(string name)
        {
            return ProvideDAO.SearchProvide(name);
        }
    }
}

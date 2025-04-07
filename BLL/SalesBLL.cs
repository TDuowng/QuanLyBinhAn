using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL
{
    public class SalesBLL
    {
        public static DataTable GetTop5BestSellingItems(string filterType, DateTime? day = null, int? month = null, int? year = null)
        {
            return SalesDAO.GetTop5BestSellingItems(filterType, day, month, year);
        }

        public static DataTable GetMonthlyDashboardStats()
        {
            return SalesDAO.GetMonthlyDashboardStats();
        }

        public static DataTable GetRevenueByMonth(int year)
        {
            return SalesDAO.GetRevenueByMonth(year);
        }

        public static DataTable GetRevenueByDay(int year, int month)
        {
            return SalesDAO.GetRevenueByDay(year, month);
        }
        public static DataTable GetInvoicesByDay(int year, int month)
        {
            return SalesDAO.GetInvoicesByDay(year, month);
        }
    }
}

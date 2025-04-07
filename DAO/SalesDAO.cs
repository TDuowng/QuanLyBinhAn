using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SalesDAO
    {
        public static DataTable GetTop5BestSellingItems(string filterType, DateTime? day = null, int? month = null, int? year = null)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FilterType", filterType)
            };

            if (filterType == "Day" && day.HasValue)
            {
                parameters.Add(new SqlParameter("@Day", day.Value));
            }
            else if (filterType == "Month" && month.HasValue && year.HasValue)
            {
                parameters.Add(new SqlParameter("@Month", month.Value));
                parameters.Add(new SqlParameter("@Year", year.Value));
            }
            else if (filterType == "Year" && year.HasValue)
            {
                parameters.Add(new SqlParameter("@Year", year.Value));
            }

            return DataProvider.Instance.ExecuteStoredProcedureWithReturn("USP_GetTop5BestSellingItems", parameters.ToArray());
        }

        public static DataTable GetMonthlyDashboardStats()
        {
            return DataProvider.Instance.ExecuteStoredProcedureWithReturn("USP_GetMonthlyDashboardStats", new SqlParameter[] { });
        }

        public static DataTable GetRevenueByMonth(int year)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Year", year)
            };

            return DataProvider.Instance.ExecuteStoredProcedureWithReturn("USP_GetRevenueByMonth", parameters.ToArray());
        }

        public static DataTable GetRevenueByDay(int year, int month)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Year", year),
                new SqlParameter("@Month", month)
            };

            return DataProvider.Instance.ExecuteStoredProcedureWithReturn("USP_GetRevenueByDay", parameters.ToArray());
        }

        public static DataTable GetInvoicesByDay(int year, int month)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Year", year),
                new SqlParameter("@Month", month)
            };

            return DataProvider.Instance.ExecuteStoredProcedureWithReturn("USP_GetInvoicesByDay", parameters.ToArray());
        }


    }
}

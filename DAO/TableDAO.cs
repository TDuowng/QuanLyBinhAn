using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TableDAO
    {
        public static List<TableDTO> LoadListTable()
        {
            List<TableDTO> list = new List<TableDTO>();
            string query = "SELECT * FROM Ban";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                list.Add(table);
            } 
            return list;
                
        }

        public static bool InsertTable(TableDTO table)
        {
            string query = "EXEC USP_InsertTable @TenBan , @status , @Tang ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { table.TableName , table.Status , table.Floor }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UpdateTable(TableDTO table)
        {
            string query = "EXEC USP_UpdateTable @MaBan , @TenBan , @status , @Tang ";
            if(DataProvider.Instance.ExecuteNonQuery(query, new object[] { table.IdTable , table.TableName , table.Status , table.Floor }) == 1)
            { 
                return true; 
            }
            return false;
        }

        public static bool DeleteTable(int idTable)
        {
            string query = "EXEC USP_DeleteTable @MaBan ";
            if(DataProvider.Instance.ExecuteNonQuery(query, new object[] { idTable }) == 1)
            {
                return true;
            }
            return false;
        }

        public static bool IsTableNameExists(string tableName)
        {
            string query = "SELECT COUNT(*) FROM Ban WHERE TenBan = @TenBan";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tableName });
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public static DataTable GetTableByStatus(string status)
        {
            string query = "SELECT * FROM Ban WHERE Status = @status";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { status });
        }

        public static DataTable GetTableByFloor(int floor)
        {
            string query = "SELECT * FROM Ban WHERE Tang = @Tang";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { floor });
        }

        public static BindingList<TableDTO> GetTableListInToFlow()
        {
            BindingList<TableDTO> list = new BindingList<TableDTO>();
            string query = "SELECT TenBan, status FROM Ban"; 

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                string name = row["TenBan"].ToString();
                string status = row["status"].ToString();

                list.Add(new TableDTO
                {
                    TableName = name,
                    Status = status,
                });
            }

            return list;
        }

        public static List<TableDTO> SearchTable(string keyword)
        {
            List<TableDTO> list = new List<TableDTO>();
            string query = "EXEC USP_SearchTable @Keyword";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
            foreach (DataRow item in data.Rows)
            {
                TableDTO employee = new TableDTO(item);
                list.Add(employee);
            }
            return list;
        }
    }
}

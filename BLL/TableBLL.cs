using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TableBLL
    {
        public static List<TableDTO> GetListTable()
        {
            return TableDAO.LoadListTable();
        }


        public static TableDTO GetTableById(int tableId)
        {
            return TableDAO.GetTableById(tableId); 
        }
        public static bool InsertTable(TableDTO table)
        { 
            if(TableDAO.IsTableNameExists(table.TableName))
            {
                return false;
            }
            return TableDAO.InsertTable(table);
        }

        public static bool UpdateTable(TableDTO table)
        {
            return TableDAO.UpdateTable(table);
        }

        public static bool DeleteTable(int idTable)
        {
            return TableDAO.DeleteTable(idTable);
        }

        public static bool IsTableNameExists(string tableName)
        {
            return TableDAO.IsTableNameExists(tableName);
        }

        public static DataTable GetTableByStatus(string status)
        {
            return TableDAO.GetTableByStatus(status);
        }

        public static DataTable GetTableByFloor(int floor)
        {
            return TableDAO.GetTableByFloor(floor);
        }

        public static BindingList<TableDTO> GetTableList()
        {
            return TableDAO.GetTableListInToFlow();
        }

        public static List<TableDTO> SearchTable(string query)
        {
            return TableDAO.SearchTable(query);
        }

        public static void SwitchTable(int idTable1, int idTable2, string username)
        {
            TableDAO.SwitchTable(idTable1, idTable2, username);
        }

        public static void MergerTables(int idTable1, int idTable2, string username)
        {
            TableDAO.MergerTables(idTable1, idTable2, username);
        }
    }
}

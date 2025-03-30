using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableDTO
    {
        private int idTable;
        private string tableName;
        private string status;
        private int? floor;

        public TableDTO(int idTable, string tableName, string status, int floor)
        {
            this.IdTable = idTable;
            this.TableName = tableName;
            this.Status = status;
            this.Floor = floor;
        }

        public TableDTO() { }

        public TableDTO(DataRow row)
        {
            this.IdTable = (int)row["MaBan"];
            this.TableName = row["TenBan"].ToString();
            this.Status = row["status"].ToString();
            this.Floor = row["Tang"] != DBNull.Value ? (int)row["Tang"] : (int?)null;
        }

        public int IdTable { get => idTable; set => idTable = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public string Status { get => status; set => status = value; }
        public int? Floor { get => floor; set => floor = value; }
    }
}

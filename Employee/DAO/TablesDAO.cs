using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee.DAO
{
    public class TablesDAO
    {
        private static TablesDAO instance;
        public static int TableWidth = 220;
        public static int TableHeight = 28;
        public static TablesDAO Instance
        {
            get
            {
                if (instance == null) instance = new TablesDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private TablesDAO() { }

        public List<TABLES> getListTable(int idBranch)
        {
            List<TABLES> lstTable = new List<TABLES>();
            string query = "USP_GetListTableForServe @idBranch";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBranch });
            foreach(DataRow row in data.Rows)
            {
                TABLES table = new TABLES(row);
                lstTable.Add(table);
            }
            return lstTable;
        }
        public TABLES getTableByName(string name)
        {
            string query = "SELECT * FROM TABLES WHERE name LIKE N'%" + name + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                return new TABLES((int)row["idTable"], row["name"].ToString());
            }
            return null;
        }
    }
}

using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAO
{
    public class OrdersDAO
    {
        private static OrdersDAO instance;
        public static OrdersDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrdersDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private OrdersDAO() { }
        public DataTable GetListOrder()
        {
            string query = "SELECT A.idOrder AS [STT], B.name AS [Tên bàn], A.value AS [Tổng tiền], A.create_at AS [Ngày] FROM ORDERS AS A, TABLES AS B WHERE A.idTable = B.idTable AND A.status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable SearchTableByName(string name)
        {
            string query = string.Format("SELECT A.idOrder AS [STT], B.name AS [Tên bàn], A.value AS [Tổng tiền], A.create_at AS [Ngày] FROM ORDERS AS A, TABLES AS B\r\nWHERE A.idTable = B.idTable AND A.status = 0 AND B.name LIKE N'%" + name + "%'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public ORDERS GetInfoOrder(int id)
        {
            string query = "SELECT * FROM ORDERS WHERE idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                return new ORDERS(row);
            }
            return null;
        }
    }
}

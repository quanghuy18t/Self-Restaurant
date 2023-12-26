using FoodOrder.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace FoodOrder.DAO
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
        public List<ORDERS> GetListOrder(string name)
        {
            List<ORDERS> lstOrder = new List<ORDERS>();
            string query = "USP_GetOrderList @name";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name });

            foreach (DataRow row in data.Rows)
            {
                ORDERS order = new ORDERS(row);
                lstOrder.Add(order);
            }
            return lstOrder;
        }
        public ORDERS CreateNewOrder(int idTable, int value, int point)
        {
            string query = "INSERT ORDERS VALUES (" + idTable + ", " + value + ", " + point + ", 0, GETDATE()); SELECT * FROM ORDERS WHERE idOrder = SCOPE_IDENTITY();;";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                return new ORDERS(item);
            }
            return null;
        }
        public void UpdateOrder(int id, int value, int point)
        {
            string query = "UPDATE ORDERS SET value = " + value + ", point = " + point + " WHERE idOrder = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public ORDERS GetOrderById(int id)
        {
            string query = "SELECT * FROM ORDERS WHERE idOrder = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                return new ORDERS(item);
            }
            return null;
        }
    }
}

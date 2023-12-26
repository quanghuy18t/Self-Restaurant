using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Employee.DAO
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderDetailDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private OrderDetailDAO() { }
        public List<ORDERDETAIL> GetOrderDetailByTable(int id)
        {
            List<ORDERDETAIL> lstOrder = new List<ORDERDETAIL>();
            string query = "USP_GetOrderDetailByTable @idTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow row in data.Rows)
            {
                ORDERDETAIL order = new ORDERDETAIL(row);
                lstOrder.Add(order);
            }
            return lstOrder;
        }
    }
}

using FoodOrder.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace FoodOrder.DAO
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

        public void AddOrderDetail(int idOrder, int idFood, int price, int quantity)
        {
            string query = "INSERT ORDERDETAIL VALUES (" + idOrder + ", " + idFood + ", " + price + ", " + quantity + ", " + price*quantity + ")";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool CheckFoodInOrder(int idOrder, int idFood)
        {
            string query = "SELECT * FROM ORDERDETAIL WHERE idOrder = " + idOrder + " AND idFood = " + idFood;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count == 0;
        }
    }
}

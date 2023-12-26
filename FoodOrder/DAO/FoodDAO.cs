using FoodOrder.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private FoodDAO() { }
        public FOOD GetItem(int idFood)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM FOOD WHERE idFood = " + idFood + "");

            foreach (DataRow item in data.Rows)
            {
                return new FOOD(item);
            }
            return null;
        }
    }
}

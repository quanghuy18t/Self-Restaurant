using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static int FoodWidth = 90;
        public static int FoodHeight = 85;
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
        public List<FOOD> LoadFoodList()
        {
            List<FOOD> lstFood = new List<FOOD>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetFoodList");
            foreach (DataRow row in data.Rows)
            {
                FOOD food = new FOOD(row);
                lstFood.Add(food);
            }
            return lstFood;
        }
        public FOOD GetFoodOrder(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetFoodOrder @idFood", new object[] { id });
            foreach (DataRow row in data.Rows)
            {
                return new FOOD(row);
            }
            return null;
        }
    }
}

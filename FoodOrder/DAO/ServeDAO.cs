using FoodOrder.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DAO
{
    public class ServeDAO
    {
        private static ServeDAO instance;
        public static int FoodWidth = 199;
        public static int FoodHeight = 192;
        public static ServeDAO Instance
        {
            get
            {
                if (instance == null) instance = new ServeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private ServeDAO() { }

        public List<FOOD> GetListServe(int idBranch)
        {
            List<FOOD> lstServe = new List<FOOD>();
            string query = "USP_GetServeList @idBranch";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBranch });

            foreach (DataRow row in data.Rows)
            {
                FOOD food = new FOOD(row);
                lstServe.Add(food);
            }
            return lstServe;
        }
    }
}

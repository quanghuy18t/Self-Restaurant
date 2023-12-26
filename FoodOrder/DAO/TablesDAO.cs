using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DAO
{
    public class TablesDAO
    {
        private static TablesDAO instance;
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
    }
}

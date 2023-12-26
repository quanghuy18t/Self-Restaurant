using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DAO
{
    public class UsersDAO
    {
        private static UsersDAO instance;
        public static UsersDAO Instance
        {
            get
            {
                if (instance == null) instance = new UsersDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private UsersDAO() { }
    }
}

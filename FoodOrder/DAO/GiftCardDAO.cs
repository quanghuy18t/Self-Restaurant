using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DAO
{
    public class GiftCardDAO
    {
        private static GiftCardDAO instance;
        public static GiftCardDAO Instance
        {
            get
            {
                if (instance == null) instance = new GiftCardDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private GiftCardDAO() { }
    }
}

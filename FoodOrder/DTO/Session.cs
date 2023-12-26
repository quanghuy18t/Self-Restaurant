using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DTO
{
    public class Session
    {
        private static List<ORDERITEM> lstItem = new List<ORDERITEM>();
        public void AddObject(ORDERITEM obj)
        {
            lstItem.Add(obj);
        }
        public static List<ORDERITEM> getList()
        {
            return lstItem;
        }
        public static bool CheckFoodInOrder(int id)
        {
            foreach(ORDERITEM item in lstItem)
            {
                if (item.IdFood == id) return false;
            }
            return true;
        }
        public static void ClearSession()
        {
            lstItem.Clear();
        }
    }
}

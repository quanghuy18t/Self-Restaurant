using FoodOrder.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DTO
{
    public class ORDERITEM
    {
        private int idFood;
        private string name;
        private int price;
        private int quantity;
        private int total;

        public int IdFood { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Total
        {
            get { return Quantity * Price; }
        }
        public ORDERITEM(int id)
        {
            FOOD item = FoodDAO.Instance.GetItem(id);
            IdFood = id;
            Name = item.Name;
            Price = item.Price;
            Quantity = 1;
        }
    }
}

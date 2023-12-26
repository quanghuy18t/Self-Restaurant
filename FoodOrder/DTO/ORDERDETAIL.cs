using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DTO
{
    public class ORDERDETAIL
    {
        private int idOrder;
        private int idFood;
        private int price;
        private int quantity;
        private int total;

        public int IdOrder { get; set; }
        public int IdFood { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }

        public ORDERDETAIL(int idOrder, int idFood, int price, int quantity, int total)
        {
            IdOrder = idOrder;
            IdFood = idFood;
            Price = price;
            Quantity = quantity;
            Total = total;
        }

        public ORDERDETAIL(DataRow row)
        {
            IdOrder = (int)row["idOrder"];
            IdFood = (int)row["idFood"];
            Price = (int)row["price"];
            Quantity = (int)row["quantity"];
            Total = (int)row["total"];
        }
    }
}

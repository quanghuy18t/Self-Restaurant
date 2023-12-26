using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DTO
{
    public class FOOD
    {
        private int idFood;
        private string name;
        private string image;
        private int price;

        public int IdFood { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }

        public FOOD(int idFood, string name, string image, int price)
        {
            IdFood = idFood;
            Name = name;
            Image = image;
            Price = price;
        }

        public FOOD(DataRow row)
        {
            IdFood = (int)row["idFood"];
            Name = row["name"].ToString();
            Image = row["image"].ToString();
            Price = (int)row["price"];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DTO
{
    public class TABLES
    {
        private int idTable;
        private string name;

        public int IdTable { get; set; }
        public string Name { get; set; }

        public TABLES(int idTable, string name)
        {
            IdTable = idTable;
            Name = name;
        }

        public TABLES(DataRow row)
        {
            IdTable = (int)row["idTable"];
            Name = row["name"].ToString();
        }
    }
}

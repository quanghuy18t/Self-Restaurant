using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DTO
{
    public class ORDERS
    {
        private int idOrder;
        private int idTable;
        private int value;
        private float point;
        private int status;
        private DateTime? create_at;
        
        public int IdOrder { get; set; }
        public int IdTable { get; set; }
        public int Value { get; set; }
        public float Point { get; set; }
        public int Status { get; set; }
        public DateTime? Create_at { get; set; }

        public ORDERS(int idOrder, int idTable, int value, float point, DateTime? create_at, int status)
        {
            IdOrder = idOrder;
            IdTable = idTable;
            Value = value;
            Point = point;
            Status = status;
            Create_at = create_at;
        }

        public ORDERS(DataRow row)
        {
            IdOrder = (int)row["idOrder"];
            IdTable = (int)row["idTable"];
            Value = (int)row["value"];
            Point = float.Parse(row["point"].ToString());
            Status = (int)row["status"];
            Create_at = (DateTime)row["create_at"];
        }
    }
}

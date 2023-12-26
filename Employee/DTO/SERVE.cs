using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DTO
{
    public class SERVE
    {
        private int idUser;
        private int idFood;
        private DateTime? date;

        public int IdUser { get; set; }
        public int IdFood { get; set; }
        public DateTime? Date { get; set; }

        public SERVE(int idUser, int idFood, DateTime? date)
        {
            IdUser = idUser;
            IdFood = idFood;
            Date = date;
        }

        public SERVE(DataRow row)
        {
            IdUser = (int)row["idUser"];
            IdFood = (int)row["idFood"];
            Date = (DateTime)row["date"];
        }
    }
}

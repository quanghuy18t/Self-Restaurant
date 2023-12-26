using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.DTO
{
    public class ROLE
    {
        private int idRole;
        private string name;

        public int IdRole { get; set; }
        public string Name { get; set; }

        public ROLE(int idRole, string name)
        {
            IdRole = idRole;
            Name = name;
        }

        public ROLE(DataRow row)
        {
            IdRole = (int)row["idRole"];
            Name = row["name"].ToString();
        }
    }
}

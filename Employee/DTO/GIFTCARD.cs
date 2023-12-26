using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DTO
{
    public class GIFTCARD
    {
        private int idCard;
        private int idUser;
        private string name;
        private string phone;
        private int point;
        private DateTime? create_at;

        public int IdCard { get; set; }
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Point { get; set; }
        public DateTime? Create_at { get; set; }

        public GIFTCARD(int idCard, int idUser, string name, string phone, int point, DateTime? create_at)
        {
            IdCard = idCard;
            IdUser = idUser;
            Name = name;
            Phone = phone;
            Point = point;
            Create_at = create_at;
        }

        public GIFTCARD(DataRow row)
        {
            IdCard = (int)row["idCard"];
            IdUser = (int)row["idUser"];
            Name = row["name"].ToString();
            Phone = row["phone"].ToString();
            Point = (int)row["point"];
            Create_at = (DateTime)row["create_at"];
        }
    }
}

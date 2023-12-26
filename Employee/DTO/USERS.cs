using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Employee.DTO
{
    public class USERS
    {
        private int idUser;
        private int idRole;
        private int idBranch;
        private string name;
        private string phone;
        private string userName;
        private string passWord;

        public int IdUser { get; set; }
        public int IdRole { get; set; }
        public int IdBranch { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public USERS(int idUser, int idRole, int idBranch, string name, string phone, string userName, string passWord)
        {
            IdUser = idUser;
            IdRole = idRole;
            IdBranch = idBranch;
            Name = name;
            Phone = phone;
            UserName = userName;
            PassWord = passWord;
        }

        public USERS(DataRow row)
        {
            IdUser = (int)row["idUser"];
            IdRole = (int)row["idRole"];
            IdBranch = (int)row["idBranch"];
            Name = row["name"].ToString();
            Phone = row["phone"].ToString();
            UserName = row["userName"].ToString();
            PassWord = row["passWord"].ToString();
        }

        public USERS()
        {
        }
    }
}

using Employee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAO
{
    public class UsersDAO
    {
        private static UsersDAO instance;
        public static UsersDAO Instance
        {
            get
            {
                if (instance == null) instance = new UsersDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private UsersDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
        public USERS GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM USERS WHERE userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new USERS(item);
            }
            return null;
        }
    }
}

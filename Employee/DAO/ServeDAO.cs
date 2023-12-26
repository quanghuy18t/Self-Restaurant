using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee.DAO
{
    public class ServeDAO
    {
        private static ServeDAO instance;
        public static ServeDAO Instance
        {
            get
            {
                if (instance == null) instance = new ServeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private ServeDAO() { }

        public void InsertServe(int idUser, int idFood, DateTime date)
        {
            string query = "INSERT SERVE(idUser, idFood, date)\r\nVALUES (" + idUser + ", " + idFood + ", '" + date.Date + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}

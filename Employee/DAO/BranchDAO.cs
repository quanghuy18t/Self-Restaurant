using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAO
{
    public class BranchDAO
    {
        private static BranchDAO instance;
        public static BranchDAO Instance
        {
            get
            {
                if (instance == null) instance = new BranchDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private BranchDAO() { }
    }
}

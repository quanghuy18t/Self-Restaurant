using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DTO
{
    public class BRANCH
    {
        private int idBranch;
        private string address;

        public int IdBranch { get; set; }
        public string Address { get; set; }

        public BRANCH(int idBranch, string address)
        {
            IdBranch = idBranch;
            Address = address;
        }

        public BRANCH(DataRow row)
        {
            IdBranch = (int)row["idBranch"];
            Address = row["address"].ToString();
        }
    }
}

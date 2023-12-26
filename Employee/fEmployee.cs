using Employee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class fEmployee : Form
    {
        private static USERS loginAccount;

        public USERS LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }

        }
        public fEmployee(USERS user)
        {
            InitializeComponent();
            LoginAccount = user;

            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            chefHomeUserControl2.BringToFront();
        }

        public static USERS getInfoUser()
        {
            return loginAccount;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            chefHomeUserControl2.BringToFront();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFood.Height;
            SidePanel.Top = btnFood.Top;
            chefFoodUserControl2.BringToFront();
        }
    }
}

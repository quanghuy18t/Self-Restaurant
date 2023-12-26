using Employee.DAO;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private bool Login(string userName, string passWord)
        {
            return UsersDAO.Instance.Login(userName, passWord);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassword.Text;
            if (Login(userName, password))
            {
                USERS login = UsersDAO.Instance.GetAccountByUserName(userName);
                fEmployee f = new fEmployee(login);

                this.Hide();
                f.ShowDialog(); // Top Mode 
                this.Show();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên đăng nhập hoặc mật khẩu!!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

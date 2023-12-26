using Employee.DAO;
using Employee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class PaymentAction : Form
    {
        private PrintDocument printDocument;
        public PaymentAction(int idTable)
        {
            InitializeComponent();

            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(OnPrintPage);

            ORDERS order = OrdersDAO.Instance.GetInfoOrder(idTable);
            lbDate.Text = order.Create_at.ToString();
            txtbMoney.Text = order.Value.ToString("#,0");
            txtbTotal.Text = order.Value.ToString("#,0");
        }

        private void txtbCustomer_money_TextChanged(object sender, EventArgs e)
        {
            int total = int.Parse(txtbTotal.Text.Replace(",", ""));
            int customer_money = int.Parse(txtbCustomer_money.Text);
            txtbExchange.Text = (customer_money - total).ToString("#,0");
        }
        private void txtbDiscount_TextChanged(object sender, EventArgs e)
        {
            int discount = int.Parse(txtbDiscount.Text) * 1000;
            int money = int.Parse(txtbMoney.Text.Replace(",", ""));
            txtbTotal.Text = (money - discount).ToString("#,0");
        }
        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("---o0o---", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new PointF(50, 50));
            e.Graphics.DrawString("Ngày giờ: ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString(lbDate.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, 10));
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}

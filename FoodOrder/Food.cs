using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrder
{
    public partial class Food : UserControl
    {
        public Food()
        {
            InitializeComponent();
        }

        private void Food_Click(object sender, EventArgs e)
        {
            if (btnCheck.Visible == false)
            {
                btnCheck.Visible = true;
            }
            else
            {
                btnCheck.Visible = false;
            }
        }
        public void setLabelName(string name)
        {
            lbName.Text = name;
        }
        public void setLabelPrice(int price)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            lbPrice.Text = price.ToString("#,0đ", culture);
        }
    }
}

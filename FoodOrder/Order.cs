using FoodOrder.DTO;
using Guna.UI2.WinForms;
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
    public partial class Order : UserControl
    {
        public event EventHandler RemoveItemRequest;
        public int quantity;
        public Order()
        {
            InitializeComponent();
        }
        public void setLabelName(string name)
        {
            lbName.Text = name;
        }
        public void setLabelTotal(int total)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            lbTotal.Text = total.ToString("#,0đ", culture);
        }
        public void setQuantity(int quantity)
        {
            nmQuantity.Value = quantity;
        }

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            Guna2NumericUpDown value = (Guna2NumericUpDown)sender;
            
        }

        private void pctbDelete_Click(object sender, EventArgs e)
        {
            OnRemoveControl();
        }
        protected virtual void OnRemoveControl()
        {
            RemoveItemRequest?.Invoke(this, EventArgs.Empty);
        }
    }
}

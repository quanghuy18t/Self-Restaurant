using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class FoodOrder : UserControl
    {
        public FoodOrder()
        {
            InitializeComponent();
        }
        public void setLabelName(string name)
        {
            lbName.Text = name;
        }
        public void setLabelQuantity(string name)
        {
            lbQuantity.Text = "Số lượng: " + name;
        }
    }
}

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

namespace Employee
{
    public partial class OrderTableControl : UserControl
    {
        public OrderTableControl()
        {
            InitializeComponent();
        }
        public void setLabelName(string name)
        {
            lbTable.Text = name;
        }
        public void setLabelTime(string name)
        {
            lbTime.Text = name;
        }
    }
}

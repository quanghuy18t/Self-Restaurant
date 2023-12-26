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
    public partial class FoodForServe : UserControl
    {
        public FoodForServe()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (btnCheck.Visible == false)
            {
                btnCheck.Visible = true;
            }
            else btnCheck.Visible = false;
        }

        private void FoodForServe_Click(object sender, EventArgs e)
        {
            if (btnCheck.Visible == false)
            {
                btnCheck.Visible = true;
            }
            else btnCheck.Visible = false;
        }
        public void setLabelName(string name)
        {
            lbName.Text = name;
        }
    }
}

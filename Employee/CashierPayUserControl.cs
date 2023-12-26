using Employee.DAO;
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
    public partial class CashierPayUserControl : UserControl
    {
        BindingSource lstOrder = new BindingSource();
        public CashierPayUserControl()
        {
            InitializeComponent();

            dtgvOrder.DataSource = lstOrder;

            LoadOrder();
        }
        private void LoadOrder()
        {
            dtgvOrder.DataSource = OrdersDAO.Instance.GetListOrder();
        }
        private int SelectIdTable()
        {
            if (dtgvOrder.SelectedCells.Count > 0)
            {
                string tableName = dtgvOrder.SelectedCells[0].OwningRow.Cells["Tên bàn"].Value.ToString();
                return TablesDAO.Instance.getTableByName(tableName).IdTable;
            }
            return 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvOrder.DataSource = OrdersDAO.Instance.SearchTableByName(txtbTableName.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PaymentAction f = new PaymentAction(SelectIdTable());
            f.ShowDialog();
        }
    }
}

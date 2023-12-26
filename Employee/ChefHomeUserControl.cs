using Employee.DAO;
using Employee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class ChefHomeUserControl : UserControl
    {
        public ChefHomeUserControl()
        {
            InitializeComponent();

            LoadTableServe();
        }

        private void LoadTableServe()
        {
            flpTable.Controls.Clear();
            List<TABLES> lstTable = TablesDAO.Instance.getListTable(1);
            foreach (TABLES table in lstTable)
            {
                OrderTableControl btn = new OrderTableControl() { Width = TablesDAO.TableWidth, Height = TablesDAO.TableHeight};
                btn.setLabelName(table.Name);
                btn.setLabelTime(table.Create_at.ToString());
                btn.Click += btn_Click;
                btn.Tag = table.IdTable;

                flpTable.Controls.Add(btn);
            }
        }
        private void ShowOrder(int id)
        {
            flpFood.Controls.Clear();
            List<ORDERDETAIL> lstOrder = OrderDetailDAO.Instance.GetOrderDetailByTable(id);
            foreach (ORDERDETAIL order in lstOrder)
            {
                FoodOrder btn = new FoodOrder() { Width = 245, Height = 50};
                btn.setLabelName(FoodDAO.Instance.GetFoodOrder(order.IdFood).Name);
                btn.setLabelQuantity(order.Quantity.ToString());

                flpFood.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int idFood = (int)(sender as UserControl).Tag;
            ShowOrder(idFood);
        }
    }
}

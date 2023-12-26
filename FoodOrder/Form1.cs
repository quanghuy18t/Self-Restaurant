using FoodOrder.DAO;
using FoodOrder.DTO;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrder
{
    public partial class Form1 : Form
    {
        private Food food;
        private Order order;
        public Session session = new Session();
        public Form1()
        {
            InitializeComponent();

            LoadFood();
        }

        private Image ConvertToImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    return Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("File not found: " + imagePath);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image: " + ex.Message);
                return null;
            }
        }
        private int SumOfTotal()
        {
            int total = 0;
            List<ORDERITEM> lstItem = Session.getList();
            foreach (ORDERITEM item in lstItem)
            {
                total += item.Price;
            }
            return total;
        }
        private void LoadFood()
        {
            flpFood.Controls.Clear();
            List<FOOD> lstServe = ServeDAO.Instance.GetListServe(int.Parse(lbidBranch.Text));
            foreach (FOOD food in lstServe)
            {
                Food btn = new Food() { Width = ServeDAO.FoodWidth, Height = ServeDAO.FoodHeight };
                btn.BackgroundImage = ConvertToImage("D:\\TDMU\\Phân tích thiết kế hướng đối tượng\\Đồ án cuối kỳ\\Manage\\Manage\\Content\\images\\products\\" + food.Image);
                btn.Tag = food.IdFood;
                btn.setLabelName(food.Name);
                btn.setLabelPrice(food.Price);
                btn.Click += btn_Click;

                flpFood.Controls.Add(btn);
            }
        }
        private void LoadOrder()
        {
            flpOrder.Controls.Clear();
            List<ORDERITEM> lstItem = Session.getList();
            foreach(ORDERITEM item in lstItem)
            {
                Order btn = new Order();
                btn.setLabelName(item.Name);
                btn.setLabelTotal(item.Total);
                btn.Tag = item.IdFood;
                btn.RemoveItemRequest += btn_RemoveItemRequest;

                flpOrder.Controls.Add(btn);
            }
        }
        private void LoadTotal()
        {
            int total = SumOfTotal();
            CultureInfo culture = new CultureInfo("vi-VN");
            lbPoint.Text = (total / 10000).ToString();
            lbTotal.Text = total.ToString("#,0đ", culture);
        }
        /*private void AddFood(int idFood)
        {
            ORDERITEM item = new ORDERITEM(idFood);

        }*/

        private void btn_Click(object sender, EventArgs e)
        {
            int idFood = (int)(sender as UserControl).Tag;
            if (Session.CheckFoodInOrder(idFood))
            {
                ORDERITEM item = new ORDERITEM(idFood);
                session.AddObject(item);

                LoadOrder();
                LoadTotal();
            }
        }
        private void btn_RemoveItemRequest(object sender, EventArgs e)
        {
            List<ORDERITEM> lstItem = Session.getList();
            int id = (int)(sender as UserControl).Tag;
            foreach (ORDERITEM item in lstItem)
            {
                if (item.IdFood == id)
                {
                    lstItem.Remove(item);
                    LoadOrder();
                    LoadTotal();
                    return;
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lbTotal.Text != null || lbPoint.Text != null)
            {
                ORDERS order;
                int id = int.Parse(btnSubmit.Tag.ToString());
                if (id == 0)
                {
                    order = OrdersDAO.Instance.CreateNewOrder(1, SumOfTotal(), SumOfTotal() / 10000);
                    btnSubmit.Tag = id = order.IdOrder;
                }
                else
                {
                    order = OrdersDAO.Instance.GetOrderById(id);
                    OrdersDAO.Instance.UpdateOrder(order.IdOrder, SumOfTotal(), SumOfTotal() / 10000);
                }
                List<ORDERITEM> lstItem = Session.getList();
                foreach (ORDERITEM item in lstItem)
                {
                    if (OrderDetailDAO.Instance.CheckFoodInOrder(order.IdOrder, item.IdFood))
                    {
                        OrderDetailDAO.Instance.AddOrderDetail(order.IdOrder, item.IdFood, item.Price, item.Quantity);
                    }
                        
                }
                MessageBox.Show("Vui lòng chờ lấy món");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món!");
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            btnSubmit.Tag = 0;
            Session.ClearSession();
            LoadOrder();
            LoadTotal();
            MessageBox.Show("Vui lòng đến quầy thu ngân để thanh toán");
        }
    }
}

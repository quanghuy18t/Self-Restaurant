using Employee.DAO;
using Employee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class ChefFoodUserControl : UserControl
    {
        private FoodForServe foodForServe;
        public ChefFoodUserControl()
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
        private void LoadFood()
        {
            flpFood.Controls.Clear();
            List<FOOD> lstFood = FoodDAO.Instance.LoadFoodList();
            foreach(FOOD food in lstFood)
            {
                FoodForServe btn = new FoodForServe() { Width = FoodDAO.FoodWidth, Height = FoodDAO.FoodHeight};
                btn.BackgroundImage = ConvertToImage("D:\\TDMU\\Phân tích thiết kế hướng đối tượng\\Đồ án cuối kỳ\\Manage\\Manage\\Content\\images\\products\\" + food.Image);
                btn.Tag = food.IdFood;
                btn.setLabelName(food.Name);

                flpFood.Controls.Add(btn);
            }
        }
        private void GetUser()
        {
            WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
            string user = currentUser.User?.Value;
            MessageBox.Show("user: " + user);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            USERS user = new USERS();
            user = fEmployee.getInfoUser();
            foreach (UserControl item in flpFood.Controls)
            {
                if (item.Visible == true)
                {
                    int foodId = (int)item.Tag;
                    DateTime currDate = DateTime.Now;
                    ServeDAO.Instance.InsertServe(user.IdUser, foodId, currDate.Date);
                }
            }
        }
    }
}

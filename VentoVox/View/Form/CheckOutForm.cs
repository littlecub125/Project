using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox.Model;

namespace VentoVox.View
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }
        private static CheckOutForm _instance;
        OrderManager order;
       
        public static CheckOutForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CheckOutForm();
            }
            return _instance;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            order.Reset();
           
            HomeForm form = HomeForm.GetInstance();
            form.Activate();
            form.Show();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            order = OrderManager.GetInstance();
            InitUI();
        }

        private void InitUI()
        {
            List<FoodData> dataPurchaseList = order.GetFinalCheckOutItems();

            ListCheckOutItem.Clear();
            ListCheckOutDescription.Clear();


            foreach (var item in dataPurchaseList)
            {
                ListCheckOutItem.AddItem($"{item.FoodName}");
                ListCheckOutDescription.AddItem($"{item.FoodDescription}");
            }
           
        }

        private void btnGotoCheckOut_Click(object sender, EventArgs e)
        {
            using (CheckOutMsgForm CheckOutMsg = new CheckOutMsgForm())
            {
                MainForm.Getinstance().Opacity = 0.90d;
           
                CheckOutMsg.Owner = MainForm.Getinstance();
   
                DialogResult result = CheckOutMsg.ShowDialog();
                if (result == DialogResult.Abort)
                {
                    HomeForm PageHome = HomeForm.GetInstance();
                    PageHome.Activate();
                    PageHome.Show();
                }
                else if (result == DialogResult.OK)
                {
                    TakeFood();
                }
            }
            MainForm.Getinstance().Opacity = 1;
        }

        private void TakeFood()
        {
            order.CheckOut();
        }

        private void CheckOutForm_Shown(object sender, EventArgs e)
        {
            InitUI();
        }
    }
}

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
using VentoVox;
using VentoVox.Model;
using static VentoVoxKiosk.Pages.UserComponent.Menu_Comp;
using VentoVoxKiosk.Pages.UserComponent;

namespace VentoVoxKiosk.Pages
{
    public partial class CheckOutForm : Form
    {
        CheckOutMsgForm PageSystemMsgModal = new CheckOutMsgForm();
        private static CheckOutForm _instance;
        public CheckOutForm()
        {
            InitializeComponent();
        }
        public static CheckOutForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CheckOutForm();
            }
            return _instance;
        }
        private void btnTryCheckOut_Click(object sender, EventArgs e)
        {
            PopUpSystemMsgModal();
        }

        private void PopUpSystemMsgModal()
        {
            this.Opacity = 0.90d;
            this.MdiParent.Opacity = 0.90d;


            PageSystemMsgModal.ShowDialog();


            PageSystemMsgModal.Owner = this;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            UserAccount user = DataManager.GetInstance().GetCurrentUser();

            if (user == null)
            {
                MessageBox.Show("Please Log in with QR or ID/PW");
                return;
            }

            using (CheckOutMsgForm CheckOutMsg = new CheckOutMsgForm())
            {
                MainForm.Getinstance().Opacity = 0.90d;

                CheckOutMsg.Owner = MainForm.Getinstance();

                DialogResult result = CheckOutMsg.ShowDialog();
                if (result == DialogResult.No)
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
            OrderManager order = OrderManager.GetInstance();
            order.CheckOut();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            OrderManager order = OrderManager.GetInstance();

            FinalPurchase purchaseInfo =  order.GetFinalPurchasingOrder();

            for (int i=0; i< purchaseInfo.GetItems().Count; i++)
            {
                Menu_Comp item = new Menu_Comp();

                item.Button1Clicked += new ButtonClickEventHandler(FianlAccept);
                item.Button2Clicked += new ButtonClickEventHandler(RemoveFromFinalOrder);

                item.init(purchaseInfo.GetItems()[i], "Accept", "Cancel");

                item.Location = new Point(20, 10 + (i * (item.Height + 10)));
                item.Parent = panelCheckOutMenu;
            }
          
        }

        private void RemoveFromFinalOrder(object sender, EventArgs e)
        {
            OrderManager order = OrderManager.GetInstance();
            FinalPurchase purchaseInfo = order.GetFinalPurchasingOrder();
            Menu_Comp item = (Menu_Comp)sender;

            if (purchaseInfo.GetItems().Contains(item.data))
            {
                purchaseInfo.GetItems().Remove(item.data);
            }

            if (item.BackColor != Color.White)
            {
                item.BackColor = Color.White;
            }

        }

        private void FianlAccept(object sender, EventArgs e)
        {
            OrderManager order = OrderManager.GetInstance();
            FinalPurchase purchaseInfo = order.GetFinalPurchasingOrder();
            Menu_Comp item = (Menu_Comp)sender;

            if (!purchaseInfo.GetItems().Contains(item.data))
            {
                purchaseInfo.GetItems().Add(item.data);
            }
            if (item.BackColor != Color.Lime)
            {
                if (item.InvokeRequired)
                {
                    item.BeginInvoke(new Action(delegate ()
                    {
                        item.BackColor = Color.Lime;
                    }
                    ));
                }
                else
                {
                    item.BackColor = Color.Lime;
                }
                
            }



        }
    }
}

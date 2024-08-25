using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox;
using VentoVox.Model;
using VentoVoxKiosk.Controller.ETC;
using VentoVoxKiosk.Pages.UserComponent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static VentoVoxKiosk.Pages.UserComponent.Menu_Comp;

namespace VentoVoxKiosk.Pages
{
    public partial class MenuForm : Form
    {
        private static MenuForm _instance;
        List<FoodData> availableFoodList;
        List<Menu_Comp> menuComponentsList;
       
        public MenuForm()
        {
            InitializeComponent();
        }
        public static MenuForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MenuForm();
            }
            return _instance;
        }

        private void btnMoveToCheckOutPage_Click(object sender, EventArgs e)
        {
            CheckOutForm form = CheckOutForm.GetInstance();
            form.Activate();
            form.Show();

            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            availableFoodList = DataManager.GetInstance().getFoodOfferedList();
            menuComponentsList = new List<Menu_Comp>();
            //for (int i = 0; i < updatedFoodList.Count; i++)
            for (int i = 0; i < availableFoodList.Count; i++)
            {
                Menu_Comp item = new Menu_Comp();


                item.Button1Clicked += new ButtonClickEventHandler(ItemToCart);

                item.init(availableFoodList[i], "Add");

                item.Location = new Point(20 , 10 + (i*(item.Height+10)));
                item.Parent = panelFood;
            }

            for (int i = 0; i < availableFoodList.Count; i++)
            {
                Menu_Comp item = new Menu_Comp();


                item.Button1Clicked += new ButtonClickEventHandler(ItemToCart);

                item.init(availableFoodList[i], "Add");

                item.Location = new Point(20, 10 + (i * (item.Height + 10)));
                item.Parent = panelDrink;
            }


        }


        private void ItemToCart(object sender, EventArgs e)
        {
            Menu_Comp selectedMenu = (Menu_Comp)sender;

            string strFoodName = selectedMenu.data.FoodName;

            FoodSelectfromOptions(strFoodName, true);
        }

        private void FoodSelectfromOptions(string strFoodName, bool bAdd)
        {
            List<FoodData> dataList = DataManager.GetInstance().getFoodOfferedList();
            FoodData data = dataList.FirstOrDefault(x => x.FoodName == strFoodName);
            OrderManager order = OrderManager.GetInstance();
            try
            {
                if (data == null)
                {
                    Console.WriteLine("Food data is null");
                    return;
                }

                order.SelectFood(data, bAdd);

                string sLog = data.FoodName;

                if (bAdd == true)
                {
                    ListBoxCart.Items.Add(strFoodName);
              
                }
                else
                {
                    for (int i = 0; i < ListBoxCart.Items.Count; i++)
                    {
                        if (ListBoxCart.Items[i].ToString() == strFoodName)
                        {
                            ListBoxCart.Items.Remove(ListBoxCart.Items[i]);
                            break;
                        }
                    }
                
                }

            }
            catch (Exception)
            {

            }
        }

        private void ListBoxCart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int itemIndex = ListBoxCart.SelectedIndex;

            if (ListBoxCart.SelectedIndex >= 0)
            {
                FoodSelectfromOptions(ListBoxCart.Items[itemIndex].ToString(), false);
            }
        }
    }
}

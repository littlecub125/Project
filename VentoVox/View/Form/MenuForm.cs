using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VentoVox.View.UserComponent.menuOption;
using VentoVox.View.UserComponent;
using VentoVox.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace VentoVox.View
{
    public partial class MenuForm : Form
    {
        private static MenuForm _instance;
        List<FoodData> updatedFoodList;
        List<menuOption> updatedFoodPanelList = new List<menuOption>();
        OrderManager order;
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


        private void UpdateMenuAvailable()
        {
            updatedFoodList = DataManager.GetInstance().getFoodOfferedList();

            //for (int i = 0; i < updatedFoodList.Count; i++)
            for (int i = 0; i < updatedFoodList.Count; i++)
            {
                menuOption item = new menuOption();
                item.Menu = updatedFoodList[i];
                item.Location = new Point(14 + i * 270, 13);
                item.Parent = panelMenu;
                item.Size = new Size(250, 480);

                item.Button1Text = "Add";
                item.Button2Text = "Remove";

                item.Button1Clicked += new ButtonClickEventHandler(ItemToCart);
                item.Button2Clicked += new ButtonClickEventHandler(RemoveItemFromCart);

                updatedFoodPanelList.Add(item);
            }
        }

        private void RemoveItemFromCart(object sender, EventArgs e)
        {
            menuOption selectedMenu = (menuOption)sender;

            string menuName = selectedMenu.MenuTitle;
            FoodSelectfromOptions(menuName, false);
        }

        private void FoodSelectfromOptions(string _selectFoodName, bool _bAdd)
        {
            List<FoodData> dataList = DataManager.GetInstance().getFoodOfferedList();

            FoodData data = dataList.FirstOrDefault(x => x.FoodName == _selectFoodName);

            try
            {
                if (data == null)
                {
                    Console.WriteLine("Food data is null");
                    return;
                }

                order.SelectFood(data, _bAdd);

                string sLog = data.FoodName;

                if (_bAdd == true)
                {
                    ListBoxCart.AddItem(_selectFoodName);
                    Console.WriteLine(_selectFoodName + " is added");
                }
                else
                {
                    for (int i = 0; i < ListBoxCart.Items.Count; i++)
                    {
                        if (ListBoxCart.Items[i].Text == _selectFoodName)
                        {
                            ListBoxCart.Items.Remove(ListBoxCart.Items[i]);
                            break;
                        }
                    }
                    Console.WriteLine(_selectFoodName + " is removed");
                }

            }
            catch (Exception)
            {

            }
        }

        private void ItemToCart(object sender, EventArgs e)
        {
            menuOption selectedMenu = (menuOption)sender;

            string menuName = selectedMenu.MenuTitle;

            //ListBoxCart.AddItem(menuName);
            FoodSelectfromOptions(menuName, true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            order.Reset();
            ListBoxCart.Items.Clear();

            HomeForm form = HomeForm.GetInstance();
            form.Activate();
            form.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            order = OrderManager.GetInstance();
            UpdateMenuAvailable();
            order.StartBuildOrder();
        }

        private void btnGotoCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm form = CheckOutForm.GetInstance();
            form.Activate();
            form.Show();
        }

        private void ListBoxCart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int itemIndex = ListBoxCart.SelectedIndex;

            if (ListBoxCart.SelectedIndex >= 0)
            {
                //ListBoxCart.Items.Remove(ListBoxCart.Items[itemIndex]);
                FoodSelectfromOptions(ListBoxCart.Items[itemIndex].Text, false);
            }
        }
    }
}

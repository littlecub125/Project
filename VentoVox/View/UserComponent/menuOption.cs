using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox.Model;

namespace VentoVox.View.UserComponent
{
    public partial class menuOption : UserControl
    {
        public menuOption()
        {
            InitializeComponent();
        }
        private FoodData _Menu;
        public FoodData Menu
        {
            get
            {
                return _Menu;
            }
            set
            {
                _Menu = value;
                SetUIData();
            }
        }

        private void SetUIData()
        {
            lbMenuTitle.Text = Menu.FoodName;
            picFood.Image = Menu.FoodImage;
            lbFoodDescription.Items.Clear();
            lbFoodDescription.Items.Add(Menu.FoodDescription);
        }

        public string MenuTitle
        {
            get
            {
                return Menu.FoodName;
            }
        }

        public Image MenuImage
        {
            get
            {
                return Menu.FoodImage;
            }

        }

        public string MenuDescription
        {
            get
            {
                return Menu.FoodDescription;
            }

        }

        public string Button1Text
        {
            get
            {
                return Button1.Text;
            }
            set
            {
                Button1.Text = value;
            }
        }

        public string Button2Text
        {
            get
            {
                return Button2.Text;
            }
            set
            {
                Button2.Text = value;
            }
        }
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);

        public event ButtonClickEventHandler Button1Clicked;

        public event ButtonClickEventHandler Button2Clicked;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Button1Clicked != null)
            {
                Button1Clicked(this, EventArgs.Empty);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Button2Clicked != null)
            {
                Button2Clicked(this, EventArgs.Empty);
            }
        }
    }
}

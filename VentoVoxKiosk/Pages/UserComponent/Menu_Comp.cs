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

namespace VentoVoxKiosk.Pages.UserComponent
{
    public partial class Menu_Comp : UserControl
    {
        private FoodData _data;
        private Color _BackColor;
        public Menu_Comp()
        {
            InitializeComponent();           
        }
        public void init(FoodData dataReceived, string button1 = null, string button2 = null)
        {
            data = dataReceived;

            if (button1 != null)
            {
                Button1Text = button1;
            }
            else
            {
                Button1.Visible = false;
            }

            if (button2 != null)
            {
                Button2Text = button2;
            }
            else
            {
                Button2.Visible = false;
            }

            _BackColor = Color.White;
        }
        /*
        public Color BackColor
        {
            get
            {
                return _BackColor;
            }
            set
            {
                _BackColor = value;
                this.BackColor = _BackColor;
            }
        }
        */
        public FoodData data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                lbFoodName.Text = value.FoodName;
                tbDescription.Text = value.FoodDescription;
                pbFood.Image = value.FoodImage;
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

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Button1Clicked != null)
            {
                Button1Clicked(this, EventArgs.Empty);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Button2Clicked != null)
            {
                Button2Clicked(this, EventArgs.Empty);
            }
        }
    }
}

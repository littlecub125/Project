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
using VentoVox.Master;
using VentoVox;

namespace VentoVoxKiosk.Pages
{
    public partial class HomeForm : Form
    {
        LoginForm PageLoginModal = new LoginForm();
        private static HomeForm _instance;

        SeqManager control = null;

        public HomeForm()
        {
            InitializeComponent();
        }
        public static HomeForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HomeForm();
            }
            return _instance;
        }
        private void btnLoginShow_Click(object sender, EventArgs e)
        {
            PopUpLoginModal();

        }

        private void PopUpLoginModal()
        {
            this.Opacity = 0.90d;
            this.MdiParent.Opacity = 0.90d;
            PageLoginModal.Owner = this;
            DialogResult result = PageLoginModal.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
            else
            {

            }



            this.Opacity = 1d;
            this.MdiParent.Opacity = 2d;


        }

        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            InitManagers();


            MenuForm form = MenuForm.GetInstance();
            form.Activate();
            form.Show();

            this.Hide();
        }

        private void InitManagers()
        {
            control = SeqManager.GetInstance();

            bool[] bResult = control.InitSequence();

            DataManager data = null;
            OrderManager order = null;
            try
            {
                data = DataManager.GetInstance();
                order = OrderManager.GetInstance();
            }
            catch (Exception e)
            {

            }
        }
    }
}

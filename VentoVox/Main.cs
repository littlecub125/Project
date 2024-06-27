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
using VentoVox.ControlManager.Application;
using VentoVox.Interface;
using VentoVox.Master;
using VentoVox.View;
using static VentoVox.MainForm;
using static VentoVox.Master.BaseManager;

namespace VentoVox
{
    public partial class MainForm : Form
    {
        
        #region UI Controls
        bool bMenuExpand = false;
        List<Label> menuList;

        public static int parentX, parentY;
        private int TargetYPosition = 20;
        private int animationSpeed = 1;
        private int currentIndex = 0;


        TipsForm PageTips; 
        CheckOutForm PageCheckOut;
        MenuForm PageMenu;
        HomeForm PageHome;
        LoginForm PageLoginModal;

        public static MainForm _instance;

        public static MainForm Getinstance()
        {
            if ( _instance == null )
            {
                _instance = new MainForm();
            }

            return _instance;
        }
            


        public MainForm()
        {
            InitializeComponent();
            initUI();
        }
        private void initUI()
        {
            menuList = new List<Label>() { menuPage1 , menuPage2, menuPage3, menuPage4 };
            AttachMenuHandler(menuList);
            
        }
        private void AttachMenuHandler(List<Label> menulist)
        {
            foreach (Label label in menulist)
            {
                label.Hide();

                label.MouseHover += Label_MouseHover;
                label.MouseLeave += Label_MouseLeave;
            }
        }

        private void HideMenu()
        {
            foreach (Label label in menuList)
            {
                label.Hide();

                label.Location = new Point(label.Location.X, 3);
            }
        }
        private void Label_MouseLeave(object sender, EventArgs e)
        {
            // ((Label)sender).BackColor = Color.FromArgb(19, 48, 78);
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void Label_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(36, 68, 106);
        }

        private void timerMenuExpand_Tick(object sender, EventArgs e)
        {
            if (bMenuExpand == false)
            {
                menuContainer.Height += 5;
                if (menuContainer.Height >= 90)
                {
                    timerMenuExpand.Stop();
                    bMenuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 5;
                if (menuContainer.Height <= 0)
                {
                    timerMenuExpand.Stop();
                    bMenuExpand = false;
                }
            }
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            Label currentMenu = menuList[currentIndex];
           
            if (bMenuExpand == true)
            {
                if (currentMenu.Top < TargetYPosition)
                {
                    currentMenu.Top += animationSpeed;
                    currentMenu.Show();
                }
                else if (currentMenu.Top > TargetYPosition)
                {
                    currentMenu.Top -= animationSpeed;
                }
                else
                {
                    currentIndex++;
                    if (currentIndex >= menuList.Count)
                    {
                        menuTimer.Stop();
                        currentIndex = 0;
                    }
                    else
                    {
                        menuTimer.Start();
                    }
                }
            }
            else
            {
                HideMenu();
                currentIndex = 0;
            }
        }

        private void SubFormClosed(object sender, FormClosedEventArgs e)
        {
            Form page = (Form)sender;
            page = null;
        }


        private void menuPage1_Click(object sender, EventArgs e)
        {
            PageHome.Activate();
            PageHome.Show();

        }
        private void menuPage2_Click(object sender, EventArgs e)
        {
            PageMenu.Activate();
            PageMenu.Show();
        }



        private void menuPage3_Click(object sender, EventArgs e)
        {
            PageCheckOut.Activate();
            PageCheckOut.Show();


        }

        private void menuPage4_Click(object sender, EventArgs e)
        {
            PageTips.Activate();
            PageTips.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.90d;
            PageLoginModal = LoginForm.GetInstance();
            PageLoginModal.LoginStatusChangedEvent += InitForms;
            
            PageLoginModal.ShowDialog();

            PageLoginModal.Owner = this;
            parentX = this.Location.X;
            parentY = this.Location.Y;
        }

        private void InitForms()
        {

            this.Opacity = 1;
            PageTips = TipsForm.GetInstance();
            PageMenu = MenuForm.GetInstance();
            PageHome = HomeForm.GetInstance();
            PageCheckOut = CheckOutForm.GetInstance();

            PageTips.FormClosed += SubFormClosed;
            PageTips.MdiParent = this;
            PageTips.Dock = DockStyle.Fill;

            PageMenu.FormClosed += SubFormClosed;
            PageMenu.MdiParent = this;
            PageMenu.Dock = DockStyle.Fill;

            PageHome.FormClosed += SubFormClosed;
            PageHome.MdiParent = this;
            PageHome.Dock = DockStyle.Fill;

            PageCheckOut.FormClosed += SubFormClosed;
            PageCheckOut.MdiParent = this;
            PageCheckOut.Dock = DockStyle.Fill;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            timerMenuExpand.Start();

            menuTimer.Start();

        }



        #endregion

        #region Manager Class

        BaseManager control = null;
        DataManager data = null;
        OrderManager order = null;



        private void InitManagers()
        {
            control = new BaseManager();
            bool[] bResult = control.InitSequence();

            try
            {
                control.AppMaster[(int)AppThread.WebManager].SetName("Web Manager");
                control.HwMaster[(int)HWThread.HWManager].SetName("HW Manager");
                data = DataManager.GetInstance();
                order = OrderManager.GetInstance();
            }
            catch (Exception e)
            {

            }
        }




        #endregion


    }
}

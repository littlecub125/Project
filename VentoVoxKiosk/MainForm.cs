using panelMain;
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
using VentoVox.ControlManager.Application;
using VentoVoxKiosk.Pages;
using static VentoVox.ControlManager.Application.LogManager;

namespace VentoVoxKiosk
{
    public partial class MainForm : Form
    {
        HomeForm HomePage;
        MenuForm MenuPage;
        CheckOutForm CheckOutPage;
        LogManager logManager;
        public static MainForm _instance;

        public static int parentX, parentY;
        public MainForm()
        {
            InitializeComponent();
        }
        public static MainForm Getinstance()
        {
            if (_instance == null)
            {
                _instance = new MainForm();
            }

            return _instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataManager.GetInstance().Update();

            parentX = this.Location.X;
            parentY = this.Location.Y;

            HomePage = HomeForm.GetInstance();
            HomePage.MdiParent = this;
            HomePage.Dock = DockStyle.Fill;
            HomePage.Show();

            MenuPage = MenuForm.GetInstance();
            MenuPage.MdiParent = this;
            MenuPage.Dock = DockStyle.Fill;

            CheckOutPage = CheckOutForm.GetInstance();
            CheckOutPage.MdiParent = this;
            CheckOutPage.Dock = DockStyle.Fill;

            logManager = LogManager.GetInstance();
            logManager.PropertyChanged += OnPropertyChanged;

          
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            if (e.PropertyName == nameof(logManager.WarningMessage))
            {
                SetToastMsg(logManager.WarningMessage, LogLevel.Warning);
            }
            else if (e.PropertyName == nameof(logManager.ErrorMessage))
            {

                SetToastMsg(logManager.ErrorMessage, LogLevel.Error);
            }
            else if (e.PropertyName == nameof(logManager.NormalMessage))
            {
                SetToastMsg(logManager.NormalMessage, LogLevel.Normal);

            }

        }
        public void SetToastMsg(string msg, LogLevel level)
        {
            ToastMsg toastMsg = new ToastMsg(msg, level);

            string strLog = DateTime.Now + " " + msg;
            (string, LogLevel) item = (strLog, level);

            logManager.LogMsgQueue.Enqueue(item);

            toastMsg.Show();
            toastMsg.BringToFront();
            toastMsg.TopMost = true;
        }
    }
}

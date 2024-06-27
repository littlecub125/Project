using KYBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox.View.UserComponent;
using static VentoVox.OrderManager;
using static VentoVox.View.UserComponent.menuOption;

namespace VentoVox.View
{
    public partial class HomeForm : Form
    {
        private static HomeForm _instance;
        OrderManager order = null;
        private int animationSpeed = 1;
        private int MaxVideoPanel = 0;
        private int MaxPersonalPanel = 0;
        List <KYBGradationRow> panelVideoList;
        List<KYBGradationRow> panelPersonalInfoList;

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

        private void HomeForm_Load(object sender, EventArgs e)
        {
            order = OrderManager.GetInstance();

            panelVideoList = new List<KYBGradationRow> { panelVideo1, panelVideo2 };
            panelPersonalInfoList = new List<KYBGradationRow> { panelPersonalInfo1, panelPersonalInfo2, panelPersonalInfo3 };
            MaxVideoPanel = panelVideoList.Count;
            MaxPersonalPanel = panelPersonalInfoList.Count;
            SetFormData();
            InitUI();

        }

        private void InitUI()
        {
        }

        private void SetFormData()
        {
            
        }

        private void btnStartOrder_Click(object sender, EventArgs e)
        {

            MenuForm form = MenuForm.GetInstance();
            form.Activate();
            form.Show();
        }


    }
}

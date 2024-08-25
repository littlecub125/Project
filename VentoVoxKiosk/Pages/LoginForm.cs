using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVoxKiosk.Controller.ETC;

namespace VentoVoxKiosk.Pages
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MainForm.parentX +MainForm.Getinstance().Width / 2 - this.Width / 2,
                MainForm.parentY + MainForm.Getinstance().Height / 2 - this.Height / 2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQRCheck_Click(object sender, EventArgs e)
        {
            DataManager.GetInstance().CheckQRLoginInfoExist();
        }
    }
}

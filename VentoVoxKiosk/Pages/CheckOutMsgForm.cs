using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentoVoxKiosk.Pages
{
    public partial class CheckOutMsgForm : Form
    {

        public CheckOutMsgForm()
        {
            InitializeComponent();
        }

        private void SystemMsg_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MainForm.parentX + MainForm.Getinstance().Width / 2 - this.Width / 2,
            MainForm.parentY + MainForm.Getinstance().Height / 2 - this.Height / 2);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No ;
            this.Close();
        }
    }
}

using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentoVox
{
    public partial class CheckOutMsgForm : Form
    {
        public CheckOutMsgForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MaterialButton button = (MaterialButton) sender;

            switch (button.Name)
            {
                case "btnAccept":
                    this.DialogResult = DialogResult.OK;
                    break;
                case "btnCancel":
                    this.DialogResult = DialogResult.Cancel;
                    break;
                case "btnReset":
                    this.DialogResult = DialogResult.Abort;
                    OrderManager order = OrderManager.GetInstance();
                    order.Reset();
                    break;
            }

            Close();
        }

        private void CheckOutMsgForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MainForm.parentX + MainForm.Getinstance().Width / 2 - this.Width / 2,
                MainForm.parentY + MainForm.Getinstance().Height / 2 - this.Height / 2);
        }
    }
}

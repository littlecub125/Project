using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox;
using static VentoVox.ControlManager.Application.LogManager;

namespace panelMain
{
    public partial class ToastMsg : Form
    {
        int toastX, toastY;
        LogLevel msgLevel;
        public ToastMsg(string msg, LogLevel level)
        {
            InitializeComponent();

            InitUI(msg, level);
        }

        private void InitUI(string msg, LogLevel level)
        {
            lbLogLevel.Text = level.ToString();
            lbMsg.Text = msg;
            switch (level)
            {
                case LogLevel.Error:
                    ToastBorder.BackColor = Color.Red;
                    break;
                case LogLevel.Warning:
                    ToastBorder.BackColor = Color.Yellow;
                    break;
                case LogLevel.Normal:
                    ToastBorder.BackColor = Color.Lime;
                    break;
            }
      


        }
     
        private void ToastMsg_Load(object sender, EventArgs e)
        {
            Position();
        }

        int y = 100;
        private void timerHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Opacity -= 0.02d;
                this.Location = new Point(toastX, toastY);
                if (toastY > 950)
                {
                    timerHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
         
        }

        private void Position()
        {
            toastX = MainForm.parentX + MainForm.Getinstance().Width - this.Width - 50;
            if (msgLevel == LogLevel.Normal)
            { 
                toastY = MainForm.parentY + MainForm.Getinstance().Height - this.Height - 50;
            }
            else 
            {
                toastY = MainForm.parentY + MainForm.Getinstance().Height - this.Height - 150;
            }
            this.Location = new Point(toastX, toastY);
        }
    }
}

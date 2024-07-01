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
using static VentoVox.Model.UserAccount;

namespace VentoVox.View
{
    public partial class LoginForm : Form
    {
        UserAccount User;
        bool _bLoginSuccess = false;
        private static LoginForm _instance = null;
        public delegate void LoginStatusChanged();
        public event LoginStatusChanged LoginStatusChangedEvent = null;

        public static LoginForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoginForm();
            }
            return _instance;
        }
        public bool bLoginSuccess
        {
            get
            {
                return _bLoginSuccess;
            }
            set
            {
                //if (_bLoginSuccess != value)
                {
                    _bLoginSuccess = true;
                    if (_bLoginSuccess == true)
                    {
                        CloseLoginForm(_bLoginSuccess);
                        if (LoginStatusChangedEvent != null)
                        {
                            LoginStatusChangedEvent();
                        }
                    }
                }
            }
        }

        private void CloseLoginForm(bool bLogin)
        {
            if (bLogin)
            {
                this.DialogResult = DialogResult.OK;
            
                
                Close();
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

        }

        public LoginForm()
        {
            InitializeComponent();
            InitUI();
        }
        private void InitUI()
        {
            var values = Enum.GetValues(typeof(AccountClassification)).Cast<AccountClassification>();
            var typeClassification = values.Select(v => v.ToString());

            foreach (var item in typeClassification)
            {
                cbClassification.Items.Add(item);
            }
            cbClassification.SelectedIndex = 0;

            picProfile.Image = Properties.Resources.profile;
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void RequestLogin()
        {
            bool bRes = false;
            string strID = tbIDVerification.Text;
            string strPW = tbPWVerification.Text;
            AccountClassification type = (AccountClassification)cbClassification.SelectedIndex;
            try
            {
                btnLogin.Enabled = false;
                User = new UserAccount(strID, strPW, type);
                bRes = User.RequestOfflineLogin();

                // 20240625
                // kyb temp close 
                /*
                if (bResult == false)
                {
                    var thLogin = Task.Run(() => User.RequestOnlineLogin());
                    bRes = await thLogin;
                }
                else
                {
                    bRes = true;
                }
              
                */
            }
            catch
            {
                bRes = false;
            }

            bLoginSuccess = bRes;

            if (!bLoginSuccess)
            {
                string strMsg = "Failed to Login";
                MessageBox.Show(strMsg);
            }
            else if (bLoginSuccess)
            {
                string strMsg = "Login Success";
                MessageBox.Show(strMsg);
            }

            btnLogin.Enabled = true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            RequestLogin();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MainForm.parentX + MainForm.Getinstance().Width/2 - this.Width/2,
                MainForm.parentY + MainForm.Getinstance().Height/2 - this.Height / 2);
        }
    }
}

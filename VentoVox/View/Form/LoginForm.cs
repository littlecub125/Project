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
        UserAccount User = UserAccount.GetInstance();
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
                DataManager.GetInstance().LinkUser(User);
                
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
        }
        private void InitUI()
        {
            var values = Enum.GetValues(typeof(AccountClassification)).Cast<AccountClassification>();
            var typeClassification = values.Select(v => v.ToString());

            foreach (var item in typeClassification)
            {
                cbClassification.Items.Add(item);
            }


            picProfile.Image = Properties.Resources.profile;
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void TryLogin()
        {
            string strID = tbIDVerification.Text;
            string strPW = tbPWVerification.Text;
            AccountClassification type = (AccountClassification)cbClassification.SelectedIndex;
            try
            {
                SetUserInfo(strID, strPW, type);
            }
            catch
            {
                return;
            }
        }

        public async void SetUserInfo(string strID, string strPW, AccountClassification type)
        {
            bool bRes = false;


            
            try
            {
                btnLogin.Enabled = false;
                bool bResult = User.RequestOfflineLogin(strID, strPW, type);
                bResult = true;
                // 20240625
                // kyb temp close 
                /*
                if (bResult == false)
                {
                    var thLogin = Task.Run(() => User.RequestOnlineLogin(strID, strPW, type));
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
            TryLogin();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MainForm.parentX + MainForm.Getinstance().Width/2 - this.Width/2,
                MainForm.parentY + MainForm.Getinstance().Height/2 - this.Height / 2);
        }
    }
}

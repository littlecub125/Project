using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VentoVox.Model
{
    public class UserAccount 
    {
        #region Parameters
        private string _id;
        private string _password;
        private int _FoodTicketNum;
        private static UserAccount _instance = null;
        private AccountClassification _classification;

        public enum AccountClassification
        {
            Tester,
            Student,
            Worker,
            Visiitor,
        }

        public static UserAccount GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserAccount();
            }
            return _instance;
        }

        public AccountClassification UserClassification 
        {
            get
            {
                return _classification;
            }
            set
            {
                _classification = value;
            }
        }

        public string strUserId
        {
            get
            {
                return _id;
            }
            set
            { 
                _id = value;
            }

        }


        public string strUserPw
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public int FoodTicketNum
        {
            get
            {
                return _FoodTicketNum;
            }
            set
            {
                _FoodTicketNum = value;
            }
        }
        #endregion


        #region Functions


        public bool RequestOfflineLogin(string Id, string Password, AccountClassification Classification, int timeWait = 10000)
        {
            bool bRes = false;

            // TO Do compare offline data

            return bRes;
        }
        public bool RequestOnlineLogin(string Id, string Password, AccountClassification Classification, int timeWait = 10000)
        {
            bool bRes = false;
            int nTimePassed = 0;

            while (bRes == false && nTimePassed < timeWait)
            {
                if (Id == "yubi2023" && Password == "1004")
                {
                    bRes = true;
                }
                // TODO : LOGIN 작업 추가 필요
                Thread.Sleep(100);
                nTimePassed += 100;
            }

            return bRes;
        }

        public bool CurrentLoginStatus()
        {
            bool bRes = false;

            return bRes;
        }

        #endregion



    }
}

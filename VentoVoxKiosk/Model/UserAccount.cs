using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentoVoxKiosk.Controller.ETC;

namespace VentoVox.Model
{
    public class UserAccount 
    {
        #region Parameters
        private string _id;
        private string _password;
        private int _FoodTicketNum;

        private AccountClassification _classification;
        
        public enum AccountClassification
        {
            Tester,
            Student,
            Worker,
            Visiitor,
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


        public UserAccount(string strID, string strPW, AccountClassification account)
        {
            strUserId = strID;
            strUserPw = strPW;
            UserClassification = account;

        }



    }
}

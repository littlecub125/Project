using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox.Interface;
using VentoVox.Model;
using static VentoVox.Model.UserAccount;

namespace VentoVox
{
    public class DataManager 
    {
        #region Param
        private List<FoodData> foodOffered = new List<FoodData>();
        private List<UserAccount> userAllowed = new List<UserAccount>();
  

        private static DataManager _instance;
        private UserAccount currentUser;
 
        string _seqName = string.Empty;

        public UserAccount GetCurrentUser() { return currentUser; }

        public void SetSeqName(string seqName)
        {
            _seqName = seqName;
        }

        public static DataManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataManager();
            }
            return _instance;
        }


        #endregion

        public List<FoodData> getFoodOfferedList()
        {
            return foodOffered;
        }

        public bool CheckLoginInfoExist(UserAccount user)
        {
            bool bFound = false;


            foreach (UserAccount item in userAllowed)
            {
                if (item.strUserId == user.strUserId && 
                    item.strUserPw == user.strUserPw && 
                    item.UserClassification == user.UserClassification)
                {
                    currentUser = item;
                    bFound = true;
                    break;
                }
            }

            return bFound;
        }
        // TO DO
        // 백엔드에서 제공되는 음식의 이름, 설명, 이미지파일 재고수량 가져오기
        private void GetFoodProvided()
        {
            // To Do 음식 데이터 web 통해서 확인 후 업데이트

            Image img = Properties.Resources.vegan_2;


            FoodData data = new FoodData("Sample name", img, "Sample description", 2, DateTime.Now );
            foodOffered.Add(data);
            foodOffered.Add(data);
            foodOffered.Add(data);
        }

        private void GetUserUpdate()
        {
            LoadUserInfo();
        }

        private void EmptyData()
        {
            foodOffered.Clear();
            userAllowed.Clear();
        }


        public void Update()
        {
            EmptyData();
            GetFoodProvided();
            GetUserUpdate();
        }

        public void SaveData(FinalPurchase purchaseData)
        {
            UpdateUserInfo(currentUser, purchaseData);
        }

        private void UpdateUserInfo(UserAccount userData, FinalPurchase purchaseData)
        {
            int nFoodTicketLeft = userData.FoodTicketNum - purchaseData.GetItems().Count();
            string userClassification = userData.UserClassification.ToString();
            string userID = userData.strUserId;
            userData.FoodTicketNum = nFoodTicketLeft;
        }

        private void LoadUserInfo()
        {
            UserAccount data1 = new UserAccount("yubi2023", "1234", AccountClassification.Tester);
            UserAccount data2 = new UserAccount("kitae", "1234", AccountClassification.Tester);
            UserAccount data3 = new UserAccount("customer", "1234", AccountClassification.Student);

            data1.FoodTicketNum = 10;
            data2.FoodTicketNum = 10;
            data3.FoodTicketNum = 10;

            userAllowed.Add(data1);
            userAllowed.Add(data2);
            userAllowed.Add(data3);
        }
    }
}

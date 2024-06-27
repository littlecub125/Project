using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentoVox.Interface;
using VentoVox.Model;

namespace VentoVox
{
    public class DataManager 
    {

        #region Param
        private List<FoodData> foodOffered = new List<FoodData>();
        private List<UserAccount> userAllowed = new List<UserAccount>();
        private static DataManager _instance;
        private UserAccount user = new UserAccount();

        string _seqName = string.Empty;

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

        public void LinkUser(UserAccount _LoggedInUser)
        {
            user = _LoggedInUser;
        }
        #endregion

        public List<FoodData> getFoodOfferedList()
        {
            return foodOffered;
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
           // TO DO user data update
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




    }
}

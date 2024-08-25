using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox.Interface;
using VentoVox.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static VentoVox.Model.UserAccount;

using System.IO;
using System.Data.SQLite;
using VentoVoxKiosk.Controller.Ext.AppThread;

namespace VentoVoxKiosk.Controller.ETC
{
    public class DataManager 
    {
        #region Param
        public enum VerifyOption
        {
            QR,
            ID,
        }

        private IDVerifyManager Verfier = new IDVerifyManager();
        private List<FoodData> foodOffered = new List<FoodData>();
        private List<UserAccount> userAllowed = new List<UserAccount>();
        private SQLIte SQLController = new SQLIte();

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
        public bool CheckQRLoginInfoExist()
        {
            bool bFound = false;

            Verfier.QRCheck();


            return bFound;
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

            Image img1 = Image.FromFile(Application.StartupPath + @"\UI\FOOD\Hamburger.jpg");
            Image img2 = Image.FromFile(Application.StartupPath + @"\UI\FOOD\FriedRice.jpg");
            Image img3 = Image.FromFile(Application.StartupPath + @"\UI\FOOD\Pasta.jpg");

            FoodData data1= new FoodData("Hamburger", img1, "Sample description", 2, DateTime.Now );
            FoodData data2 = new FoodData("Fried Rice", img2, "Sample description", 2, DateTime.Now);
            FoodData data3 = new FoodData("Pasta", img3, "Sample description", 2, DateTime.Now);
            foodOffered.Add(data1);
            foodOffered.Add(data2);
            foodOffered.Add(data3);
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

        public void CreateSQL()
        {
            SQLController.CreateFile("AccountSQL.sqlite");
            SQLController.ModifyFile(SQLIte.SQLCMD.Insert);
        }

        class SQLIte
        {
            SQLiteConnection conn = null;
            public enum SQLCMD
            {
                Insert,
                Update,
                Delete,

            }
  
            
            public void LoadFile(string filePath)
            {
                conn = new SQLiteConnection(filePath);
            }

            public void ModifyFile(SQLCMD SQLcmd)
            {
                
         
                SQLiteCommand cmd = null;
                string sql = string.Empty;

                switch (SQLcmd)
                {
                    case SQLCMD.Insert:
                        sql = $"INSERT INTO members VALUES ('yubi2023', '1234', 10, '{AccountClassification.Tester.ToString()}')";
                        cmd = new SQLiteCommand(sql, conn);
                        break;

                    case SQLCMD.Update:
                        cmd.CommandText = "UPDATE FROM members WHERE Id=1";
                        break;

                    case SQLCMD.Delete:
                        cmd.CommandText = "DELETE FROM members WHERE Id=1";
                        break;

                    default:
                        break;

                }
                cmd.ExecuteNonQuery();
            }

            public void CreateFile(string strFile)
            {
                SQLiteConnection.CreateFile(strFile);
                conn = new SQLiteConnection($"Data Source={strFile};Version=3;");
                conn.Open();
                string sql = "create table members (ID varchar(20), PW varchar(20), ticket int, Type varChar(20))";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                int result = command.ExecuteNonQuery();

                sql = "create index idx01 on members(ID)";
                command = new SQLiteCommand(sql, conn);
                result = command.ExecuteNonQuery();
            }
        }
    }
}

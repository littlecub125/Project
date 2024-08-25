using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox.ControlManager.Application;
using VentoVox.Interface;
using VentoVox.Model;
using VentoVoxKiosk.Controller.ETC;
using static VentoVox.ControlManager.Application.LogManager;

namespace VentoVox
{
    public class OrderManager 
    {
        public enum OrderPage
        {
            HOME,
            MENU,
            CHECK_OUT,
        }
        string _seqName = string.Empty;
        FinalPurchase _finalInfo = null;
        object order;
        LogManager logController = LogManager.GetInstance();
        static OrderManager _instance = null;
        private FinalPurchase PurchasingInfo
        {
            get { return _finalInfo; }
            set { _finalInfo = value; }
        }

        public OrderManager() 
        {
            this.Reset();
            
        }
        public static OrderManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new OrderManager();
            }
            return _instance;
        }
        public void Reset() 
        { 
            this.PurchasingInfo = null;
            
        }


        // Step 1 Process
        public void StartBuildOrder()
        {
            PurchasingInfo = new FinalPurchase();
        }

        // Step 2 Process
        public void SelectFood(FoodData selectedFood, bool bAdd)
        {
            bool bFoodAvailable = false;
            bFoodAvailable = CheckFoodIsAvailable(selectedFood);
            // TODO 
            // web 에서 음식 가능한지 확인
            //if (bFoodAvailable == true && bAdd == true)
            if (PurchasingInfo == null)
            {
                StartBuildOrder();
            }

            if (bAdd == true)
            {
                logController.SetMsg($"{selectedFood.FoodName} is added", LogLevel.Normal); 
                PurchasingInfo.FoodDataAdd(selectedFood);
            }
            else if (bAdd == false)
            {
                logController.SetMsg($"{selectedFood.FoodName} is removed", LogLevel.Normal); ;
                PurchasingInfo.FoodDataRemove(selectedFood);
            }

        }

        private bool CheckFoodIsAvailable(FoodData selectedFood)
        {
            bool bRes = false;

            // KYB 20240530
            // To Do Data Manager를 통해 재고 확인


            return bRes;
        }

        
        public void CheckOut()
        {
            int nFoodTicketAvailable = CheckAvailableFoodTicket();
            int nOrderingNum = PurchasingInfo.GetItems().Count;
            string strMsg = string.Empty;
            if (nFoodTicketAvailable - nOrderingNum > 0)
            {
                DataManager.GetInstance().SaveData(PurchasingInfo);
                strMsg = $"{nFoodTicketAvailable - nOrderingNum} ticket is left";
                logController.SetMsg(strMsg, LogLevel.Normal);
            }
            else
            {
                strMsg = "Low Food ticket number";
                logController.SetMsg(strMsg, LogLevel.Warning); 
            }
          
        }

        private int CheckAvailableFoodTicket()
        {
            int nFoodTicketLeft = 0;
      
            nFoodTicketLeft = DataManager.GetInstance().GetCurrentUser().FoodTicketNum;

            return nFoodTicketLeft;
        }

        public FinalPurchase GetFinalPurchasingOrder()
        {
            return PurchasingInfo;
        }
    }
}

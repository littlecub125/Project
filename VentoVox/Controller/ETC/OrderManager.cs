using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentoVox.Interface;
using VentoVox.Model;

namespace VentoVox
{
    public class OrderManager 
    {

        public enum OrderPage
        {
            HOME,
            MENU,
            CHECK_OUT,
            PICK_UP,
            TIPS,
        }
        string _seqName = string.Empty;
        FinalPurchase _finalProduct = null;
        object order;
        static OrderManager _instance = null;
        private FinalPurchase Product
        {
            get { return _finalProduct; }
            set { _finalProduct = value; }
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
            this.Product = null;
        }


        // Step 1 Process
        public void StartBuildOrder()
        {
            Product = new FinalPurchase();
        }

        // Step 2 Process
        public void SelectFood(FoodData selectedFood, bool bAdd)
        {
            bool bFoodAvailable = false;
            bFoodAvailable = CheckFoodIsAvailable(selectedFood);
            // TODO 
            // web 에서 음식 가능한지 확인
            //if (bFoodAvailable == true && bAdd == true)

            if (bAdd == true)
            {
                Product.FoodDataAdd(selectedFood);
            }
            else if (bAdd == false)
            {
                Product.FoodDataRemove(selectedFood);
            }

        }

        private bool CheckFoodIsAvailable(FoodData selectedFood)
        {
            bool bRes = false;

            // KYB 20240530
            // To Do Data Manager를 통해 재고 확인


            return bRes;
        }
        // Step 3 Process
        public List<FoodData> GetFinalCheckOutItems()
        {
            List<FoodData> data = Product.GetItems();
            if (data == null)
            {
                return null;
            }
            
            return data;
        }


        public void CheckOut()
        {
            int nFoodTicketAvailable = CheckAvailableFoodTicket();



        }

        private int CheckAvailableFoodTicket()
        {
            int nFoodTicketLeft = 0;
            UserAccount User = UserAccount.GetInstance();
            nFoodTicketLeft = User.FoodTicketNum;

            return nFoodTicketLeft;

        }
    }
}

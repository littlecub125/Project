using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VentoVox.Model.UserAccount;
using static VentoVox.OrderManager;

namespace VentoVox.Model
{
    public class FinalPurchase
    {
        public OrderData data = new OrderData();

        public class OrderData
        {
            public string strOrderID;

            public DateTime strOrderedTime;

            public List<FoodData> foodSelected = new List<FoodData>();

            public AccountClassification classification;
        }

        public List<FoodData> GetItems()
        {
            List<FoodData> items = data.foodSelected;
            return items;
        }
        public bool SendFinalRequest()
        {
            bool bRes = false;

            OrderData requestData = data;
            
            return bRes;
        }


        public void FoodDataAdd(FoodData _selelctedFood)
        {
            data.foodSelected.Add(_selelctedFood);
        }

        public void FoodDataRemove(FoodData _selelctedFood)
        {
            data.foodSelected.Remove(_selelctedFood);
        }

    }
}

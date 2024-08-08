using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentoVox.Model
{
    public class FoodData
    {
        #region Parameter


        string _FoodName = "Sample Name";
        string _FoodID = "Sample ID";
        int _FoodQuantity = 0;
        DateTime _time = DateTime.Now;
        Image _FoodImage = null;
        string _FoodDescription = "Sample Description";
        bool _isFoodExpired = false;

        public string FoodID
        {
            get
            {
                return _FoodID;
            }
            set
            {
                _FoodID = value;
            }
        }
        public string FoodName
        {
            get
            {
                return _FoodName;
            }
            set
            {
                _FoodName = value;
            }
        }

        public Image FoodImage
        {
            get
            {
                return _FoodImage;
            }
            set
            {
                _FoodImage = value;
            }
        }

        public string FoodDescription
        {
            get
            {
                return _FoodDescription;
            }
            set
            {
                _FoodDescription = value;
            }
        }

        public int Stock
        {
            get
            {
                return _FoodQuantity;
            }
            set
            {
                _FoodQuantity = value;
            }
        }

        public DateTime expirationTime
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        public bool ExpiredFood
        {
            get
            {
                return _isFoodExpired;
            }
            set
            {
                _isFoodExpired = value;
            }
        }
        #endregion

        #region Functions
        public FoodData(string name, Image image, string description, int quantity, DateTime dateTime)
        {
            FoodName = name;
            FoodImage = image;
            FoodDescription = description;
            Stock = quantity;
            expirationTime = dateTime;
            if (DateTime.Compare(DateTime.Now, expirationTime) == -1)
            {
                ExpiredFood = false;
            }
            else
            {
                ExpiredFood = true;
            }
        }

        #endregion
    }
}

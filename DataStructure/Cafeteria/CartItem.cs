using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class CartItem
    {
        private static int s_foodID=101;

        public string FoodID{get;}

        public string FoodName{get;set;}

        public int FoodPrice{get;set;}

        public int AvailableQuantity{get;set;}

        public CartItem(string foodName,int foodPrice,int availableQuantity)
        {
            FoodID="FID"+(++s_foodID);
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=availableQuantity;
        }

    }
}
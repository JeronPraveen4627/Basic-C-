using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class CartItem
    {
        private static int s_foodID=101;

        public static string OrderID{get;set;}
        public string FoodID{get;}


        public int FoodPrice{get;set;}

        public int AvailableQuantity{get;set;}

        public CartItem(string orderID,string foodID,int foodPrice,int availableQuantity)
        {
            FoodID="FID"+(++s_foodID);
            OrderID=orderID;
            FoodID=foodID;
            FoodPrice=foodPrice;
            AvailableQuantity=availableQuantity;
        }

    }
}
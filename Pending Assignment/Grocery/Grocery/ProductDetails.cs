using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public class ProductDetails
    {
        //Properties: ProductID {Auto Increment – PID2000}, ProductName, QuantityAvailable, PricePerQuantity
        private static int s_productID=2000;

        public string ProductID{get;}

        public string ProductName{get;set;}
        public int QuantityAvailable{get;set;}

        public int PricePerQuantity{get;set;}

        public ProductDetails(string productName,int quantityAvailable,int pricePerQuantity)
        {
            ProductID="PID"+(++s_productID);
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"ProductID : {ProductID}");
            Console.WriteLine($"ProductName : {ProductName}");
            Console.WriteLine($"QuantityAvailable : {QuantityAvailable}");
            Console.WriteLine($"PricePerQuantity : {PricePerQuantity}");

        }
    }
}